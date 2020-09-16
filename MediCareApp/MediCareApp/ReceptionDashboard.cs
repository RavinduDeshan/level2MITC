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
    public partial class ReciptionDashboard : Form
    {
        public ReciptionDashboard()
        {
            InitializeComponent();
        }

        private void oPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new RegisterPatient();
            Dispose();
            newform.Show();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Form newform = new patientSearch();
            Dispose();
            newform.Show();
        }

        private void ReciptionDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            Scheduling obj = new Scheduling();
            obj.Show();
        }
    }
}
