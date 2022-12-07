using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice_task.Models;

namespace practice_task.Services
{
    public interface IAccountService
    {
        List<BankAccount> GetBankAccounts();
        void UpdateBankAccountBalance(string accountName, double balance);
    }
}
