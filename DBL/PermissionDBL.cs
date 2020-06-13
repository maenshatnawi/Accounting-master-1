using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
    public class PermissionDBL
    {
        private PermissionDAL oPermissionDAL;
        private DataSet ds;
        private POCO.Permission oPermission;

        public PermissionDBL()
        {
            oPermissionDAL = new PermissionDAL();
        }
        public void D_Permission_Insert(POCO.Permission PoPermission)
        {
            oPermissionDAL.D_Permission_Insert(PoPermission.PermissionName,PoPermission.PermissionState,PoPermission.PermissionRelated,PoPermission.PermissionID,PoPermission.PermissionNumber);
        }

        public POCO.Permission D_Permission_Edit(int ID)
        {
            ds = new DataSet();
            oPermission = new POCO.Permission();
            ds = oPermissionDAL.D_Permission_Edit(ID);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oPermission.PermissionID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                    oPermission.PermissionName = ds.Tables[0].Rows[0]["PermissionName"].ToString();
                    oPermission.PermissionState = ds.Tables[0].Rows[0]["PermissionState"].ToString();
                    oPermission.PermissionRelated = ds.Tables[0].Rows[0]["PermissionRelated"].ToString();
                    oPermission.Collection_ID = Convert.ToInt32(ds.Tables[0].Rows[0]["CollectionID"].ToString());
                    oPermission.CollectionName = ds.Tables[0].Rows[0]["CollectionName"].ToString();
                    oPermission.PermissionNumber =Convert.ToInt32(ds.Tables[0].Rows[0]["Pnumber"].ToString());
                }

            }

            return oPermission;

        }

        public void D_Permission_Update(POCO.Permission PoPermission)
        {
            oPermissionDAL.D_Permission_Update(PoPermission.PermissionID, PoPermission.PermissionName,PoPermission.PermissionState,PoPermission.PermissionRelated,PoPermission.Collection_ID,PoPermission.PermissionNumber);
        }

        public void D_Permission_Delete(int ID)
        {
            oPermissionDAL.D_Permission_Delete(ID);
        }
        public List<POCO.Permission> D_Permission_Get()
        {
            ds = new DataSet();
            List<POCO.Permission> oLPermission = new List<POCO.Permission>();

            ds = oPermissionDAL.D_Permission_Get();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        oPermission = new POCO.Permission();

                        oPermission.PermissionID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                        oPermission.PermissionName = ds.Tables[0].Rows[0]["PermissionName"].ToString();
                        oPermission.PermissionState = ds.Tables[0].Rows[0]["PermissionState"].ToString();
                        oPermission.PermissionRelated = ds.Tables[0].Rows[0]["PermissionRelated"].ToString();
                        oPermission.Collection_ID = Convert.ToInt32(ds.Tables[0].Rows[0]["CollectionID"].ToString());
                        oPermission.CollectionName = ds.Tables[0].Rows[0]["CollectionName"].ToString();
                        oPermission.PermissionNumber = Convert.ToInt32(ds.Tables[0].Rows[0]["Pnumber"].ToString());

                        oLPermission.Add(oPermission);
                    }
                }
            }
            return oLPermission;
        }

    }
}
