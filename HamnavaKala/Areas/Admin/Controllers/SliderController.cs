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
    public class SliderController : Controller
    {
        private readonly ISlider _context;
        public SliderController(ISlider context)
        {
            _context = context;
        }
        public IActionResult Index(int page =1)
        {
            ViewBag.page = page;
            ViewBag.SliderCount = _context.SliderCount();
            return View(_context.ShowSlider(page));
        }

        [HttpGet]
        public IActionResult AddSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSlider(Slider slider, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            if (file == null)
            {
                ModelState.AddModelError("ImgSlider", "لطفا یک عکس برای سلایدر انتخاب نمایید");
                return View(slider);
            }
            string imgname = uploadImg.CreateImg(file, "slider-main");
            if (imgname == "flase")
            {
                TempData["Result"] = "failed";
                return RedirectToAction(nameof(Index));
            }

            slider.ImgSlider = imgname;
            int res = _context.AddSlider(slider);
            TempData["Result"] = res > 0 ? "success" : "failed";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            Slider slider = _context.GetSliderById(id);
            if (slider == null)
            {
                TempData["NotFound"] = "NotFound";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(slider);
            }
        }

        [HttpPost]
        public IActionResult UpdateSlider(Slider slider,IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            if (file != null)
            {
                string imgname = uploadImg.CreateImg(file, "slider-main");
                if (imgname == "false")
                {
                    TempData["Result"] = "failed";
                    return RedirectToAction(nameof(Index));
                }
                bool DeleteImage = uploadImg.DeleteImg("slider-main", slider.ImgSlider);
                if (!DeleteImage)
                {
                    TempData["Result"] = "failed";
                    return RedirectToAction(nameof(Index));
                }
                slider.ImgSlider = imgname;
            }


                bool res = _context.UpdateSlider(slider);
                TempData["Result"] = res  ? "success" : "failed";
                return RedirectToAction(nameof(Index));
            
        }

        [HttpGet]
        public IActionResult DeleteSlider(int id)
        {
            Slider slider = _context.GetSliderById(id);
            if (slider == null)
            {
                TempData["NotFound"] = "NotFound";
                return RedirectToAction(nameof(Index));
            }
            return PartialView("_deleteSlider",slider);
        }

        [HttpPost]
        public IActionResult DeleteSlider(Slider slider, IFormFile file)
        {

            bool DeleteImage = uploadImg.DeleteImg("slider-main", slider.ImgSlider);
            if (!DeleteImage)
            {
                TempData["Result"] = "failed";
                return RedirectToAction(nameof(Index));
            }
            bool res = _context.DeleteSlider(slider);
            int sendJson = res ? 3 : 4;
            return Json(sendJson);
        }
    }
}
