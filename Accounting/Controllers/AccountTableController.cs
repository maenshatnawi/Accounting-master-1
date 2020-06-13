using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class AccountTableController : Controller
    {
        // GET: AccountTable
        public ActionResult Index()
        {

            DBL.AccountTableDBL oAccountTableDBL = new DBL.AccountTableDBL();
            List<POCO.AccountTable> oLAccountTable = oAccountTableDBL.M_AccountTable_Get().ToList();                   
            return View(oLAccountTable);
        }

        // GET: AccountTable/Details/5
        public ActionResult Details(Int64 parAccountNo)
        {
     
           
            AccountTableDBL oAccountTableDBL = new AccountTableDBL();
            POCO.AccountTable oAccountTable = oAccountTableDBL.M_AccountTable_Find(parAccountNo);
            if (oAccountTable == null)
            {
                return HttpNotFound();
            }


            return View(oAccountTable);
        }

        // GET: AccountTable/Create
       
        public ActionResult Create(Int64 parAccountNo)
        {
            POCO.AccountTable oAccountTable = new AccountTable();
            AccountTableDBL oAccountTableDBL = new AccountTableDBL();
            oAccountTable.ParentId = parAccountNo;
         
            return View(oAccountTable);
           
        }

        // POST: AccountTable/Create
        [HttpPost]
        public ActionResult Create(POCO.AccountTable oAccountTable)
        {

            if (ModelState.IsValid)
            {
                AccountTableDBL oAccountTableDBL = new AccountTableDBL();
                oAccountTableDBL.M_AccountTable_Insert(oAccountTable);

                return RedirectToAction("Index");
            }
            return View(oAccountTable);
        }



  
         public ActionResult Edit(Int64 parAccountNo)
        {
            DBL.AccountTableDBL oAccountTableDBL = new DBL.AccountTableDBL();
            POCO.AccountTable oAccountTable = oAccountTableDBL.M_AccountTable_Find(parAccountNo);
            return View(oAccountTable);
        }

       // POST: AccountingTree/Edit/5
         [HttpPost]
        public ActionResult Edit(Int64 parAccountNo,POCO.AccountTable oAccountTable)
        {
           
                if (ModelState.IsValid)
                {
                    //TODO: Add update logic here
                    oAccountTable.AccountNo = parAccountNo;
                    DBL.AccountTableDBL oAccountTableDBL = new DBL.AccountTableDBL();
                    oAccountTable = oAccountTableDBL.M_AccountTable_Update(oAccountTable);
                    return RedirectToAction("Index");
                }
            return View();
        }


        // GET: AccountTable/Delete/5
        public ActionResult Delete(Int64 parAccountNo)
        {
            AccountTableDBL oAccountTableDBL = new AccountTableDBL();
            POCO.AccountTable oAccountTable = oAccountTableDBL.M_AccountTable_Find(parAccountNo);
            if (oAccountTable == null)
            {
                return HttpNotFound();
            }


            return View(oAccountTable);
        }

        // POST: AccountTable/Delete/5
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int64 parAccountNo)
        {
            AccountTableDBL oAccountTableDBL = new AccountTableDBL();
            POCO.AccountTable oAccountTable = oAccountTableDBL.M_AccountTable_Delete(parAccountNo);

            return RedirectToAction("Index");
        }
    }
}
