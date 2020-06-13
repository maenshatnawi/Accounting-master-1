using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompanyInfoDAL : DataBase
    {
        SqlCommand cmd;

        // Get List of Companies
        public DataSet D_CompanyInfo_Get()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_CompanyInfo_Get";

            return ExDatataBase_returnDataSet(cmd);
        }

        // Insert Company
        public DataSet D_CompanyInfo_Insert(decimal CompanyID, string CompanyNameAr, string CompanyNameEn, string Phone,string Address,string Fax,string FooterLine1,string FooterLine2,byte[]Img)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_CompanyInfo_Insert";
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@CompanyNameAr", CompanyNameAr);
            cmd.Parameters.AddWithValue("@CompanyNameEn", CompanyNameEn);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Fax", Fax);
            cmd.Parameters.AddWithValue("@FooterLine1", FooterLine1);
            cmd.Parameters.AddWithValue("@FooterLine2", FooterLine2);
            cmd.Parameters.AddWithValue("@Img", Img);

            return ExDatataBase_returnDataSet(cmd);
        }
       
    // Get CompanyInfo to make changes Edit(Get)
    public DataSet D_CompanyInfoGetToUpdate(decimal ID)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "D_CompanyInfoGetToUpdate";
        cmd.Parameters.AddWithValue("@ID", ID);

        return ExDatataBase_returnDataSet(cmd);
    }
        // Edit (Post)
    public void D_CompanyInfo_Update(decimal ID, decimal CompanyID, string CompanyNameAr, string CompanyNameEn, string Phone, string Address,string Fax, string FooterLine1, string FooterLine2,byte[]Img)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "D_CompanyInfo_Update";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@CompanyNameAr", CompanyNameAr);
            cmd.Parameters.AddWithValue("@CompanyNameEn", CompanyNameEn);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Fax", Fax);
            cmd.Parameters.AddWithValue("@FooterLine1", FooterLine1);
            cmd.Parameters.AddWithValue("@FooterLine2", FooterLine2);
            cmd.Parameters.AddWithValue("@Img", Img);

            ExDatataBase_nonQuery(cmd);
    }

        public void D_CompanyInfo_Delete(decimal ID)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_CompanyInfo_Delete";
            cmd.Parameters.AddWithValue("@ID", ID);

            ExDatataBase_nonQuery(cmd);
        }
    }
}