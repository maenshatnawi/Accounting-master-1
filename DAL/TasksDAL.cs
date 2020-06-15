using POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TasksDAL:DataBase
    {
        private SqlCommand cmd;
        public TasksDAL()
        {
            cmd = new SqlCommand();
        }
        //Status Status
        public void D_Task_Insert(string Title, List<Status>statuses, DateTime FromDate, DateTime ToDate, int ToUserId, string Description)
        {

            cmd.CommandText = "D_Task_Insert";
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Status", statuses);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@ToUserId", ToUserId);
            cmd.Parameters.AddWithValue("@Description", Description);

            ExDatataBase_nonQuery(cmd);
        }

        //public void D_Task_Insert(string title, global::POCO.Status status, DateTime fromDate, DateTime toDate, int toUserId, string description)
        //{
        //    throw new NotImplementedException();
        //}

        public DataSet D_AllTasks_Get()
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_AllTasks_Get";

            return ExDatataBase_returnDataSet(cmd);
        }

        public void D_Task_Delete(int ID)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Task_Delete";
            cmd.Parameters.AddWithValue("@id", ID);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_Task_Find(int id)
        {
            cmd.CommandText = "D_Task_Find";
            cmd.Parameters.AddWithValue("@id", id);

            return ExDatataBase_returnDataSet(cmd);
        }
        public void D_Task_Update(int Id, string Title, List<Status> statuses, DateTime FromDate, DateTime ToDate, int ToUserId, string Description)
        {
            cmd.CommandText = "D_Users_Update";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Status", statuses);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@ToUserId", ToUserId);
            cmd.Parameters.AddWithValue("@Description", Description);

            ExDatataBase_nonQuery(cmd);
        }

    }
}
