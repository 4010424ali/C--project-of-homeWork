using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                Double radius = Convert.ToDouble(textBox1.Text);
                Double Area = 3.14 * radius * radius;
                circle.Text = Area.ToString();
            }
            else
            {
                MessageBox.Show("Please enter Only Radius");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                Double lenght = Convert.ToDouble(textBox2.Text);
                Double width = Convert.ToDouble(textBox3.Text);
                Double rectangula = lenght * width;
                rectangular.Text = rectangula.ToString();
            } else
            {
                MessageBox.Show("Please enter Length and Width only");
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Double lenght = Convert.ToDouble(textBox2.Text);
                Double width = Convert.ToDouble(textBox3.Text);
                Double rectangula = lenght * width/ 2;
                triangle.Text = rectangula.ToString();
            }
            else
            {
                MessageBox.Show("Please enter Length and Width");
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                Double radius = Convert.ToDouble(textBox1.Text);
                Double Area = 2 * 3.14 * radius * radius;
                circum.Text = Area.ToString();
            }
            else
            {
                MessageBox.Show("Please enter Only Radius");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                Double temp = Convert.ToDouble(textBox1.Text);
                Double Fahrenheit = 5 / 9*(temp - 35);
                farhen.Text = Fahrenheit.ToString();
            }
            else
            {
                MessageBox.Show("Please enter Only Tempature");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double number_1 = Convert.ToDouble(textBox1.Text);
            Double number_2 = Convert.ToDouble(textBox2.Text);
            Double Number_3 = Convert.ToDouble(textBox3.Text);
            Double Average = (number_1 + number_2 + Number_3) / 3;
            average.Text = Average.ToString(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
           if(textBox3.Text == "")
            {
                Double Number_1 = Convert.ToDouble(textBox1.Text);
                Double Number_2 = Convert.ToDouble(textBox2.Text);
                Double Number_3 = Math.Sqrt(Math.Pow(Number_1,2) + Math.Pow(Number_2,2));
                cSquare.Text = Number_3.ToString();
            }
            else
            {
                MessageBox.Show("Please enter A and B Only");
                textBox3.Text =  "";
            }

        }
    }
}
