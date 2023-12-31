﻿using AUG2023_IBM_Day4AfternoonNG.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUG2023_IBM_Day4AfternoonNG.Controllers
{
    public class StateMgmtController : Controller
    {
        public IActionResult URLTechnique()
        {
            return View();
        }

        [HttpPost]
        public IActionResult URLTechnique(string demo)
        {
            return View();
        }


        public IActionResult HiddenVariablesTechnique()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HiddenVariablesTechnique(string hiddenValue)
        {
            return View();
        }


        public string SetCookies()
        {
            Response.Cookies.Append("DemoKey", "DemoValue", new CookieOptions { Expires = DateTime.Now.AddDays(10) });
            return "Cookie Set";
        }

        public string GetCookies()
        {
            return Request.Cookies["DemoKey"].ToString();
        }

        public IActionResult ControllerToView()
        {
            ViewData["VD"] = "View Data Value....";

            ViewBag.VB = "View Bag Value....";


            return View();
        }

public IActionResult ControllerToControllerUsingTempData()
        { 
            
            ViewData["VD"] = "View Data Value....";

            ViewBag.VB = "View Bag Value....";

            TempData["TD"] = "Temp Data Value.....";

            return RedirectToAction("DisplayAllStates");
        }


public IActionResult DisplayAllStates()
        {
 
            return View();
        }



        public IActionResult StoreSessionState()
        {

            Models.Product prd = new Models.Product { ProductID = 1234, Category = "CAR", ProductName = "BMW 10X" };


            HttpContext.Session.SetObjectAsJson("prd", prd);

            return Content("Session Data Set");
        }

        public IActionResult GetSessionData()
        {

            var data = HttpContext.Session.GetObjectFromJson<Product>("prd");
            return Content(data?.ToString() ?? " Session Data Dead");
        }




    }
}
