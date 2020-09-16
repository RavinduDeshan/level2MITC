using MediCareApp.Database;
using MediCareApp.Models;
using MediCareApp.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCareApp.ServiceImpl
{
    class specialistServiceImpl : specialistService
    {

        MySqlConnection con = new DBclass().getConnection();

        public string getIdByNIC(string nic)
        {
            MessageBox.Show("NIC Passing is "+ nic);

            MySqlDataAdapter data = new MySqlDataAdapter("getIDbyNICSpecialist", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_nic", nic);
            DataTable table = new DataTable();
            data.Fill(table);

            return table.Rows[0][0].ToString();

        }

        public bool validateUser(string Username, string password)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("getSpecialDoctorPassword", this.con);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.AddWithValue("_nic", Username);
            DataTable table = new DataTable();
            data.Fill(table);


            



            if (table.Rows.Count > 0)
            {


                if (table.Rows[0][0].ToString() == password)
                {




                    MySqlCommand mysqlcommand = new MySqlCommand("setSpecialDoctorSignedIn", this.con);
                    mysqlcommand.CommandType = CommandType.StoredProcedure;
                    mysqlcommand.Parameters.AddWithValue("_nic", Username);



                    return true;




                    
                   


               

                }
                else
                {
                    return false;
                }
               
            }
            else
            {
                return false;
            }
        }
    }
}
