using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class Patient
    {
        string id;
        string fname;
        string mname;
        string lname;
        string tel;
        string email;
        string address;
        string dateofbirth;
        string nic;
        string gender;

        public Patient(string id, string fname, string mname, string lname, string tel, string email, string address, string dob, string nic, string gender)
        {
            this.id = id;
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
            this.tel = tel;
            this.email = email;
            this.address = address;
            this.dateofbirth = dob ;
            this.nic = nic;
            this.gender = gender;
        }



        public string ID { get => id; set => id = value; }
        public string FirstName { get => fname; set => fname = value; }
        public string LastName { get => lname; set =>lname = value; }
        public string MiddleName { get => mname; set => mname = value; }
      
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string dob { get => dateofbirth; set => dateofbirth = value; }
        public string NIC { get => nic; set => nic = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
