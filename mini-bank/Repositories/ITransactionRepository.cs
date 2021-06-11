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
        bool ValidateIfAllowedForWithdrawal();
        bool ValidateIfAllowedForWithdrawal(decimal amount);
        Account Withdraw(decimal amount);
        Account Deposit(decimal amount);
        decimal CheckBalance();
    }
}
