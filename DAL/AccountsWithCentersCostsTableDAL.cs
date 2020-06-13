using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AccountsWithCentersCostsTableDAL:DataBase
    {
        public DataSet M_AccountsWithCentersCostsTable_Get()
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountsWithCentersCostsTable_Get";


            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_AccountsWithCentersCostsTable_Insert(Int64 AccountNo, Int64 CentersCostsNo)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountsWithCentersCostsTable_Insert";
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);
            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_AccountsWithCentersCostsTable_Delete(Int64 AccountNo, Int64 CentersCostsNo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "M_AccountsWithCentersCostsTable_Delete";
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);

            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);
            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_AccountsWithCentersCostsTable_Update(Int64 ID,Int64 AccountNo, Int64 CentersCostsNo)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountsWithCentersCostsTable_Update";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);
            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_AccountsWithCentersCostsTable_Find(Int64 AccountNo, Int64 CentersCostsNo)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountsWithCentersCostsTable_Find";
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
            cmd.Parameters.AddWithValue("@CentersCostsNo", CentersCostsNo);
            return ExDatataBase_returnDataSet(cmd);
        }
    }
}
