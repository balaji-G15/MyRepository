using _2_MvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_MvcPractice.Controllers
{
    public class HomeController : Controller
    {
     public ActionResult Index()
        {

            employeedbhelper db = new employeedbhelper();
           ViewBag.employee= db.getemployee();
            return View();
             
        }
    }
}