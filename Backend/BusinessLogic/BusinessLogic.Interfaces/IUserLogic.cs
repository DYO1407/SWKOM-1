using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IUserLogic
    {
        User GetUser(int id);

        User CreateUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(int id);

    }
}
