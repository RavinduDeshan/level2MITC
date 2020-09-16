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
    class LabReportsServiceImpl : LabReportService
    {


        MySqlConnection con = new DBclass().getConnection();


        public bool AddLabReport(LabReport LR)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("addLabReport", this.con);

            mysqlcommand.CommandType = CommandType.StoredProcedure;

            mysqlcommand.Parameters.AddWithValue("_description", LR.Descriptionm);
            mysqlcommand.Parameters.AddWithValue("_patientid", LR.patientId);
            mysqlcommand.Parameters.AddWithValue("_patientname", LR.patientName);
            mysqlcommand.Parameters.AddWithValue("_doctorid", LR.docId);
            mysqlcommand.Parameters.AddWithValue("_doctername", LR.docName);
            mysqlcommand.Parameters.AddWithValue("_createdate", LR.createdate);
            mysqlcommand.Parameters.AddWithValue("_completedate", LR.completedate);
            mysqlcommand.Parameters.AddWithValue("_type", LR.types);
            mysqlcommand.Parameters.AddWithValue("_status", LR.status);
            mysqlcommand.Parameters.AddWithValue("_labassistentid", LR.labAssistent);
            mysqlcommand.Parameters.AddWithValue("_labassistentname", LR.labAssistentname);
            mysqlcommand.Parameters.AddWithValue("_reporturl", LR.reportUrl);

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        

        public bool DeleteLabReport(LabReport LR)
        {
            throw new NotImplementedException();
        }

        

        public bool UpdateLabReport(LabReport LR)
        {
            throw new NotImplementedException();
        }
    }
}
        
    

