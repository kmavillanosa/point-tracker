using point_tracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_tracker.Repositories
{
    public interface ITransactionRepository
    {
        void SetState(int idx, bool state);
        bool ValidateIfAllowedForWithdrawal();
        bool ValidateIfAllowedForWithdrawal(int amount);
        Account Withdraw(int amount, string remarks);
        Account Deposit(int amount, string remarks);
        int CheckBalance();
    }
}
