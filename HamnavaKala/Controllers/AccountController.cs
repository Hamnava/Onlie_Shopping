using HamnavaKala.Core.Classes;
using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.ViewModels;
using HamnavaKala.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamnavaKala.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserservice _user;
        public AccountController(IUserservice user)
        {
            _user = user;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Register(userRegisterViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            if (_user.ExistEmail(user.Email, 0))
            {
                ModelState.AddModelError("Email", "این ایمیل قبلا توسط یک کاربر دیگر این سابت استفاده شده است.");
                return View(user);
            }
            User adduser = new User()
            {
                Email = user.Email,
                CreateDate = DateTime.Now,
                Password = user.Password.EncodePasswordMd5(),
                userAccount = user.username,
                IsActive = false,
                IsDelete = false
            };
           var result = _user.RegisterUser(adduser);
            if (result > 0)
            {
                return View("Welcome",user.Email);
            }
            return View(user);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
