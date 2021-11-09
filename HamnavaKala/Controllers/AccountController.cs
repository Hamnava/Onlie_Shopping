using HamnavaKala.Core.Classes;
using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.ViewModels;
using HamnavaKala.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HamnavaKala.Core.Classes.RenderEmail;

namespace HamnavaKala.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserservice _user;
        private readonly IViewRenderService _renderEmail;
        public AccountController(IUserservice user, IViewRenderService renderEmail)
        {
            _user = user;
            _renderEmail = renderEmail;
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
                IsDelete = false,
                ActiceCode = GeneratCode.GuidCode()
            };
           var result = _user.RegisterUser(adduser);
            if (result > 0)
            {
                var render = _renderEmail.RenderToStringAsync("_activate", adduser);
                sendEmail.Send(user.Email, "فعال سازی حساب", render);
                return View("Welcome",user.Email);
            }
            return View(user);
        }

        public IActionResult Welcome()
        {
            return View();
        }

        [Route("Account/ActiveAccount/{userid}/{Code}")]
        public IActionResult ActiveAccount(int userid, string Code)
        {
            var user = _user.FindUser(userid, Code);
            if (user != null)
            {
                return NotFound();
            }
            user.IsActive = true;
            user.ActiceCode = GeneratCode.GuidCode();
            _user.Updateuser(user);
            return RedirectToAction("Index", "Home");
            
        }
    }
}
