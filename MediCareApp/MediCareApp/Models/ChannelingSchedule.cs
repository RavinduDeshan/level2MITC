using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class ChannelingSchedule : OpdShedule
    {
        protected string date;
        public ChannelingSchedule(string id,string doctorId, string doctorName, string time , string date) : base(id,doctorId, doctorName, time)
        {
            this.date = date;
        }

        public string Date { get => time; set => time = value; }

    }
}
