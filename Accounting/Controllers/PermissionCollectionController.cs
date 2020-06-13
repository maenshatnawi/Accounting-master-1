using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class PermissionCollectionController : Controller
    {
        private PermissionCollectionDBL oCollectionDBL;
        private POCO.PermissionCollection oCollection;

        public PermissionCollectionController()
        {
            oCollectionDBL = new PermissionCollectionDBL();
        }
        // GET: PermissionCollection
        public ActionResult Index()
        {
            List<POCO.PermissionCollection> oLCollection = oCollectionDBL.D_Collection_Get().ToList();

            return View(oLCollection);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(POCO.PermissionCollection PoCollection)
        {
            try
            {
                oCollectionDBL.D_Collection_Insert(PoCollection);

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
            oCollection = new POCO.PermissionCollection();
            oCollection = oCollectionDBL.D_Collection_Edit(id);
            return View("Update", oCollection);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Update(POCO.PermissionCollection PoCollection)
        {
            oCollectionDBL.D_Collection_Update(PoCollection);

            return RedirectToAction("Index");
        }

        // POST: User/Delete/5
        public ActionResult Delete(int id)
        {
            oCollectionDBL.D_Collection_Delete(id);
            return RedirectToAction("Index");
        }

        
    }
}