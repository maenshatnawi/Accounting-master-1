using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
    public class MessageUsersDBL
    {
        MessageUsersDAL oMessageUsersDAL = new MessageUsersDAL();
        private POCO.MessageUsers oMessageUsers;
        DataSet ds;
        public List<POCO.MessageUsers> D_MessageUsers_Get(int id)
        {
            ds = new DataSet();
            oMessageUsers = new POCO.MessageUsers();
            List<POCO.MessageUsers> ol = new List<POCO.MessageUsers>();
            ds = oMessageUsersDAL.D_MessageUsers_Get(id);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oMessageUsers = new POCO.MessageUsers();
                        oMessageUsers.ToUserId = (int)ds.Tables[0].Rows[0]["ToUserId"];
                        oMessageUsers.FromUserId = (int)ds.Tables[0].Rows[0]["FromUserId"];
                        //oMessageUsers.MessageId = (int)ds.Tables[0].Rows[0]["MessageId"];
                        //oMessageUsers.MessageBody = ds.Tables[0].Rows[0]["MessageBody"].ToString();
                        //oMessageUsers.FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                        //oMessageUsers.MessageIcon = ds.Tables[0].Rows[0]["MessageIcon"].ToString();
                        //oMessageUsers.FromDate = (DateTime)ds.Tables[0].Rows[0]["FromDate"];
                        //oMessageUsers.ToDate = (DateTime)ds.Tables[0].Rows[0]["ToDate"];
                        //oMessageUsers.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                        //oMessageUsers.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();

                        ol.Add(oMessageUsers);
                    }
                }

            }
            return ol;
        }

        public POCO.MessageUsers D_MessageUsers_Insert(POCO.MessageUsers PoMessageUsers)
        {
            ds = new DataSet();
            oMessageUsers = new POCO.MessageUsers();
            ds = oMessageUsersDAL.D_MessageUsers_Insert(PoMessageUsers.MessageId, PoMessageUsers.FromUserId, PoMessageUsers.ToUserId);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oMessageUsers.ToUserId = (int)ds.Tables[0].Rows[0]["ToUserId"];
                    oMessageUsers.FromUserId = (int)ds.Tables[0].Rows[0]["FromUserId"];
                    oMessageUsers.MessageId = (int)ds.Tables[0].Rows[0]["MessageId"];
                }
            }

            return oMessageUsers;
        }


     

        public List<POCO.MessageUsers> D_MessagesbyDate(int id)
        {
            ds = new DataSet();
            List<POCO.MessageUsers> oLMessageUsers = new List<POCO.MessageUsers>();
            ds = oMessageUsersDAL.D_MessagesbyDate(id);
        
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oMessageUsers = new POCO.MessageUsers();
                        oMessageUsers.FromUserId = (int)ds.Tables[0].Rows[0]["FromUserId"];
                        //oMessageUsers.MessageBody = ds.Tables[0].Rows[0]["MessageBody"].ToString();
                        //oMessageUsers.FromDate = (DateTime)ds.Tables[0].Rows[0]["FromDate"];
                        //oMessageUsers.ToDate = (DateTime)ds.Tables[0].Rows[0]["ToDate"];
                        //oMessageUsers.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                        //oMessageUsers.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();

                        oLMessageUsers.Add(oMessageUsers);
                    }
                }

            }
            return oLMessageUsers;
        }

    }

}
