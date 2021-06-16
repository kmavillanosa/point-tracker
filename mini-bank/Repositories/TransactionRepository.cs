using point_tracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_tracker.Repositories
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

        public bool ValidateIfAllowedForWithdrawal(int amount)
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


        public Account Withdraw(int amount, string remarks = "Account withdrawal")
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
                        Type = TransactionType.Demerit,
                        IsActive = true
                    });
                };
                OnWithdraw?.Invoke(this, account);
            }

            return account;
        }

        public Account Deposit(int amount, string remarks = "Account deposit")
        {
            using(var stateSaver = new StateSaver<Account>($@"Data/{account.Code}.json", account))
            {
                account.Transactions.Add(new Transaction()
                {
                    Amount = amount,
                    EntryDate = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    Remarks = remarks,
                    Type = TransactionType.Merit,
                    IsActive = true
                });
            };

            OnDeposit?.Invoke(this, account);

            return account;
        }


        public int CheckBalance()
        {
            var totalDeposits = account.Transactions.Where(x => x.Type == TransactionType.Merit && x.IsActive).Sum(x => x.Amount);
            var totalWithdrawal = account.Transactions.Where(x => x.Type == TransactionType.Demerit && x.IsActive).Sum(x => x.Amount);
            return totalDeposits - totalWithdrawal;
        }

      
    }
}
