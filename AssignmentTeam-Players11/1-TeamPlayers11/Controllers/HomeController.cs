using _1_TeamPlayers11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_TeamPlayers11.Controllers
{
    public class HomeController : Controller
    {
        DbPlayersEntities Db = new DbPlayersEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(Db.Players.ToList());
        }

        public ActionResult SignUp()
        {
            return View();

        }
        [HttpPost]
        public ActionResult SignUp(Player player)
        {
            if(ModelState.IsValid)
            {
                Db.Players.Add(player);
                int a = Db.SaveChanges();
                if(a>0)
                {
                    ViewBag.Message = "<script>alert('successfully registerd')<script>";
                    ModelState.Clear();
                }
                else
                {
                    RedirectToAction("SigUp");
                }
            }
            return View();

        }
    }
}