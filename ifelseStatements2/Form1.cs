using System;
using System.Windows.Forms;

namespace ifelseStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IfelseForm1_Load(object sender, EventArgs e)
        {

        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            int usersNumber; 
                usersNumber = Convert.ToInt32(Answerbox.Text);

            if (usersNumber <= 50 && usersNumber >= 1)
            {
                CorrectOrIncorrectlabel.Text = "You have entered a number between 1 and 50";
            }
            else if (usersNumber >= 51 && usersNumber <= 100)
            {
                CorrectOrIncorrectlabel.Text = "You have entered a number between 51 and 100";
            }
            else 
                CorrectOrIncorrectlabel.Text = "Please enter a number within range";
        }

        private void Answerbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CorrectOrIncorrectlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
