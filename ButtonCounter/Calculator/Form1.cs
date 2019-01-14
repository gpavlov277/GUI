using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        string fisrtNumber;
        string secondNumber;
        char symbol;
        bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 1;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {
                
               secondNumber = secondNumber + 1;
                labelResultSecond.Text =  secondNumber.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!flag)
            {
                fisrtNumber = fisrtNumber + 2;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 2;
                labelResultSecond.Text =   secondNumber.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (!flag)
            {
                fisrtNumber = fisrtNumber + 3;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 3;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            flag = false;
            if (symbol == '+')
            {
                int result = Int32.Parse(fisrtNumber) + Int32.Parse(secondNumber);
                label_Screen.Text = result.ToString();
            }

            if (symbol == '-')
            {
                int result = Int32.Parse(fisrtNumber) - Int32.Parse(secondNumber);
                label_Screen.Text = result.ToString();
            }
            if (symbol == '*')
            {
                int result = Int32.Parse(fisrtNumber) * Int32.Parse(secondNumber);
                label_Screen.Text = result.ToString();
            }
            if (symbol == '/')
            {
                if (Int32.Parse(fisrtNumber) > 0)
                {
                    int result = Int32.Parse(fisrtNumber) / Int32.Parse(secondNumber);
                    label_Screen.Text = result.ToString();
                }
                else
                    label_Screen.Text = "Error";
            }
            fisrtNumber = String.Empty;
            secondNumber = String.Empty;
           




        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            symbol = '+';
            labelSymbolScreen.Text = symbol.ToString();
            label_Result.Text = label_Result.Text;
            flag = true;


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            fisrtNumber = String.Empty;
            secondNumber = String.Empty;

            label_Result.Text = " ";
            labelResultSecond.Text = " ";
            label_Screen.Text = " ";
            labelSymbolScreen.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 4;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 4;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 5;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 5;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 6;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 6;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 9;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 9;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 8;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 8;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 7;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 7;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                fisrtNumber = fisrtNumber + 0;
                label_Result.Text = fisrtNumber.ToString();
            }
            else
            {

                secondNumber = secondNumber + 0;
                labelResultSecond.Text = secondNumber.ToString();
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            symbol = '-';
            labelSymbolScreen.Text = symbol.ToString();
            label_Result.Text = label_Result.Text;
            flag = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            symbol = '*';
            labelSymbolScreen.Text = symbol.ToString();
            label_Result.Text = label_Result.Text;
            flag = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            symbol = '/';
            labelSymbolScreen.Text = symbol.ToString();
            label_Result.Text = label_Result.Text;
            flag = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
