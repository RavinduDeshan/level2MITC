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
        public DoctorPatientList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewMore_Click(object sender, EventArgs e)
        {
            Form newform = new DoctorSinglePatient();
            newform.Show();
        }
    }
}
