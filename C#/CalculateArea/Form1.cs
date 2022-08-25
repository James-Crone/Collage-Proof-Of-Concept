using System;
using System.Windows.Forms;

namespace CalculateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int height = Convert.ToInt32(heightTextbox.Text);
            int width = Convert.ToInt32(widthTextbox.Text);

            int area = height * width;
            outputTextbox.Text = "The area is: " + area;
        }
    }
}