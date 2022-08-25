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

            if (userNumber <= 10 & userNumber >= 5)
            {
                for (int counter = userNumber; counter >= 0; counter--)
                {
                    printTextbox.AppendText (counter + "\r\n");
                }
            }
            else
            {
                printTextbox.Text = "Invalid number, please enter a number between 1 and 10";
            }
        }
    }
}

