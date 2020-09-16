using MediCareApp.Database;
using MediCareApp.Models;
using MediCareApp.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.ServiceImpl
{
    class PrescriptionServiceImpl : prescriptionsService
    {
        MySqlConnection con = new DBclass().getConnection();

        public bool AddPrescription(Prescription p)


        {

            DateTime thisDay = DateTime.Today;

            MySqlCommand mysqlcommand = new MySqlCommand("addPrescription", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_doctorId", p.DocId);
            mysqlcommand.Parameters.AddWithValue("_doctorName", p.DocName);
            mysqlcommand.Parameters.AddWithValue("_patientId", p.PatientID);
            mysqlcommand.Parameters.AddWithValue("_patientName", p.PatientName);
            mysqlcommand.Parameters.AddWithValue("_illness", p.Illness);
            mysqlcommand.Parameters.AddWithValue("_treatment", p.Treatment);
            mysqlcommand.Parameters.AddWithValue("_date", thisDay.ToString("d"));

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        public DataTable getPrescriptionByPAtient(string Pid)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("getallprescriptionByPatientId", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_pid", Pid);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }
    }
}
