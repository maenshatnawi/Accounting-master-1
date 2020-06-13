
using System;
 
namespace POCO
{
    public class MessageUsers
    {
        public int Id { get; set; }
        public int ToUserId { get; set; }
        public int FromUserId { get; set; }
        public int MessageId { get; set; }
        ////[Display(Name = "Message Content")]
        public string MessageBody { get; set; }

        ////[Display(Name = "From")]
        public string FromUser { get; set; }

        //[Display(Name = "Icon")]
        public string MessageIcon { get; set; }

        //[Display(Name = "From Date")]
        public DateTime FromDate { get; set; }

        //[Display(Name = "To Date")]
        public DateTime ToDate { get; set; }

        //[Display(Name = "To")]
        public string FirstName { get; set; }
        public string LastName{ get; set; }


    }
}
