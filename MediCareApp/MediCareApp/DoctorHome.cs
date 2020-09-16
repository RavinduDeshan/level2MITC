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
    public partial class DoctorHome : Form
    {
        int count;
        string nic;
        PatientServicesImpl serv = new PatientServicesImpl();
        public DoctorHome()
        {
            InitializeComponent();
            //setLabels();
        }

        public DoctorHome(string nic, int validator)
        {
            InitializeComponent();

            this.nic = nic;

            setLabels();




        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void allPrescribtionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Form newform = new DoctorPatientList();
            newform.Show();
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            FormDocLabReports docLabReports = new FormDocLabReports();
            docLabReports.ShowDialog();
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            FormDocQueue docQueue = new FormDocQueue();
            docQueue.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new ReciptionDashboard();
            newform.Show();
        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {

        }

        public void setLabels()
        {
            totPatientCountLabel.Text = serv.getAllPatientCount().ToString();
        }
    }
}
