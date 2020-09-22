using PlayersSelection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayersSelection.Controllers
{
    public class HomeController : Controller
    {
        DbTeamPlayers Db = new DbTeamPlayers(); 
        public ActionResult Index()
        {
            
            return View(Db.Players.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}