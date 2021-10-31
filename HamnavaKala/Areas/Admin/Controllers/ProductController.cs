using HamnavaKala.Core.Classes;
using HamnavaKala.Core.Interfaces;
using HamnavaKala.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
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
        private readonly IBrand _brand;
        private readonly IGurantee _gurantee;

        public ProductController(IProductServices product, ICategoryService category, IBrand brand, IGurantee gurantee)
        {
            _product = product;
            _category = category;
            _brand = brand;
            _gurantee = gurantee;
        }

        #region ProductColor


        public IActionResult ShowProductColor()
        {
            return View(_product.ShowAllProductColor());
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
        public IActionResult UpdateProperty(ProductProperty property, List<int> categoryid)
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

        [HttpGet]
        public IActionResult DeleteProperty(int id)
        {
            var product = _product.GetProductPropertyById(id);
            return PartialView("_DeleteProperty", product);
        }

        [HttpPost]
        public IActionResult DeleteProperty(ProductProperty property)
        {
            property.IsDelete = true;
            bool update = _product.UpdateProductProperty(property);
            int sendJson = update ? 3 : 4;
            return Json(sendJson);
        }
        #endregion

        #region Product
        public IActionResult ShowProduct()
        {
            return View(_product.ShowallProduct());
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Category = _category.Showsubcategory();
            ViewBag.Brand = _brand.ShowAllBrands();
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = _category.Showsubcategory();
                ViewBag.Brand = _brand.ShowAllBrands();
                return View(product);
            }
            if (file == null)
            {
                ViewBag.Category = _category.Showsubcategory();
                ViewBag.Brand = _brand.ShowAllBrands();
                ModelState.AddModelError("ProductImage", "لطفا یک عکس برای محصول انتخاب نمایید");
                return View(product);
            }
            string imgname = uploadImg.CreateImg(file, "slider-product");
            if (imgname == "flase")
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(Index));
            }

            product.ProductImage = imgname;
            product.ProductCreate = DateTime.Now;

            int productid = _product.AddProduct(product);
            TempData["Result"] = productid > 0 ? "true" : "false";
            return RedirectToAction(nameof(ShowProduct));
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            Product product = _product.GetProductById(id);
            ViewBag.Category = _category.Showsubcategory();
            ViewBag.Brand = _brand.ShowAllBrands();
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = _category.Showsubcategory();
                ViewBag.Brand = _brand.ShowAllBrands();
                return View(product);
            }
            if (file != null)
            {
                string imgname = uploadImg.CreateImg(file, "slider-product");
                if (imgname == "false")
                {
                    TempData["Result"] = "false";
                    return RedirectToAction(nameof(Index));
                }
                bool DeleteImage = uploadImg.DeleteImg("slider-product", product.ProductImage);
                if (!DeleteImage)
                {
                    TempData["Result"] = "failed";
                    return RedirectToAction(nameof(Index));
                }
                product.ProductImage = imgname;
            }
            product.ProductUpate = DateTime.Now;
            bool update = _product.UpdateProduct(product);
            TempData["Result"] = update ? "true" : "false";
            return RedirectToAction(nameof(ShowProduct));
        }

        [HttpGet]
        public IActionResult ShowPropertyNameForProduct(int id)
        {
            int categoryid = _product.FindCategoryForproduct(id);
            ViewBag.propertyname = _product.showallPropertyforCategory(categoryid);
            ViewBag.propertyvalue = _product.showpropertyValue(id);
            TempData["productid"] = id;
            return PartialView("_propertyforproduct");
        }
        [HttpPost]
        public IActionResult AddpropertyforProduct(List<int> nameid, List<string> value)
        {
            int productid = int.Parse(TempData["productid"].ToString());
            if (nameid.Count() != value.Count())
            {
                int categoryid = _product.FindCategoryForproduct(productid);
                ViewBag.propertyname = _product.showallPropertyforCategory(categoryid);
                ViewBag.propertyvalue = _product.showpropertyValue(productid);
                TempData["productid"] = productid;
                return View(nameof(ShowProduct));
            }
            List<PropertyValue> propertyValues = new List<PropertyValue>();
            for (int i = 0; i < nameid.Count; i++)
            {
                propertyValues.Add(new PropertyValue
                {
                    ProductId = productid,
                    Propertvalue = value[i],
                    productpropertyid = nameid[i]
                });
            }
            List<PropertyValue> PropertyValue = propertyValues.Where(p => p.Propertvalue != null).ToList();
            bool res = _product.AddOrUpdateproductPropertyForProduct(productid, PropertyValue);
            int sendJson = res ? 1 : 4;
            return Json(sendJson);
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var product = _product.GetProductById(id);
            return PartialView("_deleteProduct", product);
        }

        [HttpPost]
        public IActionResult DeleteProductpost(Product product)
        {
            product.ProductUpate = DateTime.Now;
            product.IsDelete = true;
            bool delete = _product.UpdateProduct(product);
            int sendJson = delete ? 3 : 4;
            return Json(sendJson);
        }


        #endregion

        #region ProductGallery
        public IActionResult AddGallery(int id)
        {
            ViewBag.productid = id;
            return View();
        }
        [HttpPost]
        public IActionResult AddGallery(ProductGallery gallery, IFormFile file)
        {
            string imgname = uploadImg.CreateImg(file, "P_Gallery");
            gallery.Imgname = imgname;
            if (!ModelState.IsValid)
            {
                return View(gallery);
            }
            if (file == null)
            {
                ModelState.AddModelError("Imgname", "لطفا یک عکس برای محصول انتخاب نمایید");
                return View(gallery);
            }
            
            if (imgname == "flase")
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowProduct));
            }
            _product.addGallery(gallery);
            return RedirectToAction(nameof(AddGallery));
        }

        [HttpGet]
        public IActionResult ShowGallery(int id)
        {
            List<ProductGallery> gallery = _product.ShowGallery(id);
            return View(gallery);
        }
        #endregion

        #region Review
        public IActionResult AddReview(int id)
        {
            ViewBag.review = _product.Findreviewbyproduct(id);
            TempData["productid"] = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(List<string> positive, List<string> negative, Review review)
        {
            int productid = int.Parse(TempData["productid"].ToString());
            if (!ModelState.IsValid)
            {
                ViewBag.review = _product.Findreviewbyproduct(productid);
                TempData["productid"] = productid;
                return View(review);
            }
            bool DeleteReview = _product.DeleteReview(productid);
            if (!DeleteReview)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowProduct));
            }
            Review AddReview = new Review()
            {
                ArticleTitle = review.ArticleTitle,
                ArticleDescription = review.ArticleDescription,
                ReviewDescription = review.ReviewDescription,
                ReviewNegative = string.Join("^", negative),
                ReviewPositive = string.Join("^", positive)
            };
            if (AddReview.ReviewDescription != null ||
                AddReview.ArticleDescription != null ||
                AddReview.ArticleTitle != null ||
                (!String.IsNullOrEmpty(AddReview.ReviewPositive) || !String.IsNullOrEmpty(AddReview.ReviewNegative)))
            {

                AddReview.ProductId = productid;
                bool addreview = _product.AddOrupdatereview(AddReview);
                TempData["Result"] = addreview ? "true" : "false";
                return RedirectToAction(nameof(ShowProduct));
            }
            TempData["Result"] = DeleteReview ? "true" : "false";
            return RedirectToAction(nameof(ShowProduct));

        }
        #endregion

        #region ProductPrice
        public IActionResult ShowPriceForProduct(int id)
        {
            ViewBag.id = id;
            return View(_product.ShowPriceForProduct(id));
        }

        public IActionResult AddPrice(int id)
        {
            ViewBag.color = _product.ShowAllProductColor();
            ViewBag.gurantee = _gurantee.showAllGurantee();
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddPrice(ProductPrice price)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.color = _product.ShowAllProductColor();
                ViewBag.gurantee = _gurantee.showAllGurantee();
                ViewBag.id = price.ProductId;
                return View(price);
            }
            price.CteateDate = DateTime.Now;
            int addprice = _product.AddProductPrice(price);
            TempData["Result"] = addprice > 0 ? "true" : "false";
            return RedirectToAction(nameof(ShowProduct));
           
        }

        [HttpGet]
        public IActionResult UpdatePrice(int id)
        {
            ViewBag.color = _product.ShowAllProductColor();
            ViewBag.gurantee = _gurantee.showAllGurantee();
            ProductPrice price = _product.GetPriceById(id);
            return View(price);
        }
        [HttpPost]
        public IActionResult UpdatePrice(ProductPrice price)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.color = _product.ShowAllProductColor();
                ViewBag.gurantee = _gurantee.showAllGurantee();
                return View(price);
            }

            bool updateprice = _product.UpdateProductPrice(price);
            TempData["Result"] = updateprice ? "true" : "false";
            return RedirectToAction(nameof(ShowProduct));
        }

        [HttpGet]
        public IActionResult DeletePrice(int id)
        {
            ProductPrice price = _product.GetPriceById(id);
            return PartialView("_deletePrice", price);
        }
        [HttpPost]
        public IActionResult DeletePrice(ProductPrice price)
        {
            bool delete = _product.DeleteProductPrice(price);
            int sendJson = delete ? 3 : 4;
            return Json(sendJson);
        }
        #endregion
    }
}
