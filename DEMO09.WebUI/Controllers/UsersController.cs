using DEMO09.BusinessInterfaces;
using DEMO09.Types;
using System;
using System.Web.Mvc;

namespace DEMO09.WebUI.Controllers
{
    public class UsersController : Controller
    {
        private readonly string _userSigIn;
        private readonly IUserProcessor _userProcessor;

        public UsersController(IUserProcessor userProcessor)
        {
            _userProcessor = userProcessor;
            _userSigIn = "UserSigIn";
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(UserSignIn userSignIn)
        {
            try
            {
                _userProcessor.SignIn(userSignIn);
                Session[_userSigIn] = userSignIn.Email;
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserSignUp entitie)
        {
            try
            {
                _userProcessor.SignUp(entitie);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
            return View("SignIn");
        }

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(UserForgotPassword entitie)
        {
            try
            {
                _userProcessor.ForgotPassword(entitie);
            }
            catch (Exception ex)
            {
                return View("Error",ex);
            }
            ViewData["suscess"] = "Se ha enviado una notificación a su correo";
            return View("Suscess");
        }

    }
}
