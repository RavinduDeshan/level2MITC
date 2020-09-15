using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class Doctor
    {
        protected string id;
        protected string firstName;
        protected string lastName;
        protected string middleName;
        protected string specialization;
        protected string tel;
        protected string email;
        protected string qualification;
        protected string gender;

        public Doctor(string id, string firstName, string lastName, string middleName,string tel, string email, string qualification, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.tel = tel;
            this.email = email;
            this.qualification = qualification;
            this.gender = gender;
        }

        
        public string ID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Gender { get => gender; set => gender = value; }
       
    }
}
