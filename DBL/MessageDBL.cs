using DAL;
using POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
    public class MessageDBL
    {
        private MessageDAL oMessageDAL;
        private DataSet ds;
        private POCO.Messages omessages;
        private POCO.MessageUsers oMessageUsers;
        private POCO.vmDashboard ovmDashboard;
        POCO.User oUser;
        public MessageDBL()
        {
            oMessageDAL = new MessageDAL();
            ds = new DataSet();
            omessages = new POCO.Messages();
            oMessageUsers = new POCO.MessageUsers();
            ovmDashboard = new POCO.vmDashboard();
            
        }
        public POCO.Messages D_Message_Insert(POCO.Messages PoMessage)
        {
            
            POCO.Messages oMessage = new POCO.Messages();
            ds = oMessageDAL.D_Messages_Insert(PoMessage.MessageSubject,PoMessage.MessageBody, PoMessage.FromUser, PoMessage.MessageIcon,PoMessage.FromDate,PoMessage.ToDate);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oMessage.MessageId = (int)ds.Tables[0].Rows[0]["MessageId"];
                    oMessage.MessageBody = ds.Tables[0].Rows[0]["MessageBody"].ToString();
                    oMessage.MessageSubject = ds.Tables[0].Rows[0]["MessageSubject"].ToString();
                    oMessage.FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                    oMessage.MessageIcon = ds.Tables[0].Rows[0]["MessageIcon"].ToString();
                    oMessage.FromDate = (DateTime) ds.Tables[0].Rows[0]["FromDate"];
                    oMessage.ToDate =(DateTime) ds.Tables[0].Rows[0]["ToDate"];
                }

            }
            return oMessage;

        }

        public List<POCO.vmDashboard> D_MessageUsers_Get(int id)
        {

            List<POCO.vmDashboard> ol = new List<POCO.vmDashboard>();      
            ds = oMessageDAL.D_MessageUsers_Get(id);

            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ovmDashboard = new POCO.vmDashboard();

                    ovmDashboard.vmMessageUsers[i].MessageId = Convert.ToInt32(ds.Tables[0].Rows[i]["MessageId"]);
                    ovmDashboard.vmMessageUsers[i].ToUserId = Convert.ToInt32(ds.Tables[0].Rows[i]["ToUserId"]);
                    ovmDashboard.vmMessageUsers[i].FromUserId = Convert.ToInt32(ds.Tables[0].Rows[i]["FromUserId"]);
                    ovmDashboard.vmMessages[i].MessageSubject = ds.Tables[0].Rows[i]["MessageSubject"].ToString();
                    ovmDashboard.vmMessages[i].MessageBody = ds.Tables[0].Rows[i]["MessageBody"].ToString();
                    ovmDashboard.vmMessages[i].FromUser = ds.Tables[0].Rows[i]["FromUser"].ToString();
                    ovmDashboard.vmMessages[i].MessageIcon = ds.Tables[0].Rows[i]["MessageIcon"].ToString();
                    ovmDashboard.vmMessages[i].FromDate = (DateTime)ds.Tables[0].Rows[i]["FromDate"];
                    ovmDashboard.vmMessages[i].ToDate = (DateTime)ds.Tables[0].Rows[i]["ToDate"];

                        ol.Add(ovmDashboard);
                     
                    
                }

            }
            return ol;
        }
        //Get Users List except Logged User
        public List<POCO.User> D_UsersExceptLogged_Get(int id)
        {
            ds = new DataSet();
            List<POCO.User> oLUser = new List<POCO.User>();

            ds = oMessageDAL.D_UsersExceptLogged_Get(id);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oUser = new POCO.User();
                        oUser.UserID = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                        oUser.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                        oUser.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();

                        oLUser.Add(oUser);
                    }
                }
            }
            return oLUser;
        }
        public List<POCO.vmDashboard> D_MessageUsers_GetToUpdate(int id,int Uid)
        {
            List<POCO.vmDashboard> ol = new List<POCO.vmDashboard>();
            ds = oMessageDAL.D_MessageUsers_GetToUpdate(id,Uid);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ovmDashboard.vmMessageUsers[0].FromUserId = (int)ds.Tables[0].Rows[0]["FromUserId"];
                    ovmDashboard.vmMessageUsers[0].ToUserId = (int)ds.Tables[0].Rows[0]["ToUserId"];
                    ovmDashboard.vmMessages[0].MessageBody = ds.Tables[0].Rows[0]["MessageBody"].ToString();
                    ovmDashboard.vmMessages[0].FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                    ovmDashboard.vmMessages[0].MessageIcon = ds.Tables[0].Rows[0]["MessageIcon"].ToString();
                    ovmDashboard.vmMessages[0].FromDate = (DateTime)ds.Tables[0].Rows[0]["FromDate"];
                    ovmDashboard.vmMessages[0].ToDate = (DateTime)ds.Tables[0].Rows[0]["ToDate"];
                    ovmDashboard.vmMessages[0].FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    ovmDashboard.vmMessages[0].LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                    ol.Add(ovmDashboard);
                }
                
            }
            return ol;
        }
        // Edit(Post)
        public void D_MessagesUsers_Update(POCO.Messages Pomessage)
        {
            oMessageDAL.D_MessagesUsers_Update(Pomessage.MessageId, Pomessage.MessageBody, Pomessage.MessageIcon, Pomessage.FromDate, Pomessage.ToDate);
        }

      
    }
}
