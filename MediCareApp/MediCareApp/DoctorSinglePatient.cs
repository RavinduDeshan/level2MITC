using MediCareApp.Models;
using MediCareApp.ServiceImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCareApp
{
    public partial class DoctorSinglePatient : Form
    {
        PrescriptionServiceImpl srv = new PrescriptionServiceImpl();
        specialistServiceImpl srvDoc = new specialistServiceImpl();
        Patient p;
        string nic;
        public DoctorSinglePatient()
        {
            InitializeComponent();
        }

        public DoctorSinglePatient(Object POb, string DocNIC)
        {
            InitializeComponent();
            this.p = (Patient) POb;
            setLabels();
            this.nic = DocNIC;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void setLabels()
        {
            namePatient.Text = p.FirstName + " " + p.MiddleName + " " + p.LastName;
            nwiPatient.Text = p.FirstName[0] + " " + p.MiddleName[0] + " " + p.LastName;
            dobPatient.Text = p.dob;
            patientAddress.Text = p.Address;
            nicPatient.Text = p.NIC;
            IDPatient.Text = p.ID;

            gridPatient.DataSource = srv.getPrescriptionByPAtient(p.ID);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorSinglePatient_Load(object sender, EventArgs e)
        {

        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            new AddTreatmentForPatient(p, srvDoc.getIdByNIC("981570901V"), "981570901V").Show();
        }
    }
}
