namespace MediCareApp
{
    partial class DoctorPatientList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPatientList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewMore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totPatientCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customImageButton5 = new imageButton.CustomImageButton();
            this.customImageButton1 = new imageButton.CustomImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.viewMore);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customImageButton5);
            this.panel1.Controls.Add(this.customImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 626);
            this.panel1.TabIndex = 0;
            // 
            // viewMore
            // 
            this.viewMore.BackColor = System.Drawing.Color.White;
            this.viewMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMore.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMore.ForeColor = System.Drawing.Color.ForestGreen;
            this.viewMore.Image = global::MediCareApp.Properties.Resources.view_more_24px;
            this.viewMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMore.Location = new System.Drawing.Point(576, 528);
            this.viewMore.Name = "viewMore";
            this.viewMore.Size = new System.Drawing.Size(194, 56);
            this.viewMore.TabIndex = 17;
            this.viewMore.Text = "View Patient";
            this.viewMore.UseVisualStyleBackColor = false;
            this.viewMore.Click += new System.EventHandler(this.viewMore_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.totPatientCountLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(576, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 99);
            this.panel2.TabIndex = 15;
            // 
            // totPatientCountLabel
            // 
            this.totPatientCountLabel.AutoSize = true;
            this.totPatientCountLabel.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totPatientCountLabel.ForeColor = System.Drawing.Color.Transparent;
            this.totPatientCountLabel.Location = new System.Drawing.Point(65, 46);
            this.totPatientCountLabel.Name = "totPatientCountLabel";
            this.totPatientCountLabel.Size = new System.Drawing.Size(60, 36);
            this.totPatientCountLabel.TabIndex = 0;
            this.totPatientCountLabel.Text = "340";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Patients Treated";
            // 
            // customImageButton5
            // 
            this.customImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customImageButton5.Image = global::MediCareApp.Properties.Resources.exit_sign_100pxdef;
            this.customImageButton5.ImageDefault = global::MediCareApp.Properties.Resources.exit_sign_100pxdef;
            this.customImageButton5.ImageHover = global::MediCareApp.Properties.Resources.exit_sign_100px;
            this.customImageButton5.Location = new System.Drawing.Point(760, 22);
            this.customImageButton5.Name = "customImageButton5";
            this.customImageButton5.Size = new System.Drawing.Size(28, 27);
            this.customImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton5.TabIndex = 12;
            this.customImageButton5.TabStop = false;
            // 
            // customImageButton1
            // 
            this.customImageButton1.Image = global::MediCareApp.Properties.Resources.fever_200pxdef;
            this.customImageButton1.ImageDefault = global::MediCareApp.Properties.Resources.fever_200pxdef;
            this.customImageButton1.ImageHover = global::MediCareApp.Properties.Resources.fever_200pxdef;
            this.customImageButton1.Location = new System.Drawing.Point(26, 30);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(96, 88);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton1.TabIndex = 13;
            this.customImageButton1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 79);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DoctorPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 626);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorPatientList";
            this.Text = "Doctor Portal- Patient List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private imageButton.CustomImageButton customImageButton5;
        private imageButton.CustomImageButton customImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totPatientCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button viewMore;
    }
}