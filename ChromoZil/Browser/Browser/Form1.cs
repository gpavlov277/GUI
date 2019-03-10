using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Browser
{
   
    public partial class SignIn : Form
    {
       public static string loggedUser = String.Empty;
        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();
      //  readonly string filePath = "users.txt";

        public SignIn()
        {
            InitializeComponent();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            textBox_Password.Text = String.Empty;
           textBox_Password.PasswordChar = '*';
        }

        private void textBox_UserName_Click(object sender, EventArgs e)
        {
            textBox_UserName.Text = String.Empty;
        }

      

      

        private void textBox_RegName_Click_1(object sender, EventArgs e)
        {
            textBox_RegName.Text = String.Empty;
        }

        private void textBox_RegPass_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_RegPass.Text = String.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');

                usernames.Add(data[0]);
                passwords.Add(data[1]);




            }
            sr.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == String.Empty || textBox_Password.Text == String.Empty || textBox_RegName.Text == String.Empty || textBox_RegPass.Text == String.Empty)
            {
                textBox_UserName.Text = "USERNAME";

                textBox_Password.Text = "PASSWORD";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Register_Click(object sender, EventArgs e)
        {
            string inputusername = textBox_RegName.Text.Trim();
            string inputpassword = textBox_RegPass.Text.Trim();

            if ( inputpassword==String.Empty)
            {
                MessageBox.Show("Въведи парола!","Регистрация");
                return;

            }

            if (inputusername == "")
            {
                MessageBox.Show("Въведи име!", "Регистрация");
                return;

            }

            if (usernames.Contains(inputusername))
            {
                MessageBox.Show("Името е заето!", "Регистрация");
                return;

            }
            
            

                using (StreamWriter sw = new StreamWriter("users.txt", true))

                {

                    sw.WriteLine(inputusername + "," + inputpassword);


                    sw.Close();

                }



                usernames.Add(inputusername);
                passwords.Add(inputpassword);
                MessageBox.Show("Регистрацията е успешна!", "Регистрация");
                textBox_RegName.Text = String.Empty;
                textBox_RegPass.Text = String.Empty;
            
        }

        private void pictureBox_Login_Click(object sender, EventArgs e)
        {
            string inputUsername = textBox_UserName.Text;
            string inputPasssword = textBox_Password.Text;

            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();

            StreamReader sr = new StreamReader("users.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');

                usernames.Add(data[0]);
                passwords.Add(data[1]);




            }
            sr.Close();

            bool isFound = false;

            for (int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i] == inputUsername && passwords[i] == inputPasssword)
                {
                    isFound = true;
                    MessageBox.Show("Влизането успешно","Влизане");
                    loggedUser = usernames[i];
                    
                  
                  

                }
            }
            if (!isFound)
            {

                MessageBox.Show("Грешно потребителско име и/или парола", "Влизане");
                
            }
            if (isFound)
            {
                BrowserFormNew BRForm = new BrowserFormNew();
                 BRForm.Show();
                 this.Hide();
              
              

            }


        }
     
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_RegPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_RegPass_Click(object sender, EventArgs e)
        {

            textBox_RegPass.PasswordChar = '*';
        }
    }
}
