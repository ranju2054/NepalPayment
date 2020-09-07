using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NepalPayment.Controllers
{
    public class AccountController : Controller
    {
        
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register model)
        {
            using (var context = new Model1())
            {
                context.Registers.Add(model);
                context.SaveChanges();
            }
                return RedirectToAction("Login");
            
        }
        public ActionResult Login()
        {
           
                return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            using (var context = new Model1())
            {
                bool isValid = context.Registers.Any(x => x.UserName == model.SameUserName && x.Password == model.SamePassword);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.SameUserName, false);
                    return RedirectToAction("Create", "Tables");
                }
                ModelState.AddModelError("", "Invalid username and password.");
                return View();
            }
            
        }
    }
}