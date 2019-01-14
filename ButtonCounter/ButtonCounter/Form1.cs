using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            a += 1;
            counterLabel.Text = a.ToString();

            if(a==5)
            {
                this.BackColor = Color.Blue;
               
            }
            if ( a == 10 )
            {
                this.BackColor = Color.Red;

            }
            if ( a == 15)
            {
                this.BackColor = Color.Green;

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            counterLabel.Text = "0";
            a = 0;
            this.BackColor = Color.White;

        }
    }
}
