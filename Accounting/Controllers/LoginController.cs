using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class LoginController : Controller
    {

        private UserDBL ouserDBL;
        private POCO.User oUser;

        public LoginController()
        {
            ouserDBL = new UserDBL();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginUser(POCO.User PoUser)
        {

            var checkUser = ouserDBL.D_User_Login(PoUser);
            if (checkUser.FirstName == null && checkUser.LastName == null )
            {
                ViewBag.errorMsg = "Wrong user name or password";
                return View("index");
            }
            else
            {
                Session["Login_User_Name"] = checkUser.FirstName.ToString() + " " + checkUser.LastName.ToString();
                Session["UserPermission"] = checkUser.UserPermission;
                Session["UserId"] = checkUser.UserID;

                return RedirectToAction("Index", "User");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Login");
        }
    }
}