using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class UserController : Controller
    {
        private UserDBL ouserDBL;
        private POCO.User oUser;

        public UserController()
        {
            ouserDBL = new UserDBL();
        }
        // GET: User
        public ActionResult Index()
        {
            List<POCO.User> oLuser = ouserDBL.D_Users_Get().ToList();

            return View(oLuser);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(POCO.User PoUser)
        {
            try
            {
                // TODO: Add insert logic here
                ouserDBL.D_Users_Insert(PoUser);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            oUser = new POCO.User();
            oUser = ouserDBL.D_User_Edit(id);
            return View("Update",oUser);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Update(POCO.User PoUser)
        {
            ouserDBL.D_Users_Update(PoUser);

            return RedirectToAction("Index");
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            ouserDBL.D_Users_Delete(id);
            return RedirectToAction("Index");
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CheckUser(int id)
        {
            oUser = new POCO.User();
            oUser = ouserDBL.D_User_Check(id);
            return View("ChangePassword", oUser);
        }

        public ActionResult ChangePassword(POCO.User PoUser)
        {
            ouserDBL.D_Users_Change_Password(PoUser);
            return RedirectToAction("Index");
        }
    }
}
