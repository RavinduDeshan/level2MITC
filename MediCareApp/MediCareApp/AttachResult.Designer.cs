namespace MediCareApp
{
    partial class AttachResult
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customImageButton3 = new imageButton.CustomImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 131);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.15126F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report PDF URL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(180, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 51);
            this.button1.TabIndex = 52;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(411, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 51);
            this.button2.TabIndex = 53;
            this.button2.Text = "Attach";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // customImageButton3
            // 
            this.customImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customImageButton3.Image = global::MediCareApp.Properties.Resources.medical_history_60pxdef;
            this.customImageButton3.ImageDefault = global::MediCareApp.Properties.Resources.medical_history_60pxdef;
            this.customImageButton3.ImageHover = global::MediCareApp.Properties.Resources.medical_history_60px;
            this.customImageButton3.Location = new System.Drawing.Point(479, 54);
            this.customImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.customImageButton3.Name = "customImageButton3";
            this.customImageButton3.Size = new System.Drawing.Size(110, 55);
            this.customImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton3.TabIndex = 54;
            this.customImageButton3.TabStop = false;
            // 
            // AttachResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 447);
            this.Controls.Add(this.customImageButton3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AttachResult";
            this.Text = "AttachResult";
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private imageButton.CustomImageButton customImageButton3;
    }
}