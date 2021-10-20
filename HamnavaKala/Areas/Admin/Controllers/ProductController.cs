using HamnavaKala.Core.Interfaces;
using HamnavaKala.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamnavaKala.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductServices _product;
        public ProductController(IProductServices product)
        {
            _product = product;
        }
        public IActionResult ShowProductColor()
        {
            return View(_product.ShowAllProduct());
        }

        [HttpGet]
        public IActionResult AddProductColor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductColor(ProductColor productColor)
        {
            if (!ModelState.IsValid)
            {
                return View(productColor);
            }
            if (_product.ExistColor(productColor.colorName, productColor.colorCode, 0))
            {
                ModelState.AddModelError("ModelError", "این رنگ تکراری میباشد، لطفا یک رنگ دیگر را انتخاب نمایید");
                return View(productColor);
            }
            int colorid = _product.AddColor(productColor);
            TempData["Result"] = colorid > 0 ? "true" : "false";
            return RedirectToAction(nameof(ShowProductColor));
        }

        [HttpGet]
        public IActionResult UpdateColor(int id)
        {
            ProductColor color = _product.GetColorById(id);
            if (color == null)
            {
                return NotFound();
            }
            return View(color);
        }

        [HttpPost]
        public IActionResult UpdateColor(ProductColor productColor)
        {
            if (!ModelState.IsValid)
            {
                return View(productColor);
            }
            if (_product.ExistColor(productColor.colorName, productColor.colorCode, productColor.productColorId))
            {
                ModelState.AddModelError("ModelError", "این رنگ تکراری میباشد، لطفا یک رنگ دیگر را انتخاب نمایید");
                return View(productColor);
            }
            bool res = _product.UpdateColor(productColor);
            TempData["Result"] = res ? "true" : "false";
            return RedirectToAction(nameof(ShowProductColor));
        }
    }
}
