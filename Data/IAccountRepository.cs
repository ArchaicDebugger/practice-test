using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice_task.Models;

namespace practice_task.Data
{
    public interface IAccountRepository
    {
        List<BankAccount> GetAccounts();
        void AddAccount(BankAccount account);
        void UpdateAccount(BankAccount account);
        void DeleteAccount(BankAccount account);
    }
}
