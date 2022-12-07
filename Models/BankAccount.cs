using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_task.Models
{
    public class BankAccount
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
    }
}
