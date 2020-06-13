using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
   public class CompanyInfo
    {
        public int ID { get; set; }
        ////[Display(Name = "Company ID")]
        public decimal CompanyID { get; set; }

        ////[Display(Name = "Arabic Name")]
        public string CompanyNameAr { get; set; }
        ////[Display(Name = "English Name")]
        public string CompanyNameEn { get; set; }
        ////[Display(Name = "Phone")]
        public string Phone { get; set; }
        ////[Display(Name = "Address")]
        public string Address { get; set; }
        public string Fax { get; set; }
        ////[Display(Name = "First Footer")]
        public string FooterLine1 { get; set; }
        ////[Display(Name = "Second Footer")]
        public string FooterLine2 { get; set; }
        public  Byte[] Img { get; set; }
    }
}
