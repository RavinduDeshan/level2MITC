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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Form newform = new DoctorLogin();
            newform.Show();
            

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            Form newform = new ReceptionistLogin();
            newform.Show();
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            Form newform = new LabAssistantLogin();
            newform.Show();
        }

        private void customImageButton4_Click(object sender, EventArgs e)
        {
            Form newform = new AdminLogin();
            newform.Show();
        }
    }
}
