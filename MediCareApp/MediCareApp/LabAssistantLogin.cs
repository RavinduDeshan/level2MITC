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
    public partial class LabAssistantLogin : Form
    {
        public LabAssistantLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "lab123" && this.textBox2.Text == "123")
            {
                Form newform = new LabAssistantHome();
                newform.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
