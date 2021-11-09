using HamnavaKala.Core.Interfaces;
using HamnavaKala.DataLayer.Context;
using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Servieces
{
    public class Userservice : IUserservice
    {
        private readonly HamnavaKalaContext _context;
        public Userservice(HamnavaKalaContext context)
        {
            _context = context;
        }
        public bool Deleteuser(User user)
        {
            try
            {
                user.IsDelete = true;
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExistEmail(string email, int id)
        {
            return _context.Users.Any(u => u.Email == email && u.UserId != id);
        }

        public User FindUser(int id, string code)
        {
            return _context.Users.Where(u => u.UserId == id && u.ActiceCode == code).FirstOrDefault();
        }

        public User FindUserByEmail(string email)
        {
            return _context.Users.Where(u => u.Email == email).FirstOrDefault();
        }

        public User LoginUser(string email, string password)
        {
            return _context.Users.Where(u => u.Password == password && u.Email == email).SingleOrDefault();
        }

        public int RegisterUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user.UserId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Updateuser(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
