using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_task.Data
{
    public interface IUserRepository
    {
        void UpdateBalance(string userId, double balance);
    }
}
