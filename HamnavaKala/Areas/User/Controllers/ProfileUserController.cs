using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.ViewModels;
using HamnavaKala.DataLayer.Entities.Address;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamnavaKala.Areas.User.Controllers
{
    [Area("User")]
    public class ProfileUserController : Controller
    {
        private readonly IUserservice _user;
        private readonly IAddressService _address;
        public ProfileUserController(IUserservice user, IAddressService address)
        {
            _user = user;
            _address = address;
        }
        
        public IActionResult Index()
        {
            int userid = int.Parse(User.FindFirst("userid").Value);
            return View(_user.informationAccount(userid));
           
        }

        [Authorize]
        public IActionResult Address()
        {
            int userid = int.Parse(User.FindFirst("userid").Value);
            ViewBag.information = _user.informationAccount(userid);
            return View(_address.findaddressforuser(userid));
        }

        [HttpGet]
       
        public IActionResult AddAddres()
        {
            int userid = int.Parse(User.FindFirst("userid").Value);
            ViewBag.province = _address.showallProvince();
            ViewBag.information = _user.informationAccount(userid);
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddAddres(useraddress model)
        {
            int userid = int.Parse(User.FindFirst("userid").Value);
            model.userid = userid;
            if (!ModelState.IsValid)
            {
                ViewBag.province = _address.showallProvince();
                ViewBag.information = _user.informationAccount(userid);
                return View(model);
            }
            ViewBag.information = _user.informationAccount(userid);
            int addresid = _address.addusraddress(model);
            TempData["Result"] = addresid > 0 ? "true" : "false";
            return RedirectToAction(nameof(Address));

        }


        [HttpPost]
        [Route("City")]
        public IActionResult City(int id)
        {
            var city = _address.showallcityForProvince(id);
            return Json(city);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Updateaddress()
        {
            int userid = int.Parse(User.FindFirst("userid").Value);
            ShowAddressForUserViewmodel useraddress = _address.findaddressforuser(userid);
            ViewBag.province = _address.showallProvince();
            ViewBag.City = _address.showallcityForProvince(useraddress.provinceid);
            ViewBag.information = _user.informationAccount(userid);
            return View(useraddress);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Updateaddress(ShowAddressForUserViewmodel viewmodel)
        {
            int userid = int.Parse(User.FindFirst("userid").Value);
            if (!ModelState.IsValid)
            {
                ViewBag.province = _address.showallProvince();
                ViewBag.City = _address.showallcityForProvince(viewmodel.provinceid);
                ViewBag.information = _user.informationAccount(userid);
                return View(viewmodel);
            }
            useraddress useraddress = new useraddress
            {
                addresid = viewmodel.addresid,
                cityid = viewmodel.cityid,
                FullAddress = viewmodel.FullAddress,
                Isdelete = false,
                Landlinephonenumber = viewmodel.Landlinephonenumber,
                phone = viewmodel.phone,
                Plaque = viewmodel.Plaque,
                postalCode = viewmodel.postalCode,
                provinceid = viewmodel.provinceid,
                Recipientname = viewmodel.Recipientname,
                unit = viewmodel.unit,
                userid = userid
            };

            bool updateaddres = _address.updateaddress(useraddress);
            TempData["Result"] = updateaddres ? "true" : "false";
            return RedirectToAction(nameof(Address));

        }

        //[HttpGet]
        //[Authorize]
        //[Route("EditUser")]
        //public IActionResult EditUser()
        //{
        //    int userid = int.Parse(User.FindFirst("userid").Value);
        //    ViewBag.information = _usersevice.informationAccount(userid);
        //    return View(_usersevice.finduserbuyeid(userid));
        //}

        //[HttpPost]
        //[Authorize]
        //[Route("EditUser")]
        //public IActionResult EditUser(edituserViewmodel edituser)
        //{
        //    int userid = int.Parse(User.FindFirst("userid").Value);
        //    var model = _usersevice.findEditUserbuyeid(userid);

        //    model.userfamily = edituser.userfamily;
        //    model.username = edituser.username;
        //    model.email = edituser.email;
        //    model.phone = edituser.phone;

        //    _usersevice.updateuser(model);
        //    return RedirectToAction(nameof(Index));

        //}

        //[HttpGet]
        //[Authorize]
        //[Route("favoirate")]
        //public IActionResult favoirate()
        //{
        //    int userid = int.Parse(User.FindFirst("userid").Value);
        //    ViewBag.information = _usersevice.informationAccount(userid);
        //    return View(_usersevice.showfavoirateUser(userid));
        //}

        //[Route("showorder")]
        //[Authorize]
        //public IActionResult showorder()
        //{
        //    int userid = int.Parse(User.FindFirst("userid").Value);
        //    ViewBag.information = _usersevice.informationAccount(userid);
        //    return View(_usersevice.showorderForUsers(userid));

        //}


        //[Route("mycomment")]
        //[Authorize]
        //public IActionResult mycomment()
        //{
        //    int userid = int.Parse(User.FindFirst("userid").Value);
        //    ViewBag.information = _usersevice.informationAccount(userid);
        //    return View(_usersevice.mycomment(userid));
        //}

        //[Route("showDetailorders/{id}")]
        //[Authorize]
        //public IActionResult showDetailorders(int id)
        //{
        //    int userid = int.Parse(User.FindFirst("userid").Value);
        //    ViewBag.information = _usersevice.informationAccount(userid);
        //    return View(_usersevice.showDetailorders(id));
        //}
    }
}
