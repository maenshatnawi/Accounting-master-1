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
        public DataSet D_Messages_Insert(string MessageBody, string FromUser, string MessageIcon,DateTime FromDate,DateTime ToDate)
        {
             cmd = new SqlCommand();
            cmd.CommandText = "D_Messages_Insert";
            cmd.Parameters.AddWithValue("@MessageBody", MessageBody);
            cmd.Parameters.AddWithValue("@FromUser", FromUser);
            cmd.Parameters.AddWithValue("@MessageIcon", MessageIcon);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);

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
    }
}
