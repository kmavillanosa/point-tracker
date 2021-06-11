using MiniBank;
using MiniBank.Entities;
using MiniBank.Repositories;
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

            btn_deposit.Enabled = HasAccountSelected;
            lbl_balance.ForeColor = AccountColorMode;
            lbl_code.Text = e.Code;

            lbl_balance.Text =$"₱{_transactionRepository.CheckBalance()}";

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

                lbl_balance.Text = $"₱{_transactionRepository.CheckBalance()}";
                btn_witdraw.Enabled = _transactionRepository.ValidateIfAllowedForWithdrawal();

                account.Transactions.Reverse();

                _transactionBindings.DataSource = account.Transactions;
                transactionsGrid.DataSource = _transactionBindings;
                _transactionBindings.ResetBindings(true);

            };

            _transactionRepository.OnWithdraw += (s, account) =>
            {
                lbl_balance.ForeColor = AccountColorMode;

                lbl_balance.Text = $"₱{_transactionRepository.CheckBalance()}";
                btn_witdraw.Enabled = _transactionRepository.ValidateIfAllowedForWithdrawal();


                account.Transactions.Reverse();

                _transactionBindings.DataSource = account.Transactions;
                transactionsGrid.DataSource = _transactionBindings;
                _transactionBindings.ResetBindings(true);
            };



        }


        private void link_lbl_code_change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagePanel.Panel1Collapsed = true;
            ManagePanel.Panel2.Controls.Clear();
            ManagePanel.Panel2Collapsed = false;
            AccountSelector selector = new AccountSelector(OnAccountSelect, OnAccountSelectionCancelled);
            selector.Dock = DockStyle.Fill;
            ManagePanel.Panel2.Controls.Add(selector);
        }

        private void btn_witdraw_Click(object sender, EventArgs e)
        {
            _transactionRepository.Withdraw(100);
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            _transactionRepository.Deposit(100);
        }
    }
}
