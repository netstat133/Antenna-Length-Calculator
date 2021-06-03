using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] hz = { "khz", "Mhz", "Ghz" };
            string[] ramda = { "λ", "λ/2", "λ/4", "5λ/8" };

            comboBox1.Items.AddRange(hz);
            comboBox2.Items.AddRange(ramda);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text);
            if (comboBox1.Text == "khz")
            {
                x = x * 1000;
                x = 300000000 / x;
                if (comboBox2.Text == "λ")
                {
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "λ/2")
                {
                    x = x / 2;
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "λ/4")
                {
                    x = x / 4;
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "5λ/8")
                {
                    x = x * 5;
                    x = x / 8;
                    label1.Text = Convert.ToString(x);
                }
            }
            else if (comboBox1.Text == "Mhz")
            {
                x = x * 1000000;
                x = 300000000 / x;
                if (comboBox2.Text == "λ")
                {
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "λ/2")
                {
                    x = x / 2;
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "λ/4")
                {
                    x = x / 4;
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "5λ/8")
                {
                    x = x * 5;
                    x = x / 8;
                    label1.Text = Convert.ToString(x);
                }
            }
            else if (comboBox1.Text == "Ghz")
            {
                x = x * 1000000000;
                x = 300000000 / x;
                if (comboBox2.Text == "λ")
                {
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "λ/2")
                {
                    x = x / 2;
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "λ/4")
                {
                    x = x / 4;
                    label1.Text = Convert.ToString(x);
                }
                else if (comboBox2.Text == "5λ/8")
                {
                    x = x * 5;
                    x = x / 8;
                    label1.Text = Convert.ToString(x);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://cafe.naver.com/hl2vxk/36439");
        }
    }
}
