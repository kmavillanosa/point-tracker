using MiniBank.Entities;
using MiniBank.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBank
{
    public partial class AccountSelector : UserControl
    {
        private readonly EventHandler<Account> onSelectEvent;
        private readonly EventHandler onCancelled;

        public List<Account> Accounts { get; set; } = new List<Account>();

        public AccountSelector()
        {
            InitializeComponent();

            var currentDirectory = Path.Combine(Environment.CurrentDirectory, "Data");

            if (!Directory.Exists(currentDirectory))
                Directory.CreateDirectory(currentDirectory);

            var files = Directory.GetFiles(currentDirectory);


            Accounts = files.Select(x => JsonConvert.DeserializeObject<Account>(File.ReadAllText(x))).ToList();
            grid_accounts.DataSource = Accounts;
        }

        public AccountSelector(EventHandler<Account> onSelectEvent, EventHandler onCancelled) : this()
        {
            this.onSelectEvent = onSelectEvent;
            this.onCancelled = onCancelled;
        }

        private void grid_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex != -1) onSelectEvent(this, Accounts[e.RowIndex]);

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var account = new CreateAccount();
            if (account.ShowDialog() == DialogResult.OK)
            {
                onSelectEvent(this, account.Current);
            }
        }
    }
}
