using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string smileFace = "⊂(◉‿◉)つ";
            string greet = "Why hello there!";
            string firstName = textBox1Fname.Text;
            string surName = textBox2Lname.Text;
            string userName = firstName + " " + surName;

            label2.Text = userName;
            label3.Text = greet + " " + firstName; ;
            labelSmileface.Text = smileFace;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4Fname_Click(object sender, EventArgs e)
        {

        }

        private void label5Lname_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelSmileface_Click(object sender, EventArgs e)
        {

        }
    }
}
