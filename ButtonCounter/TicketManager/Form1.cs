using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        double price = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                endPrice.Text = (Int32.Parse(countPeopleTextBox.Text) * price).ToString();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 4;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 5;
        }

        private void countPeopleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countPeopleTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            countPeopleTextBox.Text = String.Empty;

        }
    }
}
