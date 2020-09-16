using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class OpdShedule
    {

        protected string id;
        protected string doctorId;
        protected string doctorName;
        protected string time;

        public OpdShedule(string id, string doctorId, string doctorName, string time)
        {
            this.id = id;
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.time = time;
        }

        public string ID { get => id; set => id = value; }
        public string DoctorId { get => doctorId; set => doctorId = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string Time { get => time; set => time = value; }

    }


}
