using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
   public class AccountsWithCentersCostsTable
    {

        public Int64 ID { get; set; }
        public Int64 AccountNo { get; set; }
        public Int64 CentersCostsNo { get; set; }
        public string AccountName { get; set; }
        public string CentersCostsName { get; set; }
        public virtual AccountTable AccountTable { get; set; }
        public virtual CentersCostsTable CentersCostsTable { get; set; }


    }
}
