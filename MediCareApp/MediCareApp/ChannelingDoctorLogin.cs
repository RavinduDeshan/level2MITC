﻿using MediCareApp.Models;
using MediCareApp.ServiceImpl;
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
    public partial class ChannelingDoctorLogin : Form
    {

        specialistServiceImpl serv = new specialistServiceImpl();

        
        public ChannelingDoctorLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           if (serv.validateUser(CDLusername.Text, CDLPass.Text))
            {
                MessageBox.Show("Doctor Validated Successfully!","Validated!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Dispose();

                string nic = CDLusername.Text.ToString();

                
                new DoctorHome("981570901V").Show();
                

            }
            else
            {
                MessageBox.Show("Invalid Credentials, Re-Try", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backmenue_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
