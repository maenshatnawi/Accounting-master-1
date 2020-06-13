using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string PermissionState { get; set; }
        public string PermissionRelated { get; set; }
        public int Collection_ID { get; set; }
        public string CollectionName { get; set; }
        public int PermissionNumber { get; set; }

    }
}
