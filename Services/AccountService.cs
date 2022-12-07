using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice_task.Data;
using practice_task.Models;

namespace practice_task.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUserRepository _userRepository;
        public AccountService
        (
            IAccountRepository accountRepository,
            IUserRepository userRepository
        )
        {
            _accountRepository = accountRepository;
            _userRepository = userRepository;
        }

        public List<BankAccount> GetBankAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void UpdateBankAccountBalance(string accountName, double balance)
        {
            var accounts = _accountRepository.GetAccounts();
            var account = accounts.FirstOrDefault(a => a.Name == accountName);
            if (account != null)
            {
                account.Balance = balance;
                _accountRepository.UpdateAccount(account);
                _userRepository.UpdateBalance(account.UserId, balance);
            }
        }
    }
}
