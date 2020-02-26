using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TPMDocs.Models;

namespace TPMDocs.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Login(LogViewModel model, string returnUrl)
        {
            {
                if (ValidateUser(model.Login, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Login, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    //return RedirectToAction("Index", "Home");
                    ModelState.AddModelError("", "Неправильный пароль или логин");
                }
            }
            return View(model);
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }

        private bool ValidateUser(string Login, string password)
        {
            bool isValid = false;

            using (TPMDocContext _db = new TPMDocContext())
            {
                try
                {
                    Работники user = (from u in _db.Работники
                                      where u.Login == Login && u.Password == password
                                 select u).FirstOrDefault();

                    if (user != null && user.Password != null)
                    {
                        isValid = true;
                    }
                }
                catch
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}