using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using practice_task.Models;
using practice_task.Services;

namespace practice_task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _serviceAccount;
        public AccountController(IAccountService serviceAccount)
        {
            _serviceAccount = serviceAccount;
        }

        [HttpGet]
        public IEnumerable<Models.BankAccount> Get()
        {
            var accounts = _serviceAccount.GetBankAccounts();

            accounts.Where(s => s is InterestBankAccount)
                .Select(s => s as InterestBankAccount)
                .Select(s =>
                {
                    s.InterestRate += 6;
                    s.Name = "INTEREST" + " - " + s.Name;
                    return s;
                })
                .ToList();

            return accounts;
        }

        [HttpGet("{name}")]
        public Models.BankAccount Get(string name)
        {
            return new Models.BankAccount { Name = name, Balance = 1000, Currency = "USD" };
        }

        [HttpPost]
        public void Post([FromBody] Models.BankAccount account)
        {

        }

        [HttpPut]
        public void Put(string accountName, [FromBody] double balance)
        {
            _serviceAccount.UpdateBankAccountBalance(accountName, balance);
        }
    }
}
