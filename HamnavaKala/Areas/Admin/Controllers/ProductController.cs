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
        private readonly ICategoryService _category;
        public ProductController(IProductServices product, ICategoryService category)
        {
            _product = product;
            _category = category;
        }

        #region ProductColor

       
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

        #endregion

        #region ProductPropertyName
        [HttpGet]
        public IActionResult ShowProperties()
        {
            return View(_product.ShowAllProperty());
        }
        [HttpGet]
        public IActionResult AddProperty()
        {
            ViewBag.Category = _category.Showsubcategory();
            return View();
        }

        [HttpPost]
        public IActionResult AddProperty(ProductProperty propertyName, List<int> Categoryid)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = _category.Showsubcategory();
                return View(propertyName);
            }
            if (_product.ExistProperty(propertyName.ProductPropertyTitle, 0))
            {
                ModelState.AddModelError("ProductPropertyTitle", "خصوصیات تکراری است .");
                return View(propertyName);
            }
            int nameid = _product.AddPropertyName(propertyName);
            if (nameid <= 0)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowProperties));
            }
            List<ProductProperty_Category> Addpc = new List<ProductProperty_Category>();

            foreach (var item in Categoryid)
            {
                Addpc.Add(new ProductProperty_Category
                {
                    CategroyId = item,
                    ProductPropertyId = nameid,

                });
            }

            bool res = _product.AddpropertyForCategory(Addpc);
            TempData["Result"] = res ? "true" : "false";
            return RedirectToAction(nameof(ShowProperties));
        }

        [HttpGet]
        public IActionResult UpdateProperty(int id)
        {
            ViewBag.Category = _category.Showsubcategory();
            ViewBag.Propetry = _product.FindProductPropertyNameForUpdate(id);
            return View(_product.GetProductPropertyById(id));
        }
        [HttpPost]
        public IActionResult UpdateProperty(ProductProperty property,List<int> categoryid)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = _category.Showsubcategory();
                ViewBag.Propetry = _product.FindProductPropertyNameForUpdate(property.ProductPropertyId);
                return View();
            }
            if (_product.ExistProperty(property.ProductPropertyTitle, property.ProductPropertyId))
            {
                ModelState.AddModelError("ProductPropertyTitle", "خصوصیات تکراری است .");
                return View(property);
            }
            bool update = _product.UpdateProductProperty(property);
            if (!update)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowProperties));
            }
            bool deleteprop = _product.DeletePropertyforCategory(property.ProductPropertyId);
            if (!deleteprop)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowProperties));
            }
            List<ProductProperty_Category> categories = new List<ProductProperty_Category>();
            foreach (var item in categoryid)
            {
                categories.Add(new ProductProperty_Category
                {
                    CategroyId = item,
                    ProductPropertyId = property.ProductPropertyId
                });
            }
            bool res = _product.AddpropertyForCategory(categories);
            TempData["Result"] = res ? "true" : "false";
            return RedirectToAction(nameof(ShowProperties));
        }
        #endregion
    }
}
