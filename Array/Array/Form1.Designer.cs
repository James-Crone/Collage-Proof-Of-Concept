namespace Array
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Allvalues = new System.Windows.Forms.Button();
            this.Maxvalue = new System.Windows.Forms.Button();
            this.Minvalue = new System.Windows.Forms.Button();
            this.Totalvalue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Example array:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Using loops, Properties and Methods";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(165, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 246);
            this.textBox1.TabIndex = 3;
            // 
            // Allvalues
            // 
            this.Allvalues.Location = new System.Drawing.Point(12, 158);
            this.Allvalues.Name = "Allvalues";
            this.Allvalues.Size = new System.Drawing.Size(135, 57);
            this.Allvalues.TabIndex = 4;
            this.Allvalues.Text = "All Values";
            this.Allvalues.UseVisualStyleBackColor = true;
            this.Allvalues.Click += new System.EventHandler(this.Allvalues_Click);
            // 
            // Maxvalue
            // 
            this.Maxvalue.Location = new System.Drawing.Point(12, 221);
            this.Maxvalue.Name = "Maxvalue";
            this.Maxvalue.Size = new System.Drawing.Size(135, 57);
            this.Maxvalue.TabIndex = 5;
            this.Maxvalue.Text = "Maxvalue";
            this.Maxvalue.UseVisualStyleBackColor = true;
            this.Maxvalue.Click += new System.EventHandler(this.Maxvalue_Click);
            // 
            // Minvalue
            // 
            this.Minvalue.Location = new System.Drawing.Point(12, 284);
            this.Minvalue.Name = "Minvalue";
            this.Minvalue.Size = new System.Drawing.Size(135, 57);
            this.Minvalue.TabIndex = 6;
            this.Minvalue.Text = "Min Value";
            this.Minvalue.UseVisualStyleBackColor = true;
            this.Minvalue.Click += new System.EventHandler(this.Minvalue_Click);
            // 
            // Totalvalue
            // 
            this.Totalvalue.Location = new System.Drawing.Point(12, 347);
            this.Totalvalue.Name = "Totalvalue";
            this.Totalvalue.Size = new System.Drawing.Size(135, 57);
            this.Totalvalue.TabIndex = 7;
            this.Totalvalue.Text = "Total";
            this.Totalvalue.UseVisualStyleBackColor = true;
            this.Totalvalue.Click += new System.EventHandler(this.Totalvalue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.Totalvalue);
            this.Controls.Add(this.Minvalue);
            this.Controls.Add(this.Maxvalue);
            this.Controls.Add(this.Allvalues);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Allvalues;
        private System.Windows.Forms.Button Maxvalue;
        private System.Windows.Forms.Button Minvalue;
        private System.Windows.Forms.Button Totalvalue;
    }
}

