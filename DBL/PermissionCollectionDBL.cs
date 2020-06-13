using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
    public class PermissionCollectionDBL
    {
        private PermissionCollectionDAL oCollectionDAL;
        private DataSet ds;
        private POCO.PermissionCollection oCollection;

        public PermissionCollectionDBL()
        {
            oCollectionDAL = new PermissionCollectionDAL();
        }
        public void D_Collection_Insert(POCO.PermissionCollection PoCollection)
        {
            oCollectionDAL.D_Collection_Insert(PoCollection.CollectionName);
        }

        public POCO.PermissionCollection D_Collection_Edit(int ID)
        {
            ds = new DataSet();
            oCollection = new POCO.PermissionCollection();
            ds = oCollectionDAL.D_Collection_Edit(ID);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oCollection.CollectionID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                    oCollection.CollectionName = ds.Tables[0].Rows[0]["CollectionName"].ToString();
                }

            }

            return oCollection;

        }

        public void D_Collection_Update(POCO.PermissionCollection PoColection)
        {
            oCollectionDAL.D_Collection_Update(PoColection.CollectionID, PoColection.CollectionName);
        }

        public void D_Collection_Delete(int ID)
        {
            oCollectionDAL.D_Collection_Delete(ID);
        }
        public List<POCO.PermissionCollection> D_Collection_Get()
        {
            ds = new DataSet();
            List<POCO.PermissionCollection> oLCollection = new List<POCO.PermissionCollection>();

            ds = oCollectionDAL.D_Collections_Get();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oCollection = new POCO.PermissionCollection();

                        oCollection.CollectionID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]);
                        oCollection.CollectionName = ds.Tables[0].Rows[i]["CollectionName"].ToString();

                        oLCollection.Add(oCollection);
                    }
                }
            }
            return oLCollection;
        }

    }
}
