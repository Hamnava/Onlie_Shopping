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
    public class GuranteeController : Controller
    {
        private readonly IGurantee _gurantee;
        public GuranteeController(IGurantee gurantee)
        {
            _gurantee = gurantee;
        }
        public IActionResult ShowGurantee()
        {
            return View(_gurantee.showAllGurantee());
        }

        [HttpGet]
        public IActionResult AddGurantee()
        {
            return PartialView("_AddGurantee");
        }

        [HttpPost]
        public IActionResult AddGurantee(ProductGurantee gurantee)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ShowGurantee));
            }
            if (_gurantee.ExistGurantee(gurantee.GuranteeName, 0))
            {
                return Json(5);
            }
            int grid = _gurantee.AddGurantee(gurantee);
            int sendJson = grid > 0 ? 1 : 4;
            return Json(sendJson);
        }

        [HttpGet]
        public IActionResult UpdateGurantee(int id)
        {
            ProductGurantee gurantee = _gurantee.GetGuranteebyId(id);
            return PartialView("_UpdateGurantee", gurantee);
        }

        [HttpPost]
        public IActionResult UpdateGurantee(ProductGurantee gurantee)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ShowGurantee));
            }
            if (_gurantee.ExistGurantee(gurantee.GuranteeName, 0))
            {
                return Json(5);
            }
            bool grid = _gurantee.UpdateGurantee(gurantee);
            int sendJson = grid ? 2 : 4;
            return Json(sendJson);
        }

        [HttpGet]
        public IActionResult DeleteGurantee(int id)
        {
            ProductGurantee gurantee = _gurantee.GetGuranteebyId(id);
             return PartialView("_DeleteGurantee", gurantee);
        }

        [HttpPost]
        public IActionResult DeleteGurantee(ProductGurantee gurantee)
        {
           
            bool grid = _gurantee.DeleteGurantee(gurantee);
            int sendJson = grid ? 3 : 4;
            return Json(sendJson);
        }
    }
}
