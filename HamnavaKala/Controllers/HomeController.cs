using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamnavaKala.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace HamnavaKala.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IProductServices _product;
        public HomeController(IProductServices product)
        {
            _product = product;
        }
        public IActionResult Index()
        {
            ViewBag.special = _product.ShowallSpecialPrice();
            return View();
        }
    }
}
