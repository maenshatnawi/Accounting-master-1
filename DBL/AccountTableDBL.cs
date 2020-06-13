using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;

namespace DBL
{
    public class AccountTableDBL
    {
        AccountTableDAL oAccountTableDAL = new AccountTableDAL();

        public List<POCO.AccountTable> M_AccountTable_Get()
        {
            DataSet ds = new DataSet();
            POCO.AccountTable oAccountTable;
            List<POCO.AccountTable> oLAccountTable = new List<POCO.AccountTable>();
            ds = oAccountTableDAL.M_AccountTable_Get();
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oAccountTable = new POCO.AccountTable();
                    oAccountTable.ID = Int64.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                    oAccountTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[i]["AccountNo"].ToString());
                    oAccountTable.AccountName = ds.Tables[0].Rows[i]["AccountName"].ToString();
                    oAccountTable.AcceptTrans = bool.Parse(ds.Tables[0].Rows[i]["AcceptTrans"].ToString());
                    oAccountTable.Debit = bool.Parse(ds.Tables[0].Rows[i]["Debit"].ToString());
                    oAccountTable.Credit = bool.Parse(ds.Tables[0].Rows[i]["Credit"].ToString());
                    oAccountTable.ProfitandLoss = bool.Parse(ds.Tables[0].Rows[i]["ProfitandLoss"].ToString());
                    oAccountTable.Budget = bool.Parse(ds.Tables[0].Rows[i]["Budget"].ToString());
                    oAccountTable.StandardValue = decimal.Parse(ds.Tables[0].Rows[i]["StandardValue"].ToString());
                    oAccountTable.AcceptCostCenter = bool.Parse(ds.Tables[0].Rows[i]["AcceptCostCenter"].ToString());
                    oAccountTable.ParentId = Int64.Parse(ds.Tables[0].Rows[i]["ParentId"].ToString());
                    oLAccountTable.Add(oAccountTable);
                }
            }


            return oLAccountTable;

        }


        public POCO.AccountTable M_AccountTable_Insert(POCO.AccountTable PoAccountTable)
        {
            DataSet ds = new DataSet();
            POCO.AccountTable oAccountTable = new POCO.AccountTable();
            ds = oAccountTableDAL.M_AccountTable_Insert(PoAccountTable.AccountName, PoAccountTable.AcceptTrans, PoAccountTable.Debit, PoAccountTable.Credit, PoAccountTable.ProfitandLoss, PoAccountTable.Budget, PoAccountTable.StandardValue, PoAccountTable.AcceptCostCenter, PoAccountTable.ParentId);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oAccountTable = new POCO.AccountTable();
                    oAccountTable.ID = Int64.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                    oAccountTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountTable.AccountName = ds.Tables[0].Rows[0]["AccountName"].ToString();
                    oAccountTable.AcceptTrans = bool.Parse(ds.Tables[0].Rows[0]["AcceptTrans"].ToString());
                    oAccountTable.Debit = bool.Parse(ds.Tables[0].Rows[0]["Debit"].ToString());
                    oAccountTable.Credit = bool.Parse(ds.Tables[0].Rows[0]["Credit"].ToString());
                    oAccountTable.ProfitandLoss = bool.Parse(ds.Tables[0].Rows[0]["ProfitandLoss"].ToString());
                    oAccountTable.Budget = bool.Parse(ds.Tables[0].Rows[0]["Budget"].ToString());
                    oAccountTable.StandardValue = decimal.Parse(ds.Tables[0].Rows[0]["StandardValue"].ToString());
                    oAccountTable.AcceptCostCenter = bool.Parse(ds.Tables[0].Rows[0]["AcceptCostCenter"].ToString());
                    oAccountTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oAccountTable;

        }
        public POCO.AccountTable M_AccountTable_Update(POCO.AccountTable PoAccountTable)
        {
            DataSet ds = new DataSet();
            POCO.AccountTable oAccountTable = new POCO.AccountTable();
            ds = oAccountTableDAL.M_AccountTable_Update(PoAccountTable.AccountNo, PoAccountTable.AccountName, PoAccountTable.AcceptTrans, PoAccountTable.Debit, PoAccountTable.Credit, PoAccountTable.ProfitandLoss, PoAccountTable.Budget, PoAccountTable.StandardValue, PoAccountTable.AcceptCostCenter, PoAccountTable.ParentId);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    oAccountTable.ID = Int64.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                    oAccountTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountTable.AccountName = ds.Tables[0].Rows[0]["AccountName"].ToString();
                    oAccountTable.AcceptTrans = bool.Parse(ds.Tables[0].Rows[0]["AcceptTrans"].ToString());
                    oAccountTable.Debit = bool.Parse(ds.Tables[0].Rows[0]["Debit"].ToString());
                    oAccountTable.Credit = bool.Parse(ds.Tables[0].Rows[0]["Credit"].ToString());
                    oAccountTable.ProfitandLoss = bool.Parse(ds.Tables[0].Rows[0]["ProfitandLoss"].ToString());
                    oAccountTable.Budget = bool.Parse(ds.Tables[0].Rows[0]["Budget"].ToString());
                    oAccountTable.StandardValue = decimal.Parse(ds.Tables[0].Rows[0]["StandardValue"].ToString());
                    oAccountTable.AcceptCostCenter = bool.Parse(ds.Tables[0].Rows[0]["AcceptCostCenter"].ToString());
                    oAccountTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oAccountTable;

        }

        public POCO.AccountTable M_AccountTable_Find(Int64 AccountNo)
        {
            DataSet ds = new DataSet();
            POCO.AccountTable oAccountTable = new POCO.AccountTable();
            ds = oAccountTableDAL.M_AccountTable_Find(AccountNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    oAccountTable.ID = Int64.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                    oAccountTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountTable.AccountName = ds.Tables[0].Rows[0]["AccountName"].ToString();
                    oAccountTable.AcceptTrans = bool.Parse(ds.Tables[0].Rows[0]["AcceptTrans"].ToString());
                    oAccountTable.Debit = bool.Parse(ds.Tables[0].Rows[0]["Debit"].ToString());
                    oAccountTable.Credit = bool.Parse(ds.Tables[0].Rows[0]["Credit"].ToString());
                    oAccountTable.ProfitandLoss = bool.Parse(ds.Tables[0].Rows[0]["ProfitandLoss"].ToString());
                    oAccountTable.Budget = bool.Parse(ds.Tables[0].Rows[0]["Budget"].ToString());
                    oAccountTable.StandardValue = decimal.Parse(ds.Tables[0].Rows[0]["StandardValue"].ToString());
                    oAccountTable.AcceptCostCenter = bool.Parse(ds.Tables[0].Rows[0]["AcceptCostCenter"].ToString());
                    oAccountTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oAccountTable;

        }


        public POCO.AccountTable M_AccountTable_Delete(Int64 AccountNo)
        {
            DataSet ds = new DataSet();
            POCO.AccountTable oAccountTable = new POCO.AccountTable();
            ds = oAccountTableDAL.M_AccountTable_Delete(AccountNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    oAccountTable.ID = Int64.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                    oAccountTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountTable.AccountName = ds.Tables[0].Rows[0]["AccountName"].ToString();
                    oAccountTable.AcceptTrans = bool.Parse(ds.Tables[0].Rows[0]["AcceptTrans"].ToString());
                    oAccountTable.Debit = bool.Parse(ds.Tables[0].Rows[0]["Debit"].ToString());
                    oAccountTable.Credit = bool.Parse(ds.Tables[0].Rows[0]["Credit"].ToString());
                    oAccountTable.ProfitandLoss = bool.Parse(ds.Tables[0].Rows[0]["ProfitandLoss"].ToString());
                    oAccountTable.Budget = bool.Parse(ds.Tables[0].Rows[0]["Budget"].ToString());
                    oAccountTable.StandardValue = decimal.Parse(ds.Tables[0].Rows[0]["StandardValue"].ToString());
                    oAccountTable.AcceptCostCenter = bool.Parse(ds.Tables[0].Rows[0]["AcceptCostCenter"].ToString());
                    oAccountTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oAccountTable;

        }

    }
}
        
