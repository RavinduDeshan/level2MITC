using MediCareApp.Models;
using MediCareApp.Services;
using MediCareApp.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MediCareApp.ServiceImpl
{
    class QueueServiceImpl : QueueService
    {
        MySqlConnection con = new DBclass().getConnection();
        public bool addToQueue(Queue q)
        {
            MySqlCommand mysqlcommand = new MySqlCommand("addToQueue", this.con);

            mysqlcommand.CommandType = CommandType.StoredProcedure;

            mysqlcommand.Parameters.AddWithValue("_size", q.Size);
            mysqlcommand.Parameters.AddWithValue("_currentNumber", q.CurrentNumber);
            mysqlcommand.Parameters.AddWithValue("_sheduleid", q.SheduleId);
            mysqlcommand.Parameters.AddWithValue("_maxsize", q.MaxSize);
            mysqlcommand.Parameters.AddWithValue("_date", q.Date);


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
