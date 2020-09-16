using MediCareApp.Database;
using MediCareApp.ServiceImpl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCareApp
{
    public partial class Scheduling : Form
    {
        ChannelingScheduleServiceImpl scheduleService1 = new ChannelingScheduleServiceImpl();
        OpdSheduleServiceImpl scheduleService2 = new OpdSheduleServiceImpl();

        public Scheduling()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = scheduleService1.getAllChannelingSchedules();
            this.dataGridView2.DataSource = scheduleService2.getAllSchedules();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void Scheduling_Load(object sender, EventArgs e)
        {

        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            AddSchSelectDoc obj = new AddSchSelectDoc();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Schedule ID of the Relevent Schedule", "Select an Schedule ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string scheduleID = dataGridView1.CurrentCell.Value.ToString();
                Console.WriteLine("id " + scheduleID);
                bool result = scheduleService1.deleteChannelingSchedule(scheduleID);

                if (result)
                {
                    MessageBox.Show("Schedule removed Successfully", "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
                else if (!result)
                {
                    MessageBox.Show("Failed to delete the schedule", "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }

                
            }
        }
    }
}
