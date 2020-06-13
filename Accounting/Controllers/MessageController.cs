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

        // GET: Messages for Logged User
        public ActionResult Index()
        {
            omessageUsersDBL = new MessageUsersDBL();
            var userId = (int)Session["UserId"];
            List<POCO.MessageUsers> messagesList = omessageUsersDBL.D_MessageUsers_Get(userId).ToList();

            return View(messagesList);
        }

        // GET: Message/Create
        public ActionResult Create()
        {   //Created ViewBag for transferring Users list.
            UserDBL ouserDBL = new UserDBL();
            var userId = (int)Session["UserId"];

            //  //Get Users List except Logged User
            IEnumerable<POCO.User> userList = ouserDBL.D_UsersList_Get(userId).ToList();
            ViewBag.usersData = (from a in userList select a).ToList();

            POCO.Message omessage = new POCO.Message();
            omessage.FromUser = Session["Login_User_Name"].ToString();
            return View(omessage);
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult Create(POCO.Message oMessage, POCO.MessageUsers oMessageUsers, FormCollection form)
        {
            try
            {
              var userId= Convert.ToInt32(Session["UserId"]);
                var users = form["users"] != null
               ? form["users"].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList() : new List<int>();

                 omessageDBL = new MessageDBL();
                MessageUsersDBL omessageUsersDBL = new MessageUsersDBL();

                var message = omessageDBL.D_Message_Insert(oMessage);

                for (int i = 0; i < users.Count; i++)
                {
                    oMessageUsers = new POCO.MessageUsers();
                    omessageUsers.FromUserId = userId;
                    oMessageUsers.MessageId = message.MessageId;
                    oMessageUsers.ToUserId = (int)users[i];
                    omessageUsersDBL.D_MessageUsers_Insert(oMessageUsers);
                }

                UserDBL ouserDBL = new UserDBL();
              
                 //Get Users List except Logged User
                IEnumerable<POCO.User> userList = ouserDBL.D_UsersList_Get(userId).ToList();
                ViewBag.usersData = (from a in userList select a).ToList();

                ViewBag.Messag = "Message has been sent successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ex.ToString();
                ViewBag.message = "Error!, Try Again.";
                return View();
            }

        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id)
        {
            omessageUsersDBL = new MessageUsersDBL();
            omessageUsers = omessageUsersDBL.D_MessageUsers_GetToUpdate(id);
            UserDBL ouserDBL = new UserDBL();
            var userId = (int)Session["UserId"];
            List<POCO.User> userList = ouserDBL.D_UsersList_Get(userId).ToList();
            ViewBag.usersData = (from a in userList select a).ToList();


            return View(omessageUsers);

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
