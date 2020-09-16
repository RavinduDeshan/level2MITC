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
using System.Windows.Forms;

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

        public int getAllPatientCount()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("getAllPatientCount", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            int val;
            try
            {
                val = Convert.ToInt32(table.Rows[0][0]) + 0;

            }
            catch (InvalidCastException e)
            {
                return 0;
            }

            return val;
        }

        public Patient getAsinglePatient(string id)
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getPatientbyId", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("_patientid", id);
                DataTable table = new DataTable();
                data.Fill(table);

                return new Patient(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), table.Rows[0][4].ToString(), table.Rows[0][5].ToString(), table.Rows[0][6].ToString(), table.Rows[0][7].ToString(), table.Rows[0][8].ToString(), table.Rows[0][9].ToString());

            }
            catch (MySqlException error2)
            {
                MessageBox.Show("Connection Error Ocuured During Load Patient Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            return null;
        }

        public DataTable getpatientList()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("getAllPatients", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public bool updatePatient()
        {
            throw new NotImplementedException();
        }
    }
}
