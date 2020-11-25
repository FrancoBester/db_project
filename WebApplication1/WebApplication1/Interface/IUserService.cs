using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interface
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();
        User GetUserById(int eid);
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(User user);
    }
}
