using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class Specialist : Doctor
    {

        private string specialization;

        public Specialist(string id, string firstName, string lastName, string middleName, string tel, string email, string qualification, string gender, string nic, string passoword,string specialization) : base(id, firstName, lastName, middleName, tel, email, qualification, gender, nic, passoword)
        {

            this.specialization = specialization;
        }
    }
}
