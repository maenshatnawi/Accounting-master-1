using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
    public class Messages
    {
        public int MessageId { set; get; }
        public string MessageBody { set; get; }
        public string MessageSubject { set; get; }
        public string FromUser { set; get; }
        public string MessageIcon { set; get; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ToUserId { get; set; }
    }
}
