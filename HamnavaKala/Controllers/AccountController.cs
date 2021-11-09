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

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(forgotpasswordViewModel model)
        {
            var user = _user.FindUserByEmail(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "کاربری با این مشخصات پیدا نشد");
                return View(model);
            }
           

            var render = _renderEmail.RenderToStringAsync("_recoveryPassword", user);
            sendEmail.Send(user.Email, "باز یابی رمز عبور", render);
            return View("RecoveryMessage", user.Email);
        }

        public IActionResult RecoveryMessage()
        {
            return View();
        }

        [Route("Account/Recovery/{userid}/{Code}")]
        public IActionResult Recovery(int userid, string Code)
        {
            User user = _user.FindUser(userid, Code);
            forgotpasswordViewModel viewModel = new forgotpasswordViewModel
            {
                userid = user.UserId,
                Email = user.Email
            };
            if (user != null)
            {
                return View("Recovery", viewModel);
            }
            return View("Index", "Home");
        }

        [HttpPost]
        [Route("Account/Recovery/{userid}/{Code}")]
        public IActionResult Recovery(forgotpasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Recovery", model);
            }

            User user = _user.FindUserByEmail(model.Email);
            if (user != null)
            {
                user.ActiceCode = GeneratCode.GuidCode();
                user.Password = model.Password.EncodePasswordMd5();
            }

            bool update = _user.Updateuser(user);
            TempData["Result"] = update ? "true" : "false";
            return View("Recovery");
        }
    }
}
