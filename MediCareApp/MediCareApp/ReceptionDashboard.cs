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
            newform.Show();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Form newform = new patientSearch();
            newform.Show();
        }

        private void ReciptionDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
