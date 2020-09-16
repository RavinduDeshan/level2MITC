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
    public partial class AddTreatmentForPatient : Form
    {
        PrescriptionServiceImpl srv = new PrescriptionServiceImpl();
        string docname, docid;
        Patient p;
        public AddTreatmentForPatient()
        {
            InitializeComponent();
        }

        public AddTreatmentForPatient(Object Patient,string docid,string docname)
        {
            InitializeComponent();
            this.docid = docid;
            this.docname = docname;
            this.p = (Patient) Patient;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AddTreatmentForPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (srv.AddPrescription(new Prescription("0", docid, docname, p.ID, (p.FirstName + " " + p.LastName), illnessText.Text, TreatmentNote.Text, "2020/09/18"))) 
            {
                MessageBox.Show("Sucessfully Submitted!","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Dispose();
            }
            else
            {
                MessageBox.Show("Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
