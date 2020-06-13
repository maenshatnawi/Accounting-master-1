using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class AccountsWithCentersCostsTableController : Controller
    {
        // GET: AccountsWithCentersCostsTable
        public ActionResult Index()
        {
            DBL.AccountsWithCentersCostsTableDBL oAccountsWithCentersCostsTableDBL = new DBL.AccountsWithCentersCostsTableDBL();
            List<POCO.AccountsWithCentersCostsTable> oLAccountsWithCentersCostsTable = oAccountsWithCentersCostsTableDBL.M_AccountsWithCentersCostsTable_Get().ToList();


            DBL.AccountTableDBL oAccountTableDBL = new DBL.AccountTableDBL();
            List<POCO.AccountTable> oLAccountTable = oAccountTableDBL.M_AccountTable_Get().ToList();
         

            return View(oLAccountsWithCentersCostsTable);
         
        }

        // GET: AccountsWithCentersCostsTable/Details/5
        public ActionResult Details(Int64 ParAccountNo, Int64 ParCentersCostsNo)
        {

            AccountsWithCentersCostsTableDBL oAccountsWithCentersCostsTableDBL = new AccountsWithCentersCostsTableDBL();

            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = oAccountsWithCentersCostsTableDBL.M_AccountsWithCentersCostsTable_Find(ParAccountNo, ParCentersCostsNo);
            if (oAccountsWithCentersCostsTable == null)
            {
                return HttpNotFound();
            }


            return View(oAccountsWithCentersCostsTable);
        }

        // GET: AccountsWithCentersCostsTable/Create
        public ActionResult Create()
        {
            DBL.AccountTableDBL oAccountTableDBL = new DBL.AccountTableDBL();
            List<POCO.AccountTable> oLAccountTable = oAccountTableDBL.M_AccountTable_Get().ToList();
            DBL.CentersCostsTableDBL oCentersCostsTableDBL = new DBL.CentersCostsTableDBL();
            List<POCO.CentersCostsTable> oLCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Get().ToList();
            ViewBag.AccountNo = new SelectList(oLAccountTable.Where(a=>a.AccountNo !=0), "AccountNo", "AccountName");
            ViewBag.CentersCostsNo = new SelectList(oLCentersCostsTable.Where(a => a.CentersCostsNo != 0), "CentersCostsNo", "CentersCostsName");

            return View();
        }

        // POST: AccountsWithCentersCostsTable/Create
        [HttpPost]
        public ActionResult Create(POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable)
        {
            if (ModelState.IsValid)
            {
                AccountsWithCentersCostsTableDBL oAccountsWithCentersCostsTableDBL = new AccountsWithCentersCostsTableDBL();
                oAccountsWithCentersCostsTableDBL.M_AccountsWithCentersCostsTable_Insert(oAccountsWithCentersCostsTable);

                return RedirectToAction("Index");
            }
            return View(oAccountsWithCentersCostsTable);
        }

        // GET: AccountsWithCentersCostsTable/Edit/5
        public ActionResult Edit(Int64 ParID, Int64 ParAccountNo, Int64 ParCentersCostsNo )
        {
            DBL.AccountTableDBL oAccountTableDBL = new DBL.AccountTableDBL();
            List<POCO.AccountTable> oLAccountTable = oAccountTableDBL.M_AccountTable_Get().ToList();
            DBL.CentersCostsTableDBL oCentersCostsTableDBL = new DBL.CentersCostsTableDBL();
            List<POCO.CentersCostsTable> oLCentersCostsTable = oCentersCostsTableDBL.M_CentersCostsTable_Get().ToList();
            ViewBag.AccountNo = new SelectList(oLAccountTable.Where(a => a.AccountNo != 0), "AccountNo", "AccountName", ParAccountNo);
            ViewBag.CentersCostsNo = new SelectList(oLCentersCostsTable.Where(a => a.CentersCostsNo != 0), "CentersCostsNo", "CentersCostsName", ParCentersCostsNo);
            return View();
        }

        // POST: AccountsWithCentersCostsTable/Edit/5
        [HttpPost]
        public ActionResult Edit(Int64 ParID,POCO.AccountsWithCentersCostsTable PoAccountsWithCentersCostsTable)
        {
      
                AccountsWithCentersCostsTableDBL oAccountsWithCentersCostsTableDBL = new AccountsWithCentersCostsTableDBL();
            PoAccountsWithCentersCostsTable.ID = ParID;
                oAccountsWithCentersCostsTableDBL.M_AccountsWithCentersCostsTable_Update(ParID,PoAccountsWithCentersCostsTable.AccountNo,PoAccountsWithCentersCostsTable.CentersCostsNo);
                return RedirectToAction("Index");
            
        }

        // GET: AccountsWithCentersCostsTable/Delete/5
        public ActionResult Delete(Int64 ParAccountNo, Int64 ParCentersCostsNo)
        {
           AccountsWithCentersCostsTableDBL oAccountsWithCentersCostsTableDBL = new AccountsWithCentersCostsTableDBL();

            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = oAccountsWithCentersCostsTableDBL.M_AccountsWithCentersCostsTable_Find(ParAccountNo, ParCentersCostsNo);
            if (oAccountsWithCentersCostsTable == null)
            {
                return HttpNotFound();
            }


            return View(oAccountsWithCentersCostsTable);
        }

        // POST: AccountTable/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int64 ParAccountNo, Int64 ParCentersCostsNo)
        {
            AccountsWithCentersCostsTableDBL oAccountsWithCentersCostsTableDBL = new AccountsWithCentersCostsTableDBL();

            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = oAccountsWithCentersCostsTableDBL.M_AccountsWithCentersCostsTable_Delete(ParAccountNo, ParCentersCostsNo);

            return RedirectToAction("Index");
        }
    }
}
