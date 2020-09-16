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

        public DataTable getAllSchedules()
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getAllOpdSchedules", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                data.Fill(table);

                return table;

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Load Schedule Data, Please Re-Try By Closing and opening the Admin Portal again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return null;
        }
    }
}
        
