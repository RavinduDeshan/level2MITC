using MediCareApp.Models;
using MediCareApp.ServiceImpl;
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
    public partial class AddSchFinal : Form
    {
        String docId;
        String docName;
        String day;
        String time;

        DoctorServiceImpl service = new DoctorServiceImpl();
        ChannelingScheduleServiceImpl channellService = new ChannelingScheduleServiceImpl();

        public AddSchFinal()
        {
            InitializeComponent();
        }

        public AddSchFinal(String id)
        {
            InitializeComponent();
            this.docId = id;
            label10.Text = id;

            DataTable docDetails = service.getDoctorById(id);
            docName = "Dr. " + docDetails.Rows[0][1].ToString() + " " + docDetails.Rows[0][2].ToString() + " " + docDetails.Rows[0][3].ToString();
            label11.Text = docName;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddSchFinal_Load(object sender, EventArgs e)
        {

        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            String date = this.comboBox1.SelectedItem.ToString();
            String time = this.maskedTextBox1.Text;

            ChannelingSchedule obj = new ChannelingSchedule("0",docId,docName,time,date);
            bool result = channellService.addChannelingSchedule(obj);

            if (result)
            {
                MessageBox.Show("Schedule Added Successfully!", "Success!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else if (!result)
            {
                MessageBox.Show("Failed to add the Schedule", "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
