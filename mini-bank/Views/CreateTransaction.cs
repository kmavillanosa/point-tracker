using point_tracker.Entities;
using point_tracker.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_tracker.Views
{
    public partial class CreateTransaction : Form
    {
        private readonly TransactionType type;

        public int Amount { get; set; }
        public string Remarks { get; set; }
        public TransactionRepository Repository { get; }

        public CreateTransaction()
        {
            InitializeComponent();
        }
        public CreateTransaction(TransactionRepository repository, TransactionType type) : this()
        {
            Repository = repository;
            this.type = type;
            Text = $"Create {type} Transaction";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_amount.Text))
            {
                Amount = Convert.ToInt32(txt_amount.Text);
                Remarks = txt_remarks.Text;

                if (type == TransactionType.Demerit)
                {
                    if (!Repository.ValidateIfAllowedForWithdrawal(Amount))
                    {
                        MessageBox.Show($"Requested value for merit exceeds account balance of: {Repository.CheckBalance()}");
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                    }

                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Provide value");
            }

        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one int point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
