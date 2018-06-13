using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO09.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _userSigIn;

        public HomeController()
        {
            _userSigIn = "UserSigIn";
        }

        // GET: Home
        public ActionResult Index()
        {
            if (Session[_userSigIn] == null)
            {
                return RedirectToAction("SignIn", "Users");
            }
            return View();
        }

        public ActionResult About()
        {
            if (Session[_userSigIn] == null)
            {
                return RedirectToAction("SignIn", "Users");
            }
            ViewBag.Message = "Quienes somos...";
            return View();
        }

        public ActionResult Contact()
        {
            if (Session[_userSigIn] == null)
            {
                return RedirectToAction("SignIn", "Users");
            }
            ViewBag.Message = "Contactanos";
            return View();
        }
    }
}
