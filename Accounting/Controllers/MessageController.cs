using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class MessageController : Controller
    {
        MessageDBL omessageDBL;
        MessageUsersDBL omessageUsersDBL;
        POCO.MessageUsers omessageUsers;
        POCO.Messages omessage;
        UserDBL ouserDBL;
        POCO.vmDashboard ovmDashboard;
        public MessageController()
        {
            omessage = new POCO.Messages();
            ovmDashboard = new POCO.vmDashboard();
            omessageDBL = new MessageDBL();
            omessageUsersDBL = new MessageUsersDBL();
            omessageUsers = new POCO.MessageUsers();
            ouserDBL = new UserDBL();

        }
        // GET: All Messages for Logged User
        public ActionResult Index()
        {
           var userId = (int)Session["UserId"];
           List<POCO.vmDashboard> messagesList = omessageDBL.D_MessageUsers_Get(userId).ToList();
     
            return View(messagesList);
        }

        public ActionResult Create()
        {   //Created ViewBag for transferring Users list.
            UserDBL ouserDBL = new UserDBL();
            var userId = (int)Session["UserId"];

            List<POCO.User> userList = omessageDBL.D_UsersExceptLogged_Get(userId);
            ViewBag.usersData = (from a in userList select a).ToList();

          
            omessage.FromUser = Session["Login_User_Name"].ToString();
            return View(omessage);
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult Create(POCO.Messages oMessage, POCO.MessageUsers oMessageUsers, FormCollection form)
        {
            try
            {
              var userId= Convert.ToInt32(Session["UserId"]);

               var users = form["users"] != null
               ? form["users"].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList() : new List<int>();

                var message = omessageDBL.D_Message_Insert(oMessage);
                for (int i = 0; i < users.Count; i++)
                {
                    oMessageUsers = new POCO.MessageUsers();
                    oMessageUsers.MessageId = message.MessageId;
                    oMessageUsers.FromUserId = userId;
                    oMessageUsers.ToUserId = (int)users[i];
                    omessageUsersDBL.D_MessageUsers_Insert(oMessageUsers);
                }

                UserDBL ouserDBL = new UserDBL();
              
                //Get Users List except Logged User
                List<POCO.User> userList = omessageDBL.D_UsersExceptLogged_Get(userId);
                ViewBag.usersData = (from a in userList select a).ToList();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ex.ToString();
                return View();
            }

        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id,int Uid)
        {
            List<POCO.vmDashboard> ovm_Dashboard;
            ovm_Dashboard = omessageDBL.D_MessageUsers_GetToUpdate(id,Uid);
            var userId = (int)Session["UserId"];
            List<POCO.User> userList = omessageDBL.D_UsersExceptLogged_Get(userId).ToList();

            ViewBag.usersData = (from a in userList select a).ToList();
            TempData["MessageId"] = omessage.MessageId;

            return View(omessage);

        }

        // POST: Message/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                UserDBL ouserDBL = new UserDBL();
                IEnumerable<POCO.User> userList = ouserDBL.D_Users_Get().ToList();
                ViewBag.usersData = (from a in userList select a).ToList();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Message/Delete/5
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
