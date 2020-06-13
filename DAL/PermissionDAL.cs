using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermissionDAL:DataBase
    {
        private SqlCommand cmd;

        public void D_Permission_Insert(string PermissionName,string PermissionState,string PermissionRelated,int CollectionId,int Pnumber)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Permission_Insert";
            cmd.Parameters.AddWithValue("@PermissionName", PermissionName);
            cmd.Parameters.AddWithValue("@PermissionState", PermissionState);
            cmd.Parameters.AddWithValue("@PermissionRelated", PermissionRelated);
            cmd.Parameters.AddWithValue("@CollectionId", CollectionId);
            cmd.Parameters.AddWithValue("@Pnumber", Pnumber);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_Permission_Get()
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Permission_Get";

            return ExDatataBase_returnDataSet(cmd);
        }

        public void D_Permission_Delete(int ID)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Permission_Delete";
            cmd.Parameters.AddWithValue("@ID", ID);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_Permission_Edit(int ID)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Permission_Edit";
            cmd.Parameters.AddWithValue("@ID", ID);

            return ExDatataBase_returnDataSet(cmd);
        }
        public void D_Permission_Update(int ID, string PermissionName, string PermissionState, string PermissionRelated, int CollectionId, int Pnumber)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Permission_Update";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@PermissionName", PermissionName);
            cmd.Parameters.AddWithValue("@PermissionState", PermissionState);
            cmd.Parameters.AddWithValue("@PermissionRelated", PermissionRelated);
            cmd.Parameters.AddWithValue("@CollectionId", CollectionId);
            cmd.Parameters.AddWithValue("@Pnumber", Pnumber);

            ExDatataBase_nonQuery(cmd);
        }


    }
}
