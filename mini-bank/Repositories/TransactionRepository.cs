using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Account account;

        public event EventHandler<Account> OnDeposit;
        public event EventHandler<Account> OnWithdraw;

        public TransactionRepository(Account account)
        {
            this.account = account;
        }

        public bool ValidateIfAllowedForWithdrawal(decimal amount)
        {
            return CheckBalance() >= amount;
        }

        public bool ValidateIfAllowedForWithdrawal()
        {
            return CheckBalance() > 0;
        }

        public void SetState(int idx, bool state)
        {
            using (var stateSaver = new StateSaver<Account>($@"Data/{account.Code}.json", account))
            {
                account.Transactions[idx].IsActive = state;
            }
        }


        public Account Withdraw(decimal amount, string remarks = "Account withdrawal")
        {
            if (ValidateIfAllowedForWithdrawal(amount))
            {
                using (var stateSaver = new StateSaver<Account>($@"Data/{account.Code}.json", account))
                {
                    account.Transactions.Add(new Transaction()
                    {
                        Amount = amount,
                        EntryDate = DateTime.Now,
                        Id = Guid.NewGuid().ToString(),
                        Remarks = remarks,
                        Type = TransactionType.Withdraw,
                        IsActive = true
                    });
                };
                OnWithdraw?.Invoke(this, account);
            }

            return account;
        }

        public Account Deposit(decimal amount, string remarks = "Account deposit")
        {
            using(var stateSaver = new StateSaver<Account>($@"Data/{account.Code}.json", account))
            {
                account.Transactions.Add(new Transaction()
                {
                    Amount = amount,
                    EntryDate = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    Remarks = remarks,
                    Type = TransactionType.Deposit,
                    IsActive = true
                });
            };

            OnDeposit?.Invoke(this, account);

            return account;
        }


        public decimal CheckBalance()
        {
            var totalDeposits = account.Transactions.Where(x => x.Type == TransactionType.Deposit && x.IsActive).Sum(x => x.Amount);
            var totalWithdrawal = account.Transactions.Where(x => x.Type == TransactionType.Withdraw && x.IsActive).Sum(x => x.Amount);
            return totalDeposits - totalWithdrawal;
        }

      
    }
}
