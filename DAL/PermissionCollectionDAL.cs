using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermissionCollectionDAL:DataBase
    {
        private SqlCommand cmd;

        public void D_Collection_Insert(string CollectionName)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Collection_Insert";
            cmd.Parameters.AddWithValue("@CollectionName", CollectionName);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_Collections_Get()
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Collection_Get";

            return ExDatataBase_returnDataSet(cmd);
        }

        public void D_Collection_Delete(int ID)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Collection_Delete";
            cmd.Parameters.AddWithValue("@ID", ID);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_Collection_Edit(int ID)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Collection_Edit";
            cmd.Parameters.AddWithValue("@ID", ID);

            return ExDatataBase_returnDataSet(cmd);
        }
        public void D_Collection_Update(int ID, string CollectionName)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Collection_Update";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@CollectionName", CollectionName);

            ExDatataBase_nonQuery(cmd);
        }
       
    }
}
