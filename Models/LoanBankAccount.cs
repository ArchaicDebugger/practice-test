using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_task.Models
{
    public class LoanBankAccount : BankAccount
    {
        public double LoanLimit { get; set; }
    }
}
