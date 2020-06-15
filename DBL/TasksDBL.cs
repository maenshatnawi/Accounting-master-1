using DAL;
using POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL
{
  public class TasksDBL
    {
        private TasksDAL otasksDAL;
        private DataSet ds;
        private POCO.Task otask;

        public TasksDBL()
        {
            otasksDAL = new TasksDAL();
            otask = new POCO.Task();
        }
        public void D_Task_Insert(POCO.Task PoTask)
        {
            otasksDAL.D_Task_Insert(PoTask.Title,PoTask.Status.ToList(), PoTask.FromDate,PoTask.ToDate,PoTask.ToUserId,PoTask.Description);
        }


        public POCO.Task D_Task_Find(int ID)
        {
            ds = new DataSet();
            ds = otasksDAL.D_Task_Find(ID);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    otask.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
                    otask.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                    otask.Status =(List<Status>)ds.Tables[0].Rows[0]["Status"];
                    otask.FromDate =(DateTime) ds.Tables[0].Rows[0]["FromDate"];
                    otask.ToDate = (DateTime)ds.Tables[0].Rows[0]["ToDate"];
                    otask.ToUserId =(int) ds.Tables[0].Rows[0]["ToUserId"];
                    otask.Description= ds.Tables[0].Rows[0]["Description"].ToString();
                }
            }

            return otask;

        }

        public void D_Task_Update(POCO.Task PoTask)
        {
            otasksDAL.D_Task_Update(PoTask.Id,PoTask.Title, PoTask.Status.ToList(), PoTask.FromDate, PoTask.ToDate, PoTask.ToUserId, PoTask.Description);
        }

        public void D_Users_Delete(int ID)
        {
            otasksDAL.D_Task_Delete(ID);
        }


        //Admin tasks
        public List<POCO.Task> D_AllTasks_Get()
        {
            ds = new DataSet();
            List<POCO.Task> oLTaskr = new List<POCO.Task>();

            ds = otasksDAL.D_AllTasks_Get();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        otask = new POCO.Task();

                        otask.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
                        otask.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                        otask.Status = (List<Status>)ds.Tables[0].Rows[0]["Status"];
                        otask.FromDate = (DateTime)ds.Tables[0].Rows[0]["FromDate"];
                        otask.ToDate = (DateTime)ds.Tables[0].Rows[0]["ToDate"];
                        otask.ToUserId = (int)ds.Tables[0].Rows[0]["ToUserId"];
                        otask.Description = ds.Tables[0].Rows[0]["Description"].ToString();

                        oLTaskr.Add(otask);
                    }
                }
            }
            return oLTaskr;
        }

    }
}
