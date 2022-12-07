using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice_task.Models;

namespace practice_task.Data
{
    public class AccountRepository : IAccountRepository
    {
        public List<BankAccount> GetAccounts()
        {
            return new List<BankAccount>
            {
                new BankAccount
                {
                    UserId = "1",
                    Name = "My Bank Account",
                    Balance = 1000,
                    Currency = "USD"
                },
                new LoanBankAccount
                {
                    Name = "My Loan Account",
                    Balance = 0,
                    Currency = "USD",
                    LoanLimit = 1000
                },
                new InterestBankAccount
                {
                    Name = "My Interest Account",
                    Balance = 1000,
                    Currency = "USD",
                    InterestRate = 0.03
                },
                new InterestBankAccount
                {
                    Name = "Other INT Account 2",
                    Balance = 1000,
                    Currency = "USD",
                    InterestRate = 0.03
                }
            };
        }

        public void AddAccount(BankAccount account)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(BankAccount account)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(BankAccount account)
        {
            Console.WriteLine("Account updated");
        }
    }
}
