using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("inch 입력 : ");
            string inch = Console.ReadLine();
            int inch2 = int.Parse(inch);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            self.Text = "저를 클릭했습니다!";
        }

        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            label3.Text = elapsedTime + "초 경과";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double valueInInch;
            if (double.TryParse(textBox1.Text, out valueInInch))
            {
                double valueInCm = valueInInch * 2.54;
                label2.Text = "inch to cm: " + valueInCm.ToString("F2") + " cm";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}