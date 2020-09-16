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
    public partial class DoctorPatientList : Form
    {

        PatientServicesImpl serv = new PatientServicesImpl();
        public DoctorPatientList()
        {
            InitializeComponent();
            setLabels();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            Form newform = new DoctorSinglePatient();
            newform.Show();
        }

        private void DoctorPatientList_Load(object sender, EventArgs e)
        {

        }

        public void setLabels()
        {
            totPatientCountLabel.Text = serv.getAllPatientCount().ToString();
            gridPatient.DataSource = serv.getpatientList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setLabels();
        }
    }
}
