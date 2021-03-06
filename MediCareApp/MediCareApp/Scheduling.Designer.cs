﻿namespace MediCareApp
{
    partial class Scheduling
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
            this.label1 = new System.Windows.Forms.Label();
            this.customImageButton1 = new imageButton.CustomImageButton();
            this.viewMore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.customImageButton2 = new imageButton.CustomImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "Scheduling";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customImageButton1
            // 
            this.customImageButton1.Image = global::MediCareApp.Properties.Resources.timesheet_128px;
            this.customImageButton1.ImageDefault = global::MediCareApp.Properties.Resources.fever_200pxdef;
            this.customImageButton1.ImageHover = global::MediCareApp.Properties.Resources.fever_200pxdef;
            this.customImageButton1.Location = new System.Drawing.Point(12, 12);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(96, 88);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton1.TabIndex = 15;
            this.customImageButton1.TabStop = false;
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
            this.viewMore.Location = new System.Drawing.Point(515, 357);
            this.viewMore.Name = "viewMore";
            this.viewMore.Size = new System.Drawing.Size(201, 37);
            this.viewMore.TabIndex = 41;
            this.viewMore.Text = "Add Schedule";
            this.viewMore.UseVisualStyleBackColor = false;
            this.viewMore.Click += new System.EventHandler(this.viewMore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 40;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(437, 146);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(236, 31);
            this.maskedTextBox1.TabIndex = 39;
            // 
            // customImageButton2
            // 
            this.customImageButton2.Image = global::MediCareApp.Properties.Resources.searchIcon30pxdef;
            this.customImageButton2.ImageDefault = global::MediCareApp.Properties.Resources.searchIcon30pxdef;
            this.customImageButton2.ImageHover = global::MediCareApp.Properties.Resources.searchIcon30px;
            this.customImageButton2.Location = new System.Drawing.Point(679, 143);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(35, 35);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton2.TabIndex = 38;
            this.customImageButton2.TabStop = false;
            this.customImageButton2.Click += new System.EventHandler(this.customImageButton2_Click);
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
            this.button1.Location = new System.Drawing.Point(63, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 37);
            this.button1.TabIndex = 42;
            this.button1.Text = "Delete Schedule";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Image = global::MediCareApp.Properties.Resources.view_more_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(289, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 37);
            this.button2.TabIndex = 43;
            this.button2.Text = "Update Schedule";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(159, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "OPD";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Image = global::MediCareApp.Properties.Resources.view_more_24px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(515, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 37);
            this.button3.TabIndex = 49;
            this.button3.Text = "Update Doctor";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(163, 464);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 75);
            this.dataGridView2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(159, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Channelling";
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewMore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.customImageButton2);
            this.Controls.Add(this.customImageButton1);
            this.Controls.Add(this.label1);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.Load += new System.EventHandler(this.Scheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imageButton.CustomImageButton customImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewMore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private imageButton.CustomImageButton customImageButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
    }
}