using point_tracker.Entities;
using point_tracker.Views;
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

namespace point_tracker
{
    public partial class AccountSelector : UserControl
    {
        private readonly EventHandler<Account> onSelectEvent;
        private readonly EventHandler onCancelled;


        public string[] Files { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();

        private BindingSource AccountBinding = new BindingSource();

        public AccountSelector()
        {
            InitializeComponent();

            Initialize();
           
        }


        private void Initialize()
        {
            var currentDirectory = Path.Combine(Environment.CurrentDirectory, "Data");

            if (!Directory.Exists(currentDirectory))
                Directory.CreateDirectory(currentDirectory);

            Files = Directory.GetFiles(currentDirectory);

            Accounts = Files.Select(x => JsonConvert.DeserializeObject<Account>(File.ReadAllText(x))).ToList();
            AccountBinding.DataSource = Accounts;
            grid_accounts.DataSource = AccountBinding;
        }

        public AccountSelector(EventHandler<Account> onSelectEvent, EventHandler onCancelled) : this()
        {
            this.onSelectEvent = onSelectEvent;
            this.onCancelled = onCancelled;
        }

        private void grid_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex != -1) onSelectEvent(this, Accounts[e.RowIndex]);

            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                var result = MessageBox.Show("Are you sure you want to remove this account?", "Changes cannot be reverted.", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    File.Delete(Files[e.RowIndex]);
                    Initialize();
                }
            }

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
