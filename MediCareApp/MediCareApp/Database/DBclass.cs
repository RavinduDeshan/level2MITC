using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCareApp.Database
{
    class DBclass
    {

        private String conString = @"SERVER=medicareapp.mysql.database.azure.com;PORT=3306;DATABASE=medicare;UID=ravindu@medicareapp;PASSWORD=suranganavi17#";
       
        private MySqlConnection con;

        public MySqlConnection getConnection()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                this.con = con;
                this.con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Data Connection Error Occured");
            }
            return this.con;

        }
        public void closeConnection()
        {

            this.con.Close();


        }
    }
}
