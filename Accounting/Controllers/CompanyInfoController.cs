using DBL;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class CompanyInfoController : Controller
    {
        CompanyInfoDBL ocompanyInfoDBL=new CompanyInfoDBL();
        private POCO.CompanyInfo ocompany;
        // GET: CompanyInfo
        public ActionResult Index()
        {
            List<POCO.CompanyInfo> companiesList = ocompanyInfoDBL.D_CompanyInfo_Get();
            return View(companiesList);
        }

        // GET: CompanyInfo/Details
        public ActionResult Details(decimal id)
        {
            ocompany = new POCO.CompanyInfo();
            ocompany = ocompanyInfoDBL.D_CompanyInfoGetToUpdate(id);
            return View(ocompany);
        }

        // GET: CompanyInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompanyInfo/Create
        [HttpPost]
        public ActionResult Create(POCO.CompanyInfo ocompany)
        {

            try
            {
                HttpPostedFileBase file = Request.Files["UploadImage"];

                var bs = new byte[file.ContentLength];
                using (var fs = file.InputStream)
                {
                    var offset = 0;
                    do
                    {
                     offset += fs.Read(bs, offset, bs.Length - offset);
                    } while (offset < bs.Length);
                }
                ocompany.Img = bs;
                ///
                ocompanyInfoDBL.D_CompanyInfo_Insert(ocompany);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ex.ToString();
                return View();
            }
        }

        // GET: CompanyInfo/Edit/5
        public ActionResult Edit(decimal id)
        {
            ocompany = new POCO.CompanyInfo();
            ocompany = ocompanyInfoDBL.D_CompanyInfoGetToUpdate(id);
            return View(ocompany);
        }

        // POST: CompanyInfo/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(POCO.CompanyInfo ocompany)
        {
            try
            {
                HttpPostedFileBase file = Request.Files["UploadImage"];
                var bs = new byte[file.ContentLength];
                using (var fs = file.InputStream)
                {
                    var offset = 0;
                    do
                    {
                        offset += fs.Read(bs, offset, bs.Length - offset);
                    } while (offset < bs.Length);
                }
                ocompany.Img = bs;
                ocompanyInfoDBL.D_CompanyInfo_Update(ocompany);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CompanyInfo/Delete/5
        public ActionResult Delete(decimal id)
        {
            ocompanyInfoDBL.D_CompanyInfo_Delete(id);
            return RedirectToAction("Index");
        }

        // POST: CompanyInfo/Delete/5
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
    }
}
