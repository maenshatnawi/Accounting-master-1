using System;
 
namespace POCO
{
    public class MessageUsers
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public int ToUserId { get; set; }
        public int FromUserId { get; set; }


    }
}
