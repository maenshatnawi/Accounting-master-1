using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace DBL
{
    public class UserDBL
    {
        private UserDAL oUserDAL;
        private DataSet ds;
        private POCO.User oUser;

        public UserDBL()
        {
            oUserDAL = new UserDAL();
        }
        public void D_Users_Insert(POCO.User PoUser)
        {

            oUserDAL.D_Users_Insert(PoUser.Username, PoUser.Password, PoUser.FirstName, PoUser.MidName, PoUser.LastName, PoUser.Email, PoUser.Address, PoUser.PhoneNo);
         }

        public POCO.User D_User_Edit(int ID)
        {
            ds = new DataSet();
            oUser = new POCO.User();
            ds = oUserDAL.D_User_Edit(ID);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oUser.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                    oUser.Username = ds.Tables[0].Rows[0]["Username"].ToString();
                    oUser.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    oUser.MidName = ds.Tables[0].Rows[0]["MidName"].ToString();
                    oUser.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                    oUser.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                    oUser.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                    oUser.PhoneNo = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
                }

            }

            return oUser;

        }

        public void D_Users_Update(POCO.User PoUser)
        {
            oUserDAL.D_User_Update(PoUser.UserID, PoUser.Username, PoUser.FirstName, PoUser.MidName, PoUser.LastName, PoUser.Email, PoUser.Address, PoUser.PhoneNo);
        }

        public void D_Users_Delete(int ID)
        {
            oUserDAL.D_Users_Delete(ID);
        }
        public List<POCO.User> D_Users_Get()
        {
            ds = new DataSet();
            List<POCO.User> oLUser = new List<POCO.User>();

            ds = oUserDAL.D_Users_Get();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oUser = new POCO.User();

                        oUser.UserID = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);
                        oUser.Username = ds.Tables[0].Rows[i]["Username"].ToString();
                        oUser.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                        oUser.MidName = ds.Tables[0].Rows[i]["MidName"].ToString();
                        oUser.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                        oUser.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                        oUser.Address = ds.Tables[0].Rows[i]["Address"].ToString();
                        oUser.PhoneNo = ds.Tables[0].Rows[i]["PhoneNo"].ToString();

                        oLUser.Add(oUser);
                    }
                }
            }
            return oLUser;
        }

        public POCO.User D_User_Login(POCO.User PoUser)
        {
            DataSet ds = new DataSet();
            oUser = new POCO.User();
            ds = oUserDAL.D_Users_Login(PoUser.Username, PoUser.Password);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oUser.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    oUser.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                    oUser.UserID =(int) ds.Tables[0].Rows[0]["Id"];
                    oUser.UserPermission = ds.Tables[0].Rows[0]["UserPermission"].ToString();
                }

            }
            return oUser;
        }

        public POCO.User D_User_Check(int id)
        {
            DataSet ds = new DataSet();
            oUser = new POCO.User();
            ds = oUserDAL.D_User_Check(id);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oUser.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
                    oUser.Username = ds.Tables[0].Rows[0]["Username"].ToString();
                }

            }
            return oUser;
        }
        public void D_Users_Change_Password(POCO.User PoUser)
        {
            oUserDAL.D_Users_Change_Password(PoUser.UserID, PoUser.Password);
        }

    }
}
