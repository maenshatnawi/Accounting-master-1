using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CentersCostsTableDAL:DataBase
    {
        public DataSet M_CentersCostsTable_Get()
        {
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="M_CentersCostsTable_Get";


            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_CentersCostsTable_Find(Int64 CentersCostsNo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_CentersCostsTable_Find";
            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);

            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_CentersCostsTable_Delete(Int64 CentersCostsNo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_CentersCostsTable_Delete";
            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);

            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_CentersCostsTable_Insert( string CentersCostsName, Int64 ParentId)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_CentersCostsTable_Insert";
            cmd.Parameters.AddWithValue("@CentersCostsName", CentersCostsName);
            cmd.Parameters.AddWithValue("@ParentId", ParentId);                   
            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_CentersCostsTable_Update(Int64 CentersCostsNo, string CentersCostsName, Int64 ParentId)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_CentersCostsTable_Update";
            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);
            cmd.Parameters.AddWithValue("@CentersCostsName", CentersCostsName);
            cmd.Parameters.AddWithValue("@ParentId", ParentId);
            return ExDatataBase_returnDataSet(cmd);
        }
    }
}
