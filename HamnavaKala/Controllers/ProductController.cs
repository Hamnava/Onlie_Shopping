using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.ViewModels;
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
            ViewBag.Gallery = _product.ShowGallery(id);
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

        [Route("compare/{id?}/{id2?}/{id3?}")]
        public IActionResult Compare(int id, int? id2, int? id3)
        {
            List<int?> Listid = new List<int?> { id, id2, id3 };

            if (id <= 0 )
            {
                return RedirectToAction("Index", "Home");
            }
            var ListProduct = _product.Showcompareproduct(Listid);

            var productgroup = ListProduct.GroupBy(p => p.productid).Select(p => new comapreviewmodel
            {
                categoryid = p.FirstOrDefault().categoryid,
                productfatitle = p.FirstOrDefault().productfatitle,
                productid = p.Key,
                productimg = p.FirstOrDefault().productimg,
                productprice = p.FirstOrDefault().productprice,
                Compareviewmodel = p.FirstOrDefault().Compareviewmodel,

            }).ToList();

            ViewBag.property = _product.ShowPropertyCompare(productgroup[0].categoryid);
            ViewBag.Product = _product.GetProductForCompare(productgroup[0].categoryid, Listid);
            return View(productgroup.OrderBy(p => p.productid));

        }
    }
}
