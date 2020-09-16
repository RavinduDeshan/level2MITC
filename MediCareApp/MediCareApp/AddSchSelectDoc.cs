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
    public partial class AddSchSelectDoc : Form
    {
        DoctorServiceImpl doctorService = new DoctorServiceImpl();
        public AddSchSelectDoc()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = doctorService.getAllSpecialistDoctors();
        }

        private void AddSchSelectDoc_Load(object sender, EventArgs e)
        {

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            String docName = this.textBox1.Text;
            this.dataGridView1.DataSource = doctorService.getDoctorByName(docName);

        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Doctor ID of the Relevent Doctor", "Select an Doctor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string empID = dataGridView1.CurrentCell.Value.ToString();
                Console.WriteLine("id " +empID);
                AddSchFinal obj = new AddSchFinal(empID);
                obj.Show();

                //new Section1_viewLecturer(Lservice.getSingleLecturer(empID)).Show();
            }
        }
    }
}
