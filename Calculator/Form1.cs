using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (firstNum.Text == "" || secNum.Text == "")
            {
                MessageBox.Show("Please fill the input ");
                return;
            }
            if (firstNum.Text != string.Empty && !Regex.IsMatch(firstNum.Text, @"^[0-9]+$") || secNum.Text != string.Empty && !Regex.IsMatch(secNum.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please only enter numbers");
                firstNum.Clear();
                return; // nothing after this will execute
            }
            else { 

                Double num1 = Convert.ToDouble(firstNum.Text);
                Double num2 = Convert.ToDouble(secNum.Text);
                Double Sum = num1 + num2;
                resultBox.Text = Sum.ToString();
            }


        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (firstNum.Text == "" || secNum.Text == "")
            {
                MessageBox.Show("Please fill the input ");
                return;
            }
            if (firstNum.Text != string.Empty && !Regex.IsMatch(firstNum.Text, @"^[0-9]+$") || secNum.Text != string.Empty && !Regex.IsMatch(secNum.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please only enter numbers");
                firstNum.Clear();
                return; // nothing after this will execute
            }
            else
            {
                Double num1 = Convert.ToDouble(firstNum.Text);
                Double num2 = Convert.ToDouble(secNum.Text);
                Double sub = num1 - num2;
                resultBox.Text = sub.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstNum.Text == "" || secNum.Text == "")
            {
                MessageBox.Show("Please fill the input ");
                return;
            }
            if (firstNum.Text != string.Empty && !Regex.IsMatch(firstNum.Text, @"^[0-9]+$") || secNum.Text != string.Empty && !Regex.IsMatch(secNum.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please only enter numbers");
                firstNum.Clear();
                return; // nothing after this will execute
            }
            else
            {

            Double num1 = Convert.ToDouble(firstNum.Text);
            Double num2 = Convert.ToDouble(secNum.Text);
            Double mul = num1 * num2;
            resultBox.Text = mul.ToString();
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (firstNum.Text == "" || secNum.Text == "")
            {
                MessageBox.Show("Please fill the input ");
                return;
            }
            if (firstNum.Text != string.Empty && !Regex.IsMatch(firstNum.Text, @"^[0-9]+$") || secNum.Text != string.Empty && !Regex.IsMatch(secNum.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please only enter numbers");
                firstNum.Clear();
                return; // nothing after this will execute
            }
            else
            {
            Double num1 = Convert.ToDouble(firstNum.Text);
            Double num2 = Convert.ToDouble(secNum.Text);
            Double div = num1 / num2;
            resultBox.Text = div.ToString();

            }

        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            if (firstNum.Text == "" || secNum.Text == "")
            {
                MessageBox.Show("Please fill the input ");
                return;
            }
            if (firstNum.Text != string.Empty && !Regex.IsMatch(firstNum.Text, @"^[0-9]+$") || secNum.Text != string.Empty && !Regex.IsMatch(secNum.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please only enter numbers");
                firstNum.Clear();
                return; // nothing after this will execute
            }
            else { 
            
            Double num1 = Convert.ToDouble(firstNum.Text);
            Double num2 = Convert.ToDouble(secNum.Text);
            Double result =num1 % num2; 
            resultBox.Text = result.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
