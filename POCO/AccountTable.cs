using System;
using System.Collections.Generic;
using System.ComponentModel;
 using System.Text;



namespace POCO
{
  public  class AccountTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountTable()
        {
            this.AccountsWithCentersCostsTable = new HashSet<AccountsWithCentersCostsTable>();
        }
        public Int64 ID { get; set; }
        public Int64  AccountNo { get; set; }
        public string AccountName { get; set; }
        public bool AcceptTrans { get; set; }
       public bool Debit { get; set; }
        public bool Credit { get; set; }
        public bool ProfitandLoss { get; set; }
        public bool Budget { get; set; }
        
        public decimal   StandardValue { get; set; }
        public bool AcceptCostCenter { get; set; }
        public Int64 ParentId { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountsWithCentersCostsTable> AccountsWithCentersCostsTable { get; set; }
    }
}
