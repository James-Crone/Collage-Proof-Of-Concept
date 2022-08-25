using System;
using System.Windows.Forms;
namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int userNumber;
        int sum;

        private void enterButton_Click(object sender, EventArgs e)
        {
            userNumber = Convert.ToInt32(numberTextbox.Text);

            for (int tt = 1; tt <= 10;  tt++)
            {
                sum = tt * userNumber;
                printTextbox.Text += userNumber + " X " + tt + " = " + sum + "\r\n";
            }
        }
    }
}

