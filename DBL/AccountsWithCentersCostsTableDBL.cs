using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
  public class AccountsWithCentersCostsTableDBL
    {
        AccountsWithCentersCostsTableDAL oAccountsWithCentersCostsTableDAL = new AccountsWithCentersCostsTableDAL();
        public List<POCO.AccountsWithCentersCostsTable> M_AccountsWithCentersCostsTable_Get()
        {
            DataSet ds = new DataSet();
            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();
            List<POCO.AccountsWithCentersCostsTable> oLAccountsWithCentersCostsTable = new List<POCO.AccountsWithCentersCostsTable>();
            ds = oAccountsWithCentersCostsTableDAL.M_AccountsWithCentersCostsTable_Get();
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();
                    oAccountsWithCentersCostsTable.ID = Int64.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                    oAccountsWithCentersCostsTable.AccountName = ds.Tables[0].Rows[i]["AccountName"].ToString();
                    oAccountsWithCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[i]["CentersCostsName"].ToString();
                    oAccountsWithCentersCostsTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[i]["AccountNo"].ToString());
                    oAccountsWithCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[i]["CentersCostsNo"].ToString());
                    
                    oLAccountsWithCentersCostsTable.Add(oAccountsWithCentersCostsTable);
                }
            }


            return oLAccountsWithCentersCostsTable;

        }

        public POCO.AccountsWithCentersCostsTable M_AccountsWithCentersCostsTable_Insert(POCO.AccountsWithCentersCostsTable PoAccountsWithCentersCostsTable)
        {
            DataSet ds = new DataSet();
            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();
            ds = oAccountsWithCentersCostsTableDAL.M_AccountsWithCentersCostsTable_Insert(PoAccountsWithCentersCostsTable.AccountNo, PoAccountsWithCentersCostsTable.CentersCostsNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    

                    oAccountsWithCentersCostsTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountsWithCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[0]["CentersCostsNo"].ToString());

                }

            }
            return oAccountsWithCentersCostsTable;

        }

        public POCO.AccountsWithCentersCostsTable M_AccountsWithCentersCostsTable_Delete(Int64 AccountNo, Int64 CentersCostsNo)
        {
            DataSet ds = new DataSet();
            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();
            ds = oAccountsWithCentersCostsTableDAL.M_AccountsWithCentersCostsTable_Delete(AccountNo, CentersCostsNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();

                    oAccountsWithCentersCostsTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountsWithCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[0]["CentersCostsNo"].ToString());

                }

            }
            return oAccountsWithCentersCostsTable;

        }

        public POCO.AccountsWithCentersCostsTable M_AccountsWithCentersCostsTable_Update(Int64 ID,Int64 AccountNo, Int64 CentersCostsNo)
        {
            DataSet ds = new DataSet();
            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();
            ds = oAccountsWithCentersCostsTableDAL.M_AccountsWithCentersCostsTable_Update(ID,AccountNo, CentersCostsNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                   

                    oAccountsWithCentersCostsTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountsWithCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[0]["CentersCostsNo"].ToString());

                }

            }
            return oAccountsWithCentersCostsTable;

        }
        public POCO.AccountsWithCentersCostsTable M_AccountsWithCentersCostsTable_Find(Int64 AccountNo, Int64 CentersCostsNo)
        {
            DataSet ds = new DataSet();
            POCO.AccountsWithCentersCostsTable oAccountsWithCentersCostsTable = new POCO.AccountsWithCentersCostsTable();
            ds = oAccountsWithCentersCostsTableDAL.M_AccountsWithCentersCostsTable_Find(AccountNo, CentersCostsNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                    oAccountsWithCentersCostsTable.ID = Int64.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                    oAccountsWithCentersCostsTable.AccountName = ds.Tables[0].Rows[0]["AccountName"].ToString();
                    oAccountsWithCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[0]["CentersCostsName"].ToString();
                    oAccountsWithCentersCostsTable.AccountNo = Int64.Parse(ds.Tables[0].Rows[0]["AccountNo"].ToString());
                    oAccountsWithCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[0]["CentersCostsNo"].ToString());

                }

            }
            return oAccountsWithCentersCostsTable;

        }

    }
}
