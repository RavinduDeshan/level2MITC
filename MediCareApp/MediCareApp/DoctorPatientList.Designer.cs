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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPatientList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.customImageButton2 = new imageButton.CustomImageButton();
            this.viewMore = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totPatientCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customImageButton1 = new imageButton.CustomImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPatient = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.gridPatient);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.customImageButton2);
            this.panel1.Controls.Add(this.viewMore);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 626);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Image = global::MediCareApp.Properties.Resources.refresh_26px;
            this.button1.Location = new System.Drawing.Point(514, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 56);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customImageButton2
            // 
            this.customImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton2.Image = global::MediCareApp.Properties.Resources.searchIcon30pxdef;
            this.customImageButton2.ImageDefault = global::MediCareApp.Properties.Resources.searchIcon30pxdef;
            this.customImageButton2.ImageHover = global::MediCareApp.Properties.Resources.searchIcon30px;
            this.customImageButton2.Location = new System.Drawing.Point(742, 78);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(35, 35);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton2.TabIndex = 31;
            this.customImageButton2.TabStop = false;
            // 
            // viewMore
            // 
            this.viewMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewMore.BackColor = System.Drawing.Color.White;
            this.viewMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMore.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMore.ForeColor = System.Drawing.Color.ForestGreen;
            this.viewMore.Image = global::MediCareApp.Properties.Resources.view_more_24px;
            this.viewMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMore.Location = new System.Drawing.Point(583, 509);
            this.viewMore.Name = "viewMore";
            this.viewMore.Size = new System.Drawing.Size(194, 56);
            this.viewMore.TabIndex = 17;
            this.viewMore.Text = "View Patient";
            this.viewMore.UseVisualStyleBackColor = false;
            this.viewMore.Click += new System.EventHandler(this.viewMore_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(525, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 26);
            this.textBox1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.totPatientCountLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(26, 485);
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
            // gridPatient
            // 
            this.gridPatient.AllowUserToAddRows = false;
            this.gridPatient.AllowUserToDeleteRows = false;
            this.gridPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPatient.BackgroundColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPatient.Location = new System.Drawing.Point(23, 151);
            this.gridPatient.Margin = new System.Windows.Forms.Padding(2);
            this.gridPatient.MultiSelect = false;
            this.gridPatient.Name = "gridPatient";
            this.gridPatient.ReadOnly = true;
            this.gridPatient.RowHeadersWidth = 51;
            this.gridPatient.RowTemplate.Height = 24;
            this.gridPatient.Size = new System.Drawing.Size(765, 303);
            this.gridPatient.TabIndex = 34;
            // 
            // DoctorPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 626);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorPatientList";
            this.Text = "Doctor Portal- Patient List";
            this.Load += new System.EventHandler(this.DoctorPatientList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private imageButton.CustomImageButton customImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totPatientCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button viewMore;
        private imageButton.CustomImageButton customImageButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridPatient;
    }
}