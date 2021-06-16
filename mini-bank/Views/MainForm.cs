using point_tracker;
using point_tracker.Entities;
using point_tracker.Repositories;
using point_tracker.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace mini_bank
{
    public partial class MainForm : Form
    {
        private TransactionRepository _transactionRepository;
        private BindingSource _transactionBindings = new BindingSource();

        public event EventHandler<Account> OnAccountSelect;
        public event EventHandler OnAccountSelectionCancelled;

        private Account Account { get; set; }


        private bool HasAccountSelected { get { return  _transactionRepository != null; } }
        private Color AccountColorMode
        {
            get
            {
                if (_transactionRepository != null && _transactionRepository.ValidateIfAllowedForWithdrawal())
                    return Color.Green;
                else
                    return Color.Red;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            btn_deposit.Enabled = HasAccountSelected;
            btn_witdraw.Enabled = HasAccountSelected;

            OnAccountSelect += MainForm_OnAccountSelect;
            OnAccountSelectionCancelled += MainForm_OnAccountSelectionCancelled;
        }

        private void MainForm_OnAccountSelectionCancelled(object sender, EventArgs e)
        {
            ManagePanel.Panel2.Controls.Clear();
            ManagePanel.Panel2Collapsed = true;
            ManagePanel.Panel1Collapsed = false;
        }

        private void MainForm_OnAccountSelect(object sender, Account e)
        {
            _transactionRepository = new TransactionRepository(e);
            Account = e;

            btn_deposit.Enabled = HasAccountSelected;
            lbl_balance.ForeColor = AccountColorMode;
            lbl_code.Text = e.Code;

            lbl_balance.Text =$"{_transactionRepository.CheckBalance()}";
            lbl_summary.Text = $"{Account.Name}:( {Account.Description} )";

            btn_witdraw.Enabled = _transactionRepository.ValidateIfAllowedForWithdrawal();

            ManagePanel.Panel2.Controls.Clear();
            ManagePanel.Panel2Collapsed = true;
            ManagePanel.Panel1Collapsed = false;


            e.Transactions.Reverse();
            _transactionBindings.DataSource = e.Transactions;
            transactionsGrid.DataSource = _transactionBindings;
            _transactionBindings.ResetBindings(true);


            _transactionRepository.OnDeposit += (s, account) =>
            {
                lbl_balance.ForeColor = AccountColorMode;

                lbl_balance.Text = $"{_transactionRepository.CheckBalance()}";
                btn_witdraw.Enabled = _transactionRepository.ValidateIfAllowedForWithdrawal();

                account.Transactions.Reverse();

                Account = account;

                _transactionBindings.DataSource = account.Transactions;
                transactionsGrid.DataSource = _transactionBindings;
                _transactionBindings.ResetBindings(true);


            };

            _transactionRepository.OnWithdraw += (s, account) =>
            {
                lbl_balance.ForeColor = AccountColorMode;

                lbl_balance.Text = $"{_transactionRepository.CheckBalance()}";
                btn_witdraw.Enabled = _transactionRepository.ValidateIfAllowedForWithdrawal();
                account.Transactions.Reverse();

                Account = account;


                _transactionBindings.DataSource = account.Transactions;
                transactionsGrid.DataSource = _transactionBindings;
                _transactionBindings.ResetBindings(true);
            };
        }


        private void link_lbl_code_change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void btn_witdraw_Click(object sender, EventArgs e)
        {
            var createTransaction = new CreateTransaction(_transactionRepository,TransactionType.Withdraw);
            if(createTransaction.ShowDialog() == DialogResult.OK)
            {
                _transactionRepository.Withdraw(createTransaction.Amount, createTransaction.Remarks);
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            var createTransaction = new CreateTransaction(_transactionRepository, TransactionType.Deposit);
            if (createTransaction.ShowDialog() == DialogResult.OK)
            {
                _transactionRepository.Deposit(createTransaction.Amount, createTransaction.Remarks);
            }
        }

        private void transactionsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            transactionsGrid.Invoke(new Action(() => 
            {
                if (e.ColumnIndex == 0)
                {
                    var currentTransaction = Account.Transactions[e.RowIndex];
                    e.Value = currentTransaction.IsActive ? "Deactivate" : "Activate";

                    transactionsGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor
                        = currentTransaction.IsActive ? ColorTranslator.FromHtml("#C8E6C9") : ColorTranslator.FromHtml("#e17055");


                }
            }));
            
       

          
        }

        private void transactionsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {

                var result = MessageBox.Show("Are you sure you want to set changes to this transaction?", "Set Active State", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var currentTransaction = Account.Transactions[e.RowIndex];
                    _transactionRepository.SetState(e.RowIndex, !currentTransaction.IsActive);

                    lbl_balance.ForeColor = AccountColorMode;
                    lbl_balance.Text = $"{_transactionRepository.CheckBalance()}";
                    btn_witdraw.Enabled = _transactionRepository.ValidateIfAllowedForWithdrawal();
                }
            }
        }

        private void lbl_summary_Click(object sender, EventArgs e)
        {
            ManagePanel.Panel1Collapsed = true;
            ManagePanel.Panel2.Controls.Clear();
            ManagePanel.Panel2Collapsed = false;
            AccountSelector selector = new AccountSelector(OnAccountSelect, OnAccountSelectionCancelled);
            selector.Dock = DockStyle.Fill;
            ManagePanel.Panel2.Controls.Add(selector);
        }
    }
}
