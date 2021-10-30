using HamnavaKala.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamnavaKala.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _product;
        public ProductController(IProductServices product)
        {
            _product = product;
        }
        public IActionResult ProductDetails(int id)
        {
            var d = _product.ShowDetailsProduct(id);
            ViewBag.Property = _product.showViewforProduct(id);
            return View(d);
        }

        public IActionResult ShowReview(int id)
        {
            var review = _product.Findreviewbyproduct(id);
            return View(review);
        }

        public IActionResult ShowAllProperty(int id)
        {
            return View(_product.ShowAllPropertyforProduct(id));
        }

        public IActionResult ShowCommentsForProduct(int id)
        {
            return View(_product.ShowuserCommentsForProduct(id));
        }

        public IActionResult ShowAllFaq(int id)
        {
            return View(_product.ShowallQuestionAnswer(id));
        }
    }
}
