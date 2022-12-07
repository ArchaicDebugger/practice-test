using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_task.Data
{
    public class UserRepository : IUserRepository
    {
        public void UpdateBalance(string userId, double balance)
        {
            Console.WriteLine("Updating balance for user " + userId + " to " + balance);
        }
    }
}
