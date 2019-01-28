using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int randomNumber = 0;
        int tries = 0;


        private void button_Play_Click(object sender, EventArgs e)
        {
            textBox_InputDigit.Focus();
            tries = 0;label_TriesText.Text="0";
            pictureBox_Result.Image = null;
            Random rnd = new Random();
            button_Go.Enabled = true;
            string level = comboBox_LevelChoose.Text;

            if (level == "1-10")
            {
                randomNumber = rnd.Next(1, 11);
                label1.Text = "Level: 1-10";
               // label1.Text = randomNumber.ToString();
            }

            else if (level == "1-50")
            {
                label1.Text = "Level: 1-50";
                randomNumber = rnd.Next(1, 51);
                //label1.Text = randomNumber.ToString();
            }

            else if (level == "1-100")
            {
                label1.Text = "Level: 1-100";
                randomNumber = rnd.Next(1, 101);
              //  label1.Text = randomNumber .ToString();
            }
            else if (level == "1-1000")
            {
                 label1.Text = "Level: 1-1000";
                randomNumber = rnd.Next(1, 1001);
              //  label1.Text = randomNumber.ToString();
            }

            else 
            {
                label1.Text = "Choose a correct option:";
                button_Go.Enabled = false;
            }
           

         
        }

        private void textBox_InputDigit_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox_InputDigit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_InputDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          //  if(enteredNumber >randomNumber)
               // pictureBox_upDown.Image = GuessTheNumber.Properties.Resources.Down_Arrow_PNG_Photos;

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_InputDigit.Focus();




            tries++;
            label_TriesText.Text = tries.ToString();
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_InputDigit.Text, "[0-9]"))
            {
                int sum;
                sum = Convert.ToInt32(textBox_InputDigit.Text);

                if (sum > randomNumber)
                    pictureBox_upDown.Image = GuessTheNumber.Properties.Resources.Down_Arrow_PNG_Photos;
                if (sum < randomNumber)
                    pictureBox_upDown.Image = GuessTheNumber.Properties.Resources.Green_Arrow_Up_new_;
                if (sum == randomNumber)
                {
                    button_Go.Enabled = false;
                    pictureBox_upDown.Image = null;

                    if (tries <= 10)

                        pictureBox_Result.Image = GuessTheNumber.Properties.Resources.thumbUP;
                    else if (tries > 10)
                        pictureBox_Result.Image = GuessTheNumber.Properties.Resources.thumb_Down;


                }


            }
          
           
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_InputDigit.Text, "[a-z]"))
            {
                label1.Text = "Enter Digits";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Go.Enabled = false;
        }
    }


    }
