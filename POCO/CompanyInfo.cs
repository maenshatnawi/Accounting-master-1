using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
   public class CompanyInfo
    {
        public int ID { get; set; }
        public decimal CompanyID { get; set; }

        public string CompanyNameAr { get; set; }
        public string CompanyNameEn { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public string FooterLine1 { get; set; }
        public string FooterLine2 { get; set; }
        public  Byte[] Img { get; set; }
    }
}
