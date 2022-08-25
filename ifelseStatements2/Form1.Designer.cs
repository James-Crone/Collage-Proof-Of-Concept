
namespace ifelseStatements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Answerbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CorrectOrIncorrectlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Answerbox
            // 
            this.Answerbox.Location = new System.Drawing.Point(229, 138);
            this.Answerbox.Multiline = true;
            this.Answerbox.Name = "Answerbox";
            this.Answerbox.Size = new System.Drawing.Size(195, 47);
            this.Answerbox.TabIndex = 1;
            this.Answerbox.TextChanged += new System.EventHandler(this.Answerbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter a number between 1 and 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number entry ";
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(48, 138);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(140, 47);
            this.Submitbutton.TabIndex = 4;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "_______________________________________________________";
            // 
            // CorrectOrIncorrectlabel
            // 
            this.CorrectOrIncorrectlabel.AutoSize = true;
            this.CorrectOrIncorrectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectOrIncorrectlabel.Location = new System.Drawing.Point(25, 254);
            this.CorrectOrIncorrectlabel.Name = "CorrectOrIncorrectlabel";
            this.CorrectOrIncorrectlabel.Size = new System.Drawing.Size(0, 20);
            this.CorrectOrIncorrectlabel.TabIndex = 6;
            this.CorrectOrIncorrectlabel.Click += new System.EventHandler(this.CorrectOrIncorrectlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 322);
            this.Controls.Add(this.CorrectOrIncorrectlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answerbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "if Else ";
            this.Load += new System.EventHandler(this.IfelseForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Answerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CorrectOrIncorrectlabel;
    }
}

