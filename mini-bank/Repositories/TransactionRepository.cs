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

        public Account Withdraw(decimal amount)
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
                        Remarks = "Withdrawal for this account",
                        Type = TransactionType.Withdraw
                    });
                };
                OnWithdraw?.Invoke(this, account);
            }

            return account;
        }

        public Account Deposit(decimal amount)
        {
            using(var stateSaver = new StateSaver<Account>($@"Data/{account.Code}.json", account))
            {
                account.Transactions.Add(new Transaction()
                {
                    Amount = amount,
                    EntryDate = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    Remarks = "deposit for this account",
                    Type = TransactionType.Deposit
                });
            };

            OnDeposit?.Invoke(this, account);

            return account;
        }


        public decimal CheckBalance()
        {
            var totalDeposits = account.Transactions.Where(x => x.Type == TransactionType.Deposit).Sum(x => x.Amount);
            var totalWithdrawal = account.Transactions.Where(x => x.Type == TransactionType.Withdraw).Sum(x => x.Amount);
            return totalDeposits - totalWithdrawal;
        }

       
    }
}
