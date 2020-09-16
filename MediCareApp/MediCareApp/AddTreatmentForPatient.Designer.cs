namespace MediCareApp
{
    partial class AddTreatmentForPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTreatmentForPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TreatmentNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.illnessText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customImageButton5 = new imageButton.CustomImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TreatmentNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.illnessText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.customImageButton5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 543);
            this.panel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(345, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 47);
            this.button3.TabIndex = 57;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "Treatment Note";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TreatmentNote
            // 
            this.TreatmentNote.Location = new System.Drawing.Point(278, 177);
            this.TreatmentNote.Multiline = true;
            this.TreatmentNote.Name = "TreatmentNote";
            this.TreatmentNote.Size = new System.Drawing.Size(482, 240);
            this.TreatmentNote.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Illness";
            // 
            // illnessText
            // 
            this.illnessText.Location = new System.Drawing.Point(278, 113);
            this.illnessText.Name = "illnessText";
            this.illnessText.Size = new System.Drawing.Size(482, 20);
            this.illnessText.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Image = global::MediCareApp.Properties.Resources.view_more_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(564, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customImageButton5
            // 
            this.customImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customImageButton5.Image = global::MediCareApp.Properties.Resources.exit_sign_100pxdef;
            this.customImageButton5.ImageDefault = global::MediCareApp.Properties.Resources.exit_sign_100pxdef;
            this.customImageButton5.ImageHover = global::MediCareApp.Properties.Resources.exit_sign_100px;
            this.customImageButton5.Location = new System.Drawing.Point(868, 12);
            this.customImageButton5.Name = "customImageButton5";
            this.customImageButton5.Size = new System.Drawing.Size(28, 27);
            this.customImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton5.TabIndex = 12;
            this.customImageButton5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Prescription";
            // 
            // AddTreatmentForPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddTreatmentForPatient";
            this.Text = "Add Treatment For Patient";
            this.Load += new System.EventHandler(this.AddTreatmentForPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TreatmentNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox illnessText;
        private System.Windows.Forms.Button button1;
        private imageButton.CustomImageButton customImageButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}