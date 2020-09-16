using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class ChannelingSchedule : OpdShedule
    {
        public ChannelingSchedule(string id, string doctorId, string doctorName, string queid, string time , string date) : base(id, doctorId, doctorName, queid, time)
        {
        }
    }
}
