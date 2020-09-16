using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediCareApp.Models;
using MediCareApp.Services;
using MediCareApp.Database;
using System.Data;


namespace MediCareApp.ServiceImpl
{
    class PatientServicesImpl : PatientServices
    {
        MySqlConnection con = new DBclass().getConnection();


        public bool AddPatient(Patient P)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("AddPatient", this.con);
 
            mysqlcommand.CommandType = CommandType.StoredProcedure;
       
          mysqlcommand.Parameters.AddWithValue("_fname", P.FirstName);
            mysqlcommand.Parameters.AddWithValue("_mname", P.MiddleName);
           mysqlcommand.Parameters.AddWithValue("_lname", P.LastName);
            mysqlcommand.Parameters.AddWithValue("_tel", P.Tel);
            mysqlcommand.Parameters.AddWithValue("_email", P.Email);
            mysqlcommand.Parameters.AddWithValue("_dob", P.dob);
            mysqlcommand.Parameters.AddWithValue("_gender", P.Gender);
            mysqlcommand.Parameters.AddWithValue("_address", P.Address);
            mysqlcommand.Parameters.AddWithValue("_nic", P.NIC);

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        public int getAllPatientCount(Patient P)
        {
            throw new NotImplementedException();
        }

        public Patient getAsinglePatient(string id)
        {
            throw new NotImplementedException();
        }

        public bool getpatientList()
        {
            throw new NotImplementedException();
        }

        public bool updatePatient()
        {
            throw new NotImplementedException();
        }
    }
}
