namespace MediCareApp
{
    partial class AddSchSelectDoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.viewMore = new System.Windows.Forms.Button();
            this.customImageButton2 = new imageButton.CustomImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 73);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Doctor :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
            this.dataGridView1.TabIndex = 40;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(454, 147);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(236, 31);
            this.maskedTextBox1.TabIndex = 39;
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
            this.viewMore.Location = new System.Drawing.Point(552, 358);
            this.viewMore.Name = "viewMore";
            this.viewMore.Size = new System.Drawing.Size(179, 37);
            this.viewMore.TabIndex = 41;
            this.viewMore.Text = "Select Doctor";
            this.viewMore.UseVisualStyleBackColor = false;
            // 
            // customImageButton2
            // 
            this.customImageButton2.Image = global::MediCareApp.Properties.Resources.searchIcon30pxdef;
            this.customImageButton2.ImageDefault = global::MediCareApp.Properties.Resources.searchIcon30pxdef;
            this.customImageButton2.ImageHover = global::MediCareApp.Properties.Resources.searchIcon30px;
            this.customImageButton2.Location = new System.Drawing.Point(696, 143);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(35, 35);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton2.TabIndex = 38;
            this.customImageButton2.TabStop = false;
            // 
            // AddSchSelectDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewMore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.customImageButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSchSelectDoc";
            this.Text = "AddSchSelectDoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewMore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private imageButton.CustomImageButton customImageButton2;
    }
}