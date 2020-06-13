using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
   public class CentersCostsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentersCostsTable()
        {


            this.AccountsWithCentersCostsTable = new HashSet<AccountsWithCentersCostsTable>();
        }

        public Int64 ID { get; set; }
        public Int64 CentersCostsNo { get; set; }
        public string CentersCostsName { get; set; }
        public Int64 ParentId { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountsWithCentersCostsTable> AccountsWithCentersCostsTable { get; set; }
    }
}
