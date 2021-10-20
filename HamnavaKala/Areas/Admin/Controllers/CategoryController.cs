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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _category;
        public CategoryController(ICategoryService category)
        {
            _category = category;
        }
        public IActionResult ShowAllCategory()
        {
            return View(_category.ShowAllCategory());
        }

        [HttpGet]
        public IActionResult AddCategory(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View(cat);
            }
            if (_category.ExistCategory(cat.CategoryFaName, cat.CategoryEnName,0))
            {
                ModelState.AddModelError("CategoryEnName", "دسته بندی تکراری میباشد.");
                return View(cat);
            }
            int res = _category.AddCategory(cat);
            TempData["Result"] = res > 0 ? "true" : "false";
            return RedirectToAction(nameof(ShowAllCategory));
        }

        [HttpGet]
        public IActionResult ShowAllSubCategory(int id)
        {
            ViewBag.id = id;
            return View(_category.ShowAllsubcategory(id));
        }

        [HttpGet]
        public IActionResult ShowAllSubsubCategory(int id)
        {
            ViewBag.id = id;
            return View(_category.ShowAllsubcategory(id));
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            Category cat = _category.GetCategoryById(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View(cat);
            }
            if (_category.ExistCategory(cat.CategoryFaName, cat.CategoryEnName, cat.CategoryId))
            {
                ModelState.AddModelError("CategoryEnName", "دسته بندی تکراری میباشد.");
                return View(cat);
            }
            bool res = _category.UpdateCategory(cat);
            TempData["Result"] = res ? "true" : "false";
            return RedirectToAction(nameof(ShowAllCategory));
        }

        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            Category cat = _category.GetCategoryById(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category cat)
        {
            cat.IsDelete = true;
            bool res = _category.UpdateCategory(cat);
            TempData["Result"] = res ? "true" : "false";
            return RedirectToAction(nameof(ShowAllCategory));
        }
    }
}
