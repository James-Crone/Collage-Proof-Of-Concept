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

        private void enterButton_Click(object sender, EventArgs e)
        {
            int userNumber = Convert.ToInt32(numberTextbox.Text);
            int counter = 0;

            if (userNumber <= 10)
            {
                while(counter != userNumber)
                {
                    printTextbox.AppendText("Happy Birthday\r\n");
                    counter++;
                }
            }
            else
            {
                printTextbox.Text = "Invalid number, please enter a number between 1 and 10";
            }
        }
    }
}
