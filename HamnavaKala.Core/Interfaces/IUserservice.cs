using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Interfaces
{
   public interface IUserservice
    {
        int RegisterUser(User user);
        bool Updateuser(User user);
        bool Deleteuser(User user);
        bool ExistEmail(string email, int id);
        User FindUser(int id, string code);
        User FindUserByEmail(string email);
    }
}
