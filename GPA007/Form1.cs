using System;
using System.Windows.Forms;
using Gpax;

namespace GPA007
{
    public partial class Form1 : Form
    {
        private GPACalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new GPACalculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double gpa))
            {
                calculator.SetGPA(gpa);
                textBox2.Text = "à¡Ã´: " + GetGPAX(calculator.GetGPAX());
                textBox1.Clear(); 
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("¡ÃØ³ÒãÊè¤èÒ GPA ·Õè¶Ù¡µéÍ§", "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetGPAX(double gpa)
        {
            if (gpa >= 80) return "4";
            if (gpa >= 70) return "3";
            if (gpa >= 60) return "2";
            if (gpa >= 1) return "1";
            return "1";
        }
    }
}
