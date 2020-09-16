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
    public partial class ChooseDoctorType : Form
    {
        public ChooseDoctorType()
        {
            InitializeComponent();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            new OPDDoctorLogin().Show();
            this.Dispose();
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            new ChannelingDoctorLogin().Show();
            this.Dispose();
        }
    }
}
