
namespace WindowsFormsApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1Fname = new System.Windows.Forms.TextBox();
            this.textBox2Lname = new System.Windows.Forms.TextBox();
            this.label4Fname = new System.Windows.Forms.Label();
            this.label5Lname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSmileface = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display UserName";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter first and last name below then use the\r\n button to display your username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1Fname
            // 
            this.textBox1Fname.Location = new System.Drawing.Point(102, 155);
            this.textBox1Fname.Name = "textBox1Fname";
            this.textBox1Fname.Size = new System.Drawing.Size(158, 20);
            this.textBox1Fname.TabIndex = 5;
            this.textBox1Fname.TextChanged += new System.EventHandler(this.textBox1Fname_TextChanged);
            // 
            // textBox2Lname
            // 
            this.textBox2Lname.Location = new System.Drawing.Point(102, 203);
            this.textBox2Lname.Name = "textBox2Lname";
            this.textBox2Lname.Size = new System.Drawing.Size(158, 20);
            this.textBox2Lname.TabIndex = 6;
            this.textBox2Lname.TextChanged += new System.EventHandler(this.textBox2Lname_TextChanged);
            // 
            // label4Fname
            // 
            this.label4Fname.AutoSize = true;
            this.label4Fname.Location = new System.Drawing.Point(30, 155);
            this.label4Fname.Name = "label4Fname";
            this.label4Fname.Size = new System.Drawing.Size(60, 13);
            this.label4Fname.TabIndex = 7;
            this.label4Fname.Text = "First Name:";
            this.label4Fname.Click += new System.EventHandler(this.label4Fname_Click);
            // 
            // label5Lname
            // 
            this.label5Lname.AutoSize = true;
            this.label5Lname.Location = new System.Drawing.Point(29, 206);
            this.label5Lname.Name = "label5Lname";
            this.label5Lname.Size = new System.Drawing.Size(61, 13);
            this.label5Lname.TabIndex = 8;
            this.label5Lname.Text = "Last Name:";
            this.label5Lname.Click += new System.EventHandler(this.label5Lname_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "_________________________________________";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSmileface
            // 
            this.labelSmileface.AutoSize = true;
            this.labelSmileface.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmileface.Location = new System.Drawing.Point(106, 113);
            this.labelSmileface.Name = "labelSmileface";
            this.labelSmileface.Size = new System.Drawing.Size(0, 18);
            this.labelSmileface.TabIndex = 10;
            this.labelSmileface.Click += new System.EventHandler(this.labelSmileface_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.Screenshot__20_;
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 329);
            this.Controls.Add(this.labelSmileface);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5Lname);
            this.Controls.Add(this.label4Fname);
            this.Controls.Add(this.textBox2Lname);
            this.Controls.Add(this.textBox1Fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "label1 User input";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1Fname;
        private System.Windows.Forms.TextBox textBox2Lname;
        private System.Windows.Forms.Label label4Fname;
        private System.Windows.Forms.Label label5Lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSmileface;
    }
}

