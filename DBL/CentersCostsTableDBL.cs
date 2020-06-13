using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
    public class CentersCostsTableDBL
    {
        CentersCostsTableDAL oCentersCostsTableDAL = new CentersCostsTableDAL();
        public List<POCO.CentersCostsTable> M_CentersCostsTable_Get()
        {
            DataSet ds = new DataSet();
            POCO.CentersCostsTable oCentersCostsTable;
            List<POCO.CentersCostsTable> oLCentersCostsTable = new List<POCO.CentersCostsTable>();
            ds = oCentersCostsTableDAL.M_CentersCostsTable_Get();
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oCentersCostsTable = new POCO.CentersCostsTable();
                    oCentersCostsTable.ID = Int64.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                    oCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[i]["CentersCostsNo"].ToString());
                    oCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[i]["CentersCostsName"].ToString();

                    oCentersCostsTable.ParentId = Int64.Parse(ds.Tables[0].Rows[i]["ParentId"].ToString());
                    oLCentersCostsTable.Add(oCentersCostsTable);
                }
            }


            return oLCentersCostsTable;

        }
        public POCO.CentersCostsTable M_CentersCostsTable_Find(Int64 CentersCostsNo)
        {
            DataSet ds = new DataSet();
            POCO.CentersCostsTable oCentersCostsTable = new POCO.CentersCostsTable();
            ds = oCentersCostsTableDAL.M_CentersCostsTable_Find(CentersCostsNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    oCentersCostsTable.CentersCostsNo= Int64.Parse(ds.Tables[0].Rows[0]["CentersCostsNo"].ToString()) ;
                    oCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[0]["CentersCostsName"].ToString();
                    oCentersCostsTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oCentersCostsTable;

        }


        public POCO.CentersCostsTable M_CentersCostsTable_Delete(Int64 CentersCostsNo)
        {
            DataSet ds = new DataSet();
            POCO.CentersCostsTable oCentersCostsTable = new POCO.CentersCostsTable();
            ds = oCentersCostsTableDAL.M_CentersCostsTable_Delete(CentersCostsNo);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    oCentersCostsTable.CentersCostsNo = Int64.Parse(ds.Tables[0].Rows[0]["CentersCostsNo"].ToString());
                    oCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[0]["CentersCostsName"].ToString();
                    oCentersCostsTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oCentersCostsTable;

        }
        public POCO.CentersCostsTable M_CentersCostsTable_Insert(POCO.CentersCostsTable PoCentersCostsTable)
        {
            DataSet ds = new DataSet();
            POCO.CentersCostsTable oCentersCostsTable = new POCO.CentersCostsTable();
            ds = oCentersCostsTableDAL.M_CentersCostsTable_Insert(PoCentersCostsTable.CentersCostsName, PoCentersCostsTable.ParentId);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    

                    oCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[0]["CentersCostsName"].ToString();
                    oCentersCostsTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oCentersCostsTable;

        }


        public POCO.CentersCostsTable M_CentersCostsTable_Update(POCO.CentersCostsTable PoCentersCostsTable)
        {
            DataSet ds = new DataSet();
            POCO.CentersCostsTable oCentersCostsTable = new POCO.CentersCostsTable();
            ds = oCentersCostsTableDAL.M_CentersCostsTable_Update(PoCentersCostsTable.CentersCostsNo,PoCentersCostsTable.CentersCostsName, PoCentersCostsTable.ParentId);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    

                    oCentersCostsTable.CentersCostsName = ds.Tables[0].Rows[0]["CentersCostsName"].ToString();
                    oCentersCostsTable.ParentId = Int64.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());

                }

            }
            return oCentersCostsTable;

        }
    }
}
