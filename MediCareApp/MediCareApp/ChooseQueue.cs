﻿using System;
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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            new OPDDoctorLogin().Show();
            this.Dispose();
        }
    }
}
