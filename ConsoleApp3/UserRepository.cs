using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class UserRepository : IRepository<User>
    {
        public bool Create(User t)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
