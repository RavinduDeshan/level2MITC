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
    public partial class patientSearch : Form
    {
        public patientSearch()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newform = new RegisterPatient();
            newform.Show();
        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            Form newform = new Choose();
            newform.Show();
        }
    }
}
