using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Scissors_Paper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int type = 0;
        Random rand = new Random();
        int playerPoints = 0;
        int computerPoints = 0;


        private void textBox_playerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            type = rand.Next(1, 4);
            pictureBox_PlayerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Scissors;
        
            if (type == 1)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Rock;
                computerPoints += 1;
                label_ComputerResult.Text = computerPoints.ToString();

            }
            if (type == 2)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Scissors;
              
            }

            if (type == 3)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Paper;
                playerPoints += 1;
                label_PLayerResult.Text = playerPoints.ToString();

            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            label_playerName.Text = textBox_playerName.Text;

            type = rand.Next(1, 4);
            

            pictureBox_PlayerChoose.Image = null;
            pictureBox_ComputerChoose.Image = null;

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            label_playerName.Text = string.Empty;
            textBox_playerName.Text = string.Empty;
            label_PLayerResult.Text = "0";
            label_ComputerResult.Text = "0";
            playerPoints = 0;
            computerPoints =0;

            pictureBox_PlayerChoose.Image = null;
            pictureBox_ComputerChoose.Image = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            type = rand.Next(1, 4);
            pictureBox_PlayerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Rock;
            if (type == 1)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Rock;
               
            }
            if (type == 2)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Scissors;
                playerPoints += 1;
                label_PLayerResult.Text = playerPoints.ToString();
            }

            if (type == 3)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Paper;
               computerPoints += 1;
                label_ComputerResult.Text = computerPoints.ToString();
            }
            type = rand.Next(1, 4);
        }

        private void pictureBox_Paper_Click(object sender, EventArgs e)
        {
            type = rand.Next(1, 4);
            pictureBox_PlayerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Paper;
          
            if (type == 1)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Rock;
                playerPoints += 1;
                label_PLayerResult.Text = playerPoints.ToString();

            }
            if (type == 2)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Scissors;
                computerPoints += 1;
                label_ComputerResult.Text = computerPoints.ToString();
            }

            if (type == 3)
            {
                pictureBox_ComputerChoose.Image = Rock_Scissors_Paper.Properties.Resources.Paper;
             
            }
            type = rand.Next(1, 4);

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
