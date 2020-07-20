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
        public DoctorHome()
        {
            InitializeComponent();
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
    }
}
