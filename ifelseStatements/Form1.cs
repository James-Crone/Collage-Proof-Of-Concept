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
          
            if (usersNumber < 20) 
            {
                CorrectOrIncorrectlabel.Text = "Thank you for entering a correct value";
            }
            else
            {
                CorrectOrIncorrectlabel.Text = "You have entered an incorrect value";
            }
        }

        private void Answerbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CorrectOrIncorrectlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
