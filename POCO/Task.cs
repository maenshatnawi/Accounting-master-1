using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
   public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Status> Status { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ToUserId { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }

    }
  
}
