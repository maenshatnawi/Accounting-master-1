using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class PermissionDetailsController : Controller
    {
        private PermissionDBL oPermissionDBL;
        private POCO.Permission oPermission;

        public PermissionDetailsController()
        {
            oPermissionDBL = new PermissionDBL();
        }
        // GET: PermissionCollection
        public ActionResult Index()
        {
            List<POCO.Permission> oLPermission = oPermissionDBL.D_Permission_Get().ToList();

            return View(oLPermission);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(POCO.Permission PoPermission)
        {
            try
            {
                oPermissionDBL.D_Permission_Insert(PoPermission);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            oPermission = new POCO.Permission();
            oPermission = oPermissionDBL.D_Permission_Edit(id);
            return View("Update", oPermission);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Update(POCO.Permission PoPermission)
        {
            oPermissionDBL.D_Permission_Update(PoPermission);

            return RedirectToAction("Index");
        }

        // POST: User/Delete/5
        public ActionResult Delete(int id)
        {
            oPermissionDBL.D_Permission_Delete(id);
            return RedirectToAction("Index");
        }
    }
}