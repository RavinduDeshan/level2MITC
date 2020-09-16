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
    class ChannelingScheduleServiceImpl : ChannelingSheduleService
    {
        MySqlConnection con = new DBclass().getConnection();
        public bool addChannelingSchedule(ChannelingSchedule CS)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("addChannelingSchedule", this.con);

            mysqlcommand.CommandType = CommandType.StoredProcedure;

            mysqlcommand.Parameters.AddWithValue("_doctorid", CS.DoctorId);
            mysqlcommand.Parameters.AddWithValue("_doctorName", CS.DoctorName);
            mysqlcommand.Parameters.AddWithValue("_day", CS.Date);
            mysqlcommand.Parameters.AddWithValue("_time", CS.Time);


            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        public bool deleteChannelingSchedule(String id)
        {

            try
            {
                MySqlCommand mysqlcommand = new MySqlCommand("deleteChannelingSchedule", this.con);
                mysqlcommand.CommandType = CommandType.StoredProcedure;
                mysqlcommand.Parameters.AddWithValue("_id", id);

                if (mysqlcommand.ExecuteNonQuery() >= 1)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Deleting Schedule Data, Please Re-Try again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return false;
        }

        public bool updateChannelingSchedule(ChannelingSchedule CS)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("addChannelingSchedule", this.con);
            mysqlcommand.CommandType = CommandType.StoredProcedure;
            // throw new NotImplementedException();mysqlcommand.Parameters.AddWithValue("_doctorid", CS.DoctorId);
            mysqlcommand.Parameters.AddWithValue("_doctorName", CS.DoctorName);
            //mysqlcommand.Parameters.AddWithValue("_day", CS.Day);
            mysqlcommand.Parameters.AddWithValue("_time", CS.Time);

            if (mysqlcommand.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {

                return false;
            }

        }

        public DataTable getAllChannelingSchedules()
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getAllChannelingSchedules", this.con);
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

        public bool deleteChannelingSchedule(ChannelingSchedule CS)
        {
            throw new NotImplementedException();
        }

        public DataTable getScheduleById(String id)
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getAllChannelingSchedules", this.con);
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

        
        
    
