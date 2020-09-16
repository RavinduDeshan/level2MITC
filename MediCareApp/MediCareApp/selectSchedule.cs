using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediCareApp.Models;
using MediCareApp.ServiceImpl;

namespace MediCareApp
{
    public partial class selectSchedule : Form
    {
        ChannelingScheduleServiceImpl obj = new ChannelingScheduleServiceImpl();
        QueueServiceImpl service = new QueueServiceImpl();

        Patient p;
        public selectSchedule()
        {
            InitializeComponent();
            
        }
        public selectSchedule(Object kakki)
        {
            InitializeComponent();
            this.p = (Patient)kakki;
            this.dataGridView1.DataSource = obj.getAllChannelingSchedules();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectSchedule_Load(object sender, EventArgs e)
        {

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            this.dataGridView1.DataSource = obj.getScheduleById(id);
        }

        private void viewMore_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Schedule ID of the Relevent Schedule", "Select a Schedule",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string ID = dataGridView1.CurrentCell.Value.ToString();
                Console.WriteLine("id " + ID);
                Queue qobj = new Queue("0", 1, 1, ID, 50, "2020-09-18");
                bool result= service.addToQueue(qobj);

                if (result)
                {
                    ChannelingDetails details = new ChannelingDetails(p,qobj);
                    details.Show();
                }
                else if (!result)
                {
                    MessageBox.Show("Failed to add to queue", "Error!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                }

               

                //new Section1_viewLecturer(Lservice.getSingleLecturer(empID)).Show();
            }
        }
    }
}
