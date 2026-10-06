using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBox3.Text);
            double secondNumber = double.Parse(textBox5.Text);

            double result = firstNumber - secondNumber;

            textBox1.Text = result.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox5.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            double firstNumber = double.Parse(textBox3.Text);
            double secondNumber = double.Parse(textBox5.Text);

            double result = firstNumber / secondNumber;

            textBox1.Text = result.ToString();
        



        }

        private void button5_Click(object sender, EventArgs e)
        {
      
       
            double firstNumber = double.Parse(textBox3.Text);
            double secondNumber = double.Parse(textBox5.Text);

            double result = firstNumber   secondNumber;

            textBox1.Text = result.ToString();
        


        }

        private void button6_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBox3.Text);
            double secondNumber = double.Parse(textBox5.Text);

            double result = firstNumber * secondNumber;

            textBox1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }o

    
        private void Calculate(char operation)
        {
            try
            {
                if (!double.TryParse(textBox3.Text, out double num1) ||
                    !double.TryParse(textBox5.Text, out double num2))
                {
                    MessageBox.Show("Please enter valid numbers!");
                    return;
                }

                double result = 0;using System.Globalization;

double firstNumber;
if (!double.TryParse(textBox3.Text, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out firstNumber))
{
    MessageBox.Show("Enter a valid first number");
    return;
}

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                if (double.IsNaN(result) || double.IsInfinity(result))
                {
                    MessageBox.Show("Invalid calculation!");
                    return;
                }

                textBox3.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Try again!");
            }
        }
    }
