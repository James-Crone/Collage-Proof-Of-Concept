
namespace GettingNumbers
{
    partial class CalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.CalculatorPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PerformCalculationLabel = new System.Windows.Forms.Label();
            this.WhatToDoLabel = new System.Windows.Forms.Label();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.FirstNumberTextbox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextbox = new System.Windows.Forms.TextBox();
            this.DeviderLabel = new System.Windows.Forms.Label();
            this.CalculateUsersNumbers = new System.Windows.Forms.Button();
            this.ReturnNumberTextbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CalculatorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatorPicture
            // 
            this.CalculatorPicture.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorPicture.Image")));
            this.CalculatorPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("CalculatorPicture.InitialImage")));
            this.CalculatorPicture.Location = new System.Drawing.Point(346, 12);
            this.CalculatorPicture.Name = "CalculatorPicture";
            this.CalculatorPicture.Size = new System.Drawing.Size(142, 139);
            this.CalculatorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CalculatorPicture.TabIndex = 0;
            this.CalculatorPicture.TabStop = false;
            this.CalculatorPicture.Click += new System.EventHandler(this.CalculatorPicture_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // PerformCalculationLabel
            // 
            this.PerformCalculationLabel.AutoSize = true;
            this.PerformCalculationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformCalculationLabel.Location = new System.Drawing.Point(75, 12);
            this.PerformCalculationLabel.Name = "PerformCalculationLabel";
            this.PerformCalculationLabel.Size = new System.Drawing.Size(192, 24);
            this.PerformCalculationLabel.TabIndex = 2;
            this.PerformCalculationLabel.Text = "Perform Calculation\r\n";
            this.PerformCalculationLabel.Click += new System.EventHandler(this.PerformCalculationLabel_Click);
            // 
            // WhatToDoLabel
            // 
            this.WhatToDoLabel.AutoSize = true;
            this.WhatToDoLabel.Location = new System.Drawing.Point(86, 61);
            this.WhatToDoLabel.Name = "WhatToDoLabel";
            this.WhatToDoLabel.Size = new System.Drawing.Size(181, 26);
            this.WhatToDoLabel.TabIndex = 3;
            this.WhatToDoLabel.Text = " Enter two numbers below and press \r\ncalculate to show answer";
            this.WhatToDoLabel.Click += new System.EventHandler(this.WhatToDoLabel_Click);
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumberLabel.Location = new System.Drawing.Point(19, 135);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(81, 16);
            this.FirstNumberLabel.TabIndex = 4;
            this.FirstNumberLabel.Text = "First number";
            this.FirstNumberLabel.Click += new System.EventHandler(this.FirstNumberLabel_Click);
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumberLabel.Location = new System.Drawing.Point(19, 184);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(103, 16);
            this.SecondNumberLabel.TabIndex = 5;
            this.SecondNumberLabel.Text = "Second number";
            this.SecondNumberLabel.Click += new System.EventHandler(this.SecondNumberLabel_Click);
            // 
            // FirstNumberTextbox
            // 
            this.FirstNumberTextbox.Location = new System.Drawing.Point(167, 131);
            this.FirstNumberTextbox.Name = "FirstNumberTextbox";
            this.FirstNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.FirstNumberTextbox.TabIndex = 6;
            this.FirstNumberTextbox.TextChanged += new System.EventHandler(this.FirstNumberTextbox_TextChanged);
            // 
            // SecondNumberTextbox
            // 
            this.SecondNumberTextbox.Location = new System.Drawing.Point(167, 184);
            this.SecondNumberTextbox.Name = "SecondNumberTextbox";
            this.SecondNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.SecondNumberTextbox.TabIndex = 7;
            this.SecondNumberTextbox.TextChanged += new System.EventHandler(this.SecondNumberTextbox_TextChanged);
            // 
            // DeviderLabel
            // 
            this.DeviderLabel.AutoSize = true;
            this.DeviderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviderLabel.Location = new System.Drawing.Point(19, 247);
            this.DeviderLabel.Name = "DeviderLabel";
            this.DeviderLabel.Size = new System.Drawing.Size(469, 13);
            this.DeviderLabel.TabIndex = 8;
            this.DeviderLabel.Text = "__________________________________________________________________";
            this.DeviderLabel.Click += new System.EventHandler(this.DeviderLabel_Click);
            // 
            // CalculateUsersNumbers
            // 
            this.CalculateUsersNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateUsersNumbers.Location = new System.Drawing.Point(22, 296);
            this.CalculateUsersNumbers.Name = "CalculateUsersNumbers";
            this.CalculateUsersNumbers.Size = new System.Drawing.Size(85, 30);
            this.CalculateUsersNumbers.TabIndex = 9;
            this.CalculateUsersNumbers.Text = "Calculate";
            this.CalculateUsersNumbers.UseVisualStyleBackColor = true;
            this.CalculateUsersNumbers.Click += new System.EventHandler(this.CalculateUsersNumbers_Click);
            // 
            // ReturnNumberTextbox
            // 
            this.ReturnNumberTextbox.AutoSize = true;
            this.ReturnNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnNumberTextbox.Location = new System.Drawing.Point(226, 296);
            this.ReturnNumberTextbox.Name = "ReturnNumberTextbox";
            this.ReturnNumberTextbox.Size = new System.Drawing.Size(0, 31);
            this.ReturnNumberTextbox.TabIndex = 10;
            this.ReturnNumberTextbox.Click += new System.EventHandler(this.ReturnNumberTextbox_Click);
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 365);
            this.Controls.Add(this.ReturnNumberTextbox);
            this.Controls.Add(this.CalculateUsersNumbers);
            this.Controls.Add(this.DeviderLabel);
            this.Controls.Add(this.SecondNumberTextbox);
            this.Controls.Add(this.FirstNumberTextbox);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.Controls.Add(this.WhatToDoLabel);
            this.Controls.Add(this.PerformCalculationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculatorPicture);
            this.Name = "CalculationForm";
            this.Text = "GettingNumbers";
            this.Load += new System.EventHandler(this.CalculationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalculatorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CalculatorPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PerformCalculationLabel;
        private System.Windows.Forms.Label WhatToDoLabel;
        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.Label SecondNumberLabel;
        private System.Windows.Forms.TextBox FirstNumberTextbox;
        private System.Windows.Forms.TextBox SecondNumberTextbox;
        private System.Windows.Forms.Label DeviderLabel;
        private System.Windows.Forms.Button CalculateUsersNumbers;
        private System.Windows.Forms.Label ReturnNumberTextbox;
    }
}

