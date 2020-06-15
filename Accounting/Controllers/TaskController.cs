using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class TaskController : Controller
    {
        TasksDBL otasksDBL;
        private POCO.Task otask;

        public TaskController()
        {
            otasksDBL = new TasksDBL();
            otask = new POCO.Task();
        }
        // GET: Task 
        public ActionResult Index()
        {
            List<POCO.Task>  taskList = otasksDBL.D_AllTasks_Get();
            return View(taskList);
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create(POCO.Task Potask)
        {
            try
            {
                otasksDBL.D_Task_Insert(Potask);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ex.ToString();
                return View();
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            otask = otasksDBL.D_Task_Find(id);
            return View(otask);
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(POCO.Task PoTask)
        {
            try
            {
                otasksDBL.D_Task_Update(PoTask);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ex.ToString();
                return View();
            }
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            otasksDBL.D_Users_Delete(id);
            return RedirectToAction("Index");
        }     
    }
}
