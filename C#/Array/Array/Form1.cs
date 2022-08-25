using System;
using System.Linq;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Numbers = { 4, 2, 7, 8, 12, 31 };

        private void Allvalues_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < Numbers.Length; i++)
            {
                textBox1.Text += Numbers[i] + "\r\n";
            }
        }

        private void Maxvalue_Click(object sender, EventArgs e)
        {
            int Max = Numbers.Max();
            textBox1.Text = Max.ToString();
        }

        private void Minvalue_Click(object sender, EventArgs e)
        {
            int Min = Numbers.Min();
            textBox1.Text = Min.ToString();
        }

        private void Totalvalue_Click(object sender, EventArgs e)
        {
            //int Total = Numbers[0] + Numbers[1] + Numbers[2] + Numbers[3] + Numbers[4] + Numbers[5]; wrote it this way then seen there was a .sum method
            int Total = Numbers.Sum();
            textBox1.Text = Total.ToString();
        }
    }
}
