using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBL
{
   public class CompanyInfoDBL
    {
        private CompanyInfoDAL ocompanyInfoDAL=new CompanyInfoDAL();
        private DataSet ds;
        private POCO.CompanyInfo oCompany;

        public List<POCO.CompanyInfo> D_CompanyInfo_Get()
        {
            DataSet ds = new DataSet();
           
            List<POCO.CompanyInfo> ocompanyList = new List<POCO.CompanyInfo>();
            ds = ocompanyInfoDAL.D_CompanyInfo_Get();
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                        oCompany = new POCO.CompanyInfo();
                        oCompany.ID = Convert.ToInt32(dr["id"]);
                        oCompany.CompanyID = Convert.ToInt32(dr["CompanyID"]);
                        oCompany.CompanyNameAr = dr["CompanyNameAr"].ToString();
                        oCompany.CompanyNameEn = dr["CompanyNameEn"].ToString();
                        oCompany.Address = dr["Address"].ToString();
                        oCompany.Fax = dr["Fax"].ToString();
                        oCompany.Phone = dr["Phone"].ToString();
                        oCompany.FooterLine1 = dr["FooterLine1"].ToString();
                        oCompany.FooterLine2 = dr["FooterLine2"].ToString();
                        oCompany.Img = (byte[])dr["Img"];

                        ocompanyList.Add(oCompany);
                    }
                }
          
            return ocompanyList;
        }

        public POCO.CompanyInfo D_CompanyInfo_Insert(POCO.CompanyInfo PoCompany)
        {
            DataSet ds = new DataSet();
            oCompany = new POCO.CompanyInfo();

            ds = ocompanyInfoDAL.D_CompanyInfo_Insert(PoCompany.CompanyID, PoCompany.CompanyNameAr, PoCompany.Phone, PoCompany.CompanyNameEn, PoCompany.Address, PoCompany.Fax, PoCompany.FooterLine1, PoCompany.FooterLine2,PoCompany.Img);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oCompany.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                    oCompany.CompanyID = Convert.ToInt32(ds.Tables[0].Rows[0]["CompanyID"]);
                    oCompany.CompanyNameAr = ds.Tables[0].Rows[0]["CompanyNameAr"].ToString();
                    oCompany.CompanyNameEn = ds.Tables[0].Rows[0]["CompanyNameEn"].ToString();
                    oCompany.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                    oCompany.Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                    oCompany.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                    oCompany.FooterLine1 = ds.Tables[0].Rows[0]["FooterLine1"].ToString();
                    oCompany.FooterLine2 = ds.Tables[0].Rows[0]["FooterLine2"].ToString();
                    oCompany.Img = (byte[])ds.Tables[0].Rows[0]["Img"];

                }
            }

          
            return oCompany;
        }


  
        //Edit (Get)
        public POCO.CompanyInfo D_CompanyInfoGetToUpdate(decimal ID)
        {
            ds = new DataSet();
            oCompany = new POCO.CompanyInfo();
            ds = ocompanyInfoDAL.D_CompanyInfoGetToUpdate(ID);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oCompany.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                    oCompany.CompanyID = Convert.ToInt32(ds.Tables[0].Rows[0]["CompanyID"]);
                    oCompany.CompanyNameAr = ds.Tables[0].Rows[0]["CompanyNameAr"].ToString();
                    oCompany.CompanyNameEn = ds.Tables[0].Rows[0]["CompanyNameEn"].ToString();
                    oCompany.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                    oCompany.Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                    oCompany.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                    oCompany.FooterLine1 = ds.Tables[0].Rows[0]["FooterLine1"].ToString();
                    oCompany.FooterLine2 = ds.Tables[0].Rows[0]["FooterLine2"].ToString();
                    oCompany.Img = (byte[])ds.Tables[0].Rows[0]["Img"];
                }

            }

            return oCompany;

        }
        // Edit(Post)
        public void D_CompanyInfo_Update(POCO.CompanyInfo PoCompany)
        {
            ocompanyInfoDAL.D_CompanyInfo_Update(PoCompany.ID,PoCompany.CompanyID, PoCompany.CompanyNameAr, PoCompany.Phone, PoCompany.CompanyNameEn, PoCompany.Address, PoCompany.Fax, PoCompany.FooterLine1, PoCompany.FooterLine2,PoCompany.Img);
        }

        public void D_CompanyInfo_Delete(decimal ID)
        {
            ocompanyInfoDAL.D_CompanyInfo_Delete(ID);
        }
    }
}
