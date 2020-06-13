using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBL;
namespace Accounting.Controllers
{
    public class CentersCostsTableController : Controller
    {
        // GET: CentersCostsTable
        public ActionResult Index()
        {
            DBL.CentersCostsTableDBL oCentersCostsTableDBL = new DBL.CentersCostsTableDBL();
            List<POCO.CentersCostsTable> oLCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Get().ToList();



            return View(oLCentersCostsTable);
        
        }

        // GET: CentersCostsTable/Details/5
       

        // GET: CentersCostsTable/Create
        public ActionResult Details(Int64 ParCentersCostsNo)
        {


            CentersCostsTableDBL oCentersCostsTableDBL = new CentersCostsTableDBL();
            POCO.CentersCostsTable oCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Find(ParCentersCostsNo);
            if (oCentersCostsTable == null)
            {
                return HttpNotFound();
            }


            return View(oCentersCostsTable);
          
        }

        // GET: AccountTable/Create

        public ActionResult Create(Int64 ParCentersCostsNo)
        {
            POCO.CentersCostsTable oCentersCostsTable = new POCO.CentersCostsTable();
            CentersCostsTableDBL oCentersCostsTableDBL = new CentersCostsTableDBL();
            oCentersCostsTable.ParentId = ParCentersCostsNo;

          
            return View(oCentersCostsTable);
            //return View();
        }

        // POST: AccountTable/Create
        [HttpPost]
        public ActionResult Create(POCO.CentersCostsTable oCentersCostsTable)
        {

            if (ModelState.IsValid)
            {
                CentersCostsTableDBL oCentersCostsTableDBL = new CentersCostsTableDBL();
                oCentersCostsTableDBL.M_CentersCostsTable_Insert(oCentersCostsTable);

                return RedirectToAction("Index");
            }
            return View(oCentersCostsTable);
        }


        // GET: CentersCostsTable/Edit/5
        public ActionResult Edit(Int64 ParCentersCostsNo)
        {
            DBL.CentersCostsTableDBL oCentersCostsTableDBL = new DBL.CentersCostsTableDBL();
            POCO.CentersCostsTable oCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Find(ParCentersCostsNo);
            return View(oCentersCostsTable);
        }

        // POST: AccountingTree/Edit/5
        [HttpPost]
        public ActionResult Edit(Int64 ParCentersCostsNo, POCO.CentersCostsTable oCentersCostsTable)
        {

            if (ModelState.IsValid)
            {
                //TODO: Add update logic here
                oCentersCostsTable.CentersCostsNo = ParCentersCostsNo;
                DBL.CentersCostsTableDBL oCentersCostsTableDBL = new DBL.CentersCostsTableDBL();
                oCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Update(oCentersCostsTable);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: CentersCostsTable/Delete/5
        public ActionResult Delete(Int64 ParCentersCostsNo)
        {
            CentersCostsTableDBL oCentersCostsTableDBL = new CentersCostsTableDBL();
            POCO.CentersCostsTable oCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Find(ParCentersCostsNo);
            if (oCentersCostsTable == null)
            {
                return HttpNotFound();
            }


            return View(oCentersCostsTable);
        }

        // POST: AccountTable/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int64 ParCentersCostsNo)
        {
            CentersCostsTableDBL oCentersCostsTableDBL = new CentersCostsTableDBL();
            POCO.CentersCostsTable oAccountTable = oCentersCostsTableDBL.M_CentersCostsTable_Delete(ParCentersCostsNo);

            return RedirectToAction("Index");
        }
    }
}
