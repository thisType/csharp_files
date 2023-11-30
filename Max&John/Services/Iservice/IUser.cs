using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John.Services.Iservice
{
    public interface IUser
    {
        public  Task<bool> TryRegister(UserModel user);

        public Task<UserModel[]> RegisteredUsers();
    }
}
