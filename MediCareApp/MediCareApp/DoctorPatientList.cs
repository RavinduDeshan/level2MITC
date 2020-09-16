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
        String userame;

        PatientServicesImpl serv = new PatientServicesImpl();
        public DoctorPatientList()
        {
            InitializeComponent();
            setLabels();
        }

        public DoctorPatientList(string DocUsername)
        {
            InitializeComponent();
            setLabels();
            this.userame = DocUsername;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            if (gridPatient.CurrentCell.ColumnIndex > 0)
            {
                MessageBox.Show("Please Select the Relevent Patient ID", "Select an Patient ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else
            {
                string empID = gridPatient.CurrentCell.Value.ToString();
                new DoctorSinglePatient(serv.getAsinglePatient(empID),"981570901V").Show();
            }
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
