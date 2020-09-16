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
        protected string tel;
        protected string email;
        protected string qualification;
        protected string gender;
        protected string nic;
        protected string passoword;

        public Doctor(string id, string firstName, string lastName, string middleName, string tel, string email, string qualification, string gender, string nic, string passoword)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.tel = tel;
            this.email = email;
            this.qualification = qualification;
            this.gender = gender;
            this.nic = nic;
            this.passoword = passoword;
        }


        public string ID { get => id; set => id = value; }
        public string Fname { get => firstName; set => firstName = value; }
        public string Lname { get => lastName; set => lastName = value; }
        public string Tel { get => tel; set => tel = value; }

        public string Email { get => email; set => email = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Nic { get => Nic; set => Nic = value; }
        public string Passoword { get => passoword; set => passoword = value; }
        
    }
}
