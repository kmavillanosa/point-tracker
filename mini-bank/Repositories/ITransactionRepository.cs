using MiniBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Repositories
{
    public interface ITransactionRepository
    {
        void SetState(int idx, bool state);
        bool ValidateIfAllowedForWithdrawal();
        bool ValidateIfAllowedForWithdrawal(decimal amount);
        Account Withdraw(decimal amount, string remarks);
        Account Deposit(decimal amount, string remarks);
        decimal CheckBalance();
    }
}
