using MiniBank.Entities;
using MiniBank.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBank.Views
{
    public partial class CreateAccount : Form
    {
        public Account Current { get; set; }
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Current = new Account()
            {
                Code = txt_code.Text,
                Description = txt_desc.Text,
                Name = txt_name.Text,
                Id = Guid.NewGuid().ToString()
            };

            using (var stateSaver = new StateSaver<Account>($@"Data/{txt_code.Text}.json", Current))
            {
            };
        }
    }
}
