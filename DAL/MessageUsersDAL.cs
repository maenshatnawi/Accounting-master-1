using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class MessageUsersDAL : DataBase
    {
        public DataSet D_MessageUsers_Insert(int MessageId, int FromUserId, int ToUserId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_MessageUsers_Insert";
            cmd.Parameters.AddWithValue("@MessageId", MessageId);
            cmd.Parameters.AddWithValue("@FromUserId", FromUserId);
            cmd.Parameters.AddWithValue("@ToUserId", ToUserId);

            return ExDatataBase_returnDataSet(cmd);

        }
        public DataSet D_MessageUsers_Get(int ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_MessageUsers_Get";
            cmd.Parameters.AddWithValue("@FromUserId", ID);

            return ExDatataBase_returnDataSet(cmd);
        }
        public DataSet D_MessageUsers_GetToUpdate(int ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_MessageUser_GetToUpdate";
            cmd.Parameters.AddWithValue("@MessageId", ID);

            return ExDatataBase_returnDataSet(cmd);
        }
        public DataSet D_MessagesbyDate(int FromUserId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_MessagesbyDate";
            cmd.Parameters.AddWithValue("@FromUserId", FromUserId);

            return ExDatataBase_returnDataSet(cmd);

        }
        
    }
}
