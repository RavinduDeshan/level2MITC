using MediCareApp.Models;
using MediCareApp.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediCareApp.Database;

namespace MediCareApp.ServiceImpl
{
    class DoctorServiceImpl : DoctorService
    {
        MySqlConnection con = new DBclass().getConnection();
        public bool addDoctor(Doctor D)
        {
            throw new NotImplementedException();

        }

        public DataTable getAllSpecialistDoctors()
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getAllSpecialistDoctors", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                data.Fill(table);

                return table;

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Load Doctor Data, Please Re-Try By Closing and opening the Admin Portal again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return null;
        }

        public DataTable getDoctorByName(String name)
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("SheduleSearch", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("_searchString", name);
                DataTable table = new DataTable();
                data.Fill(table);

                return table;

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Load Doctor Data, Please Re-Try By Closing and opening the Admin Portal again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return null;

        }

        public DataTable getDoctorById(String id)
        {
            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter("getSpecialistDoctorbyId", this.con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("_id", id);
                DataTable table = new DataTable();
                data.Fill(table);

                return table;

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection Error Ocuured During Load Doctor Data, Please Re-Try By Closing and opening the Admin Portal again!", "Connection Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

            return null;

        }

        public bool deleteDoctor(string docID)
        {
            throw new NotImplementedException();
        }
    }
}
