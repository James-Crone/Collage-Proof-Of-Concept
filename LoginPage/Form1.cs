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

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string inputUsername;
            string inputPassword;

            string userName = "james";
            string passWord = "qwerty";

            inputUsername = Convert.ToString(UsernameTextbox.Text);
            inputPassword = Convert.ToString(PasswordTextBox.Text);

            if (inputUsername == userName && inputPassword == passWord)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}
