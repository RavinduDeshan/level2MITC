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
    class ChannelingScheduleServiceImpl : ChannelingSheduleService
    {
        MySqlConnection con = new DBclass().getConnection();
        public bool addChannelingSchedule(ChannelingSchedule CS)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("addChannelingSchedule", this.con);

            mysqlcommand.CommandType = CommandType.StoredProcedure;

            mysqlcommand.Parameters.AddWithValue("_doctorid", CS.DoctorId);
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

        public bool deleteChannelingSchedule(ChannelingSchedule CS)
        {
            throw new NotImplementedException();
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
    }

        
        }
    
