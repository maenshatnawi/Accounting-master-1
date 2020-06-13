using System;
using System.Collections.Generic;
 using System.Text;

namespace POCO
{
    public class Message
    {
        public int MessageId { set; get; }
        ////[Display(Name = "Message")]
        //[Required]
        public string MessageBody { set; get; }
        //[Required]
        ////[Display(Name = "From")]
        public string FromUser { set; get; }
        ////[Display(Name = "Select an Icon")]
        public string MessageIcon { set; get; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}
