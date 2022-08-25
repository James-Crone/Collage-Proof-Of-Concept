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

        string userName = "james";
        string passWord = "qwerty";
        string inputUsername;
        string inputPassword;
        int attempts = 1;

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            inputUsername = Convert.ToString(UsernameTextbox.Text);
            inputPassword = Convert.ToString(PasswordTextBox.Text);

            if (inputUsername == userName && inputPassword == passWord)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("incorrect, attempt number " + attempts + " of 3");
                attempts++;
            }
            if (attempts == 4)
            {
                MessageBox.Show("Too many Attempts exiting application");
                Application.Exit();
            }

        }
    }
}
