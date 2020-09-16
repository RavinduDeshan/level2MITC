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
    public partial class FormDocLabReports : Form
    {
        public FormDocLabReports()
        {
            InitializeComponent();
        }

        private void customImageButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newform = new LabReportView();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form labass = new LabAssistantHome();
            labass.Show();
        }
    }
}
