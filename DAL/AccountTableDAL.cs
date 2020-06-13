using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
 using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AccountTableDAL:DataBase
    {
        public DataSet M_AccountTable_Get()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountTable_Get";
           

            return ExDatataBase_returnDataSet(cmd);
        }

      
        public DataSet M_AccountTable_Insert(string AccountName,bool AcceptTrans,bool Debit,bool Credit,bool ProfitandLoss,bool Budget,decimal StandardValue,bool AcceptCostCenter, Int64 ParentId)
        {
         

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountTable_Insert";
            //cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
            cmd.Parameters.AddWithValue("@AccountName", AccountName);
            cmd.Parameters.AddWithValue("@AcceptTrans", AcceptTrans);
            cmd.Parameters.AddWithValue("@Debit", Debit);
            cmd.Parameters.AddWithValue("@Credit", Credit);
            cmd.Parameters.AddWithValue("@ProfitandLoss", ProfitandLoss);
            cmd.Parameters.AddWithValue("@Budget", Budget);
            cmd.Parameters.AddWithValue("@StandardValue", StandardValue);
            cmd.Parameters.AddWithValue("@AcceptCostCenter", AcceptCostCenter);
            cmd.Parameters.AddWithValue("@ParentId", ParentId);
            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet M_AccountTable_Update(Int64 AccountNo, string AccountName, bool AcceptTrans, bool Debit, bool Credit, bool ProfitandLoss, bool Budget, decimal StandardValue, bool AcceptCostCenter, Int64 ParentId)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountTable_Update";
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
            cmd.Parameters.AddWithValue("@AccountName", AccountName);
            cmd.Parameters.AddWithValue("@AcceptTrans", AcceptTrans);
            cmd.Parameters.AddWithValue("@Debit", Debit);
            cmd.Parameters.AddWithValue("@Credit", Credit);
            cmd.Parameters.AddWithValue("@ProfitandLoss", ProfitandLoss);
            cmd.Parameters.AddWithValue("@Budget", Budget);
            cmd.Parameters.AddWithValue("@StandardValue", StandardValue);
            cmd.Parameters.AddWithValue("@AcceptCostCenter", AcceptCostCenter);
            cmd.Parameters.AddWithValue("@ParentId", ParentId);
            return ExDatataBase_returnDataSet(cmd);
        }


        public DataSet M_AccountTable_Find(Int64 AccountNo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountTable_Find";
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);
         
            return ExDatataBase_returnDataSet(cmd);
        }

  

        public DataSet M_AccountTable_Delete(Int64 AccountNo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "M_AccountTable_Delete";
            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);

            return ExDatataBase_returnDataSet(cmd);
        }

    }
}
