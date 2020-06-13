using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class vmDashboard
    {
        public List<User> Username { get; set; }
        public List<Messages> vmMessagesIN { get; set; }
        public List<Messages> vmMessagesOUT { get; set; }
        public List<User> vmUser { get; set; }

    }
}
