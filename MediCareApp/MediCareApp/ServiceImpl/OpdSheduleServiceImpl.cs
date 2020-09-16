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
    class OpdSheduleServiceImpl : opdsheduleService
    {
        MySqlConnection con = new DBclass().getConnection(); 

       

        public bool UpdateOPDShedule(OpdShedule OS)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("updateOPDShedule", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            mysqlcommand.Parameters.AddWithValue("_doctorid", OS.DoctorId);
            mysqlcommand.Parameters.AddWithValue("_doctorName", OS.DoctorName);
            mysqlcommand.Parameters.AddWithValue("_time", OS.Time);
            
            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
        
