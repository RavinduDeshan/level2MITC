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
        protected string queid;
        protected string time;

        public OpdShedule(string id, string doctorId, string doctorName, string queid, string time)
        {
            this.id = id;
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.queid = queid;
            this.time = time;
        }

        public string ID { get => id; set => id = value; }
        public string DoctorId { get => doctorId; set => doctorId = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string Queid { get => queid; set => queid = value; }
        public string Time { get => time; set => time = value; }

    }


}
