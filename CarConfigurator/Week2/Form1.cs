using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form1 : Form
    {
        double carPrice = 0;
        double discount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_PriceValue.Text = " ";
            label_DiscountValue.Text = " ";
            label_FinalPriceVlue.Text = " "; 
            label_PriceValueExtraAdds.Text = " "; 

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_Audi_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Auto.Image = Week2.Properties.Resources.Audi;
            carPrice = 180000;
            label_PriceValue.Text = carPrice.ToString() + " Euro"; ;


        }

        private void radioButton_BMW_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Auto.Image = Week2.Properties.Resources.bmw;
            carPrice = 150000;
            label_PriceValue.Text = carPrice.ToString()+" Euro";

        }

        private void radioButton_Mercedes_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Auto.Image = Week2.Properties.Resources.mercedes;
            carPrice = 200000;
            label_PriceValue.Text = carPrice.ToString() + " Euro"; ;

        }

        private void checkBox_PayInCash_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PayInCash.Checked == true)

                discount =(carPrice * 0.05);
            label_DiscountValue.Text = discount.ToString();

           
        }

        private void checkBox_ABS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ABS.Checked == true)
                carPrice += 2500;
            if (checkBox_ABS.Checked == false)
                carPrice -= 2500;
          
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
            
            
           // buttonCalculate.Enabled = false;

           

            label_PriceValueExtraAdds.Text = carPrice.ToString();
            label_FinalPriceVlue.Text = (carPrice - discount).ToString();




        }

        private void checkBox_Lights_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Lights.Checked == true)
                carPrice += 5500;
            if (checkBox_Lights.Checked == false)
                carPrice -= 5500;
          
        }

        private void checkBox_Alarm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Alarm.Checked == true)
                carPrice += 1000;
            if (checkBox_Alarm.Checked == false)
                carPrice -= 1000;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            label_PriceValueExtraAdds.Text = " ";
            checkBox_ABS.Checked = false;
            checkBox_Lights.Checked = false;
            checkBox_Alarm.Checked = false;
            checkBox_PayInCash.Checked = false;
            label_DiscountValue.Text = " ";
            label_PriceValue.Text = " ";
            label_FinalPriceVlue.Text = " ";

        }

        private void button_CloseForm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit car configurator?", "Close program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }
    }
}
