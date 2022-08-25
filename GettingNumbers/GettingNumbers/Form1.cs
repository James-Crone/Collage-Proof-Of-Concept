using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingNumbers
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }

        private void CalculationForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculatorPicture_Click(object sender, EventArgs e)
        {

        }

        private void PerformCalculationLabel_Click(object sender, EventArgs e)
        {

        }

        private void WhatToDoLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void SecondNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeviderLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReturnNumberTextbox_Click(object sender, EventArgs e)
        {

        }

        private void CalculateUsersNumbers_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int mathAnswer;

            firstNumber = Convert.ToInt32(FirstNumberTextbox.Text);
            secondNumber = Convert.ToInt32(SecondNumberTextbox.Text);

            mathAnswer = firstNumber + secondNumber;

            ReturnNumberTextbox.Text = Convert.ToString(mathAnswer);
        }
    }
}
