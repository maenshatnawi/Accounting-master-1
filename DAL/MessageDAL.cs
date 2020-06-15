using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MessageDAL : DataBase
    {
        SqlCommand cmd;
        public DataSet D_Messages_Insert(string MessageSubject,string MessageBody, string FromUser, string MessageIcon,DateTime FromDate,DateTime ToDate)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Messages_Insert";
            cmd.Parameters.AddWithValue("@MessageSubject", MessageSubject);
            cmd.Parameters.AddWithValue("@MessageBody", MessageBody);
            cmd.Parameters.AddWithValue("@FromUser", FromUser);
            cmd.Parameters.AddWithValue("@MessageIcon", MessageIcon);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);

            return ExDatataBase_returnDataSet(cmd);
        }
        public DataSet D_MessageUsers_Get(int ID)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_MessageUsers_Get";
            cmd.Parameters.AddWithValue("@FromUserId", ID);

            return ExDatataBase_returnDataSet(cmd);
        }
        public DataSet D_MessageUsers_GetToUpdate(int id,int Uid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_MessageUser_GetToUpdate";
            cmd.Parameters.AddWithValue("@MessageId", id);
            cmd.Parameters.AddWithValue("@ToUserId", Uid);

            return ExDatataBase_returnDataSet(cmd);
        }
        public void D_MessagesUsers_Update(int MessageId, string MessageBody, string MessageIcon, DateTime FromDate, DateTime ToDate)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_MessagesUsers_Update";
            cmd.Parameters.AddWithValue("@MessageId", MessageId);
            cmd.Parameters.AddWithValue("@MessageBody", MessageBody);
            cmd.Parameters.AddWithValue("@MessageIcon", MessageIcon);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);

            ExDatataBase_nonQuery(cmd);
        }

        // get users list except logged user
        public DataSet D_UsersExceptLogged_Get(int id)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_UsersExceptLogged_Get";
            cmd.Parameters.AddWithValue("@id", id);

            return ExDatataBase_returnDataSet(cmd);

        }
    }
}
