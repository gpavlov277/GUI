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
    public partial class BrowserFormNew : Form
    {
        List<string> favsSites = new List<string>();
        
        public BrowserFormNew()
        {
            InitializeComponent();
        }

        private void BrowserFormNew_Load(object sender, EventArgs e)
        {
            // webBrowser.Navigate("https://www.google.com");
            tabControl.SelectedTab.Text = "Favs";
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            label1.Text = SignIn.loggedUser.ToString();
            




            FileStream fs = new FileStream(SignIn.loggedUser, FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(fs);
           
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string data = line;

                favsSites.Add(data);
               



            }
            if (favsSites.Count > 0)
                for (int i = 0; i < favsSites.Count; i++)
                {
                    FavsList.Items.Add(favsSites[i]);
                }
               
            
            sr.Close();
        


    }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
            tabControl.SelectedTab.Text = "  Любими  ";

           
        }





        private void BrowserFormNew_Resize(object sender, EventArgs e)
        {
            //pictureBox_Go.Location = new Point(610, 8);
            //pictureBox_History.Location = new Point(638, 8);
            //pictureBox_Favs.Location = new Point(665, 8);
        }

        private void BrowserFormNew_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (tabControl.SelectedIndex == 0)
                pictureBox_CloseTab.Visible = false;
            else
            {
                pictureBox_CloseTab.Visible = true;
            }
            //}



            if (this.WindowState == FormWindowState.Minimized)

            {

               

            }
        }

        private void pictureBox_Go_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(textBox_url.Text);


        }
        WebBrowser webTab = null;


        private void pictureBox_NewTab_Click(object sender, EventArgs e)
        {
          
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
           webTab.Navigate("https://www.google.com");
            textBox_url.Text = "https://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
            if (tabControl.TabCount > 1)
            {
                pictureBox_CloseTab.Visible = true;
            }
          

        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
            // textBox_url.Text = webBrowser.DocumentTitle;
            textBox_url.Text = webTab.Url.AbsoluteUri;

        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if(web!=null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void pictureBox_Forward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void textBox_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            { 

            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(textBox_url.Text);
                }
            }
        }

        private void pictureBox_CloseTab_Click(object sender, EventArgs e)
        {
            if(tabControl.TabPages.Count>0)
            tabControl.TabPages.Remove(tabControl.SelectedTab);
            tabControl.SelectedIndex = tabControl.TabCount - 1;
         


            if (tabControl.SelectedIndex == 0)
            {
               FavsList.Visible = true;
                webTab.Visible = false;
                pictureBox_CloseTab.Visible = false;
        



            }
           
               
            if (tabControl.SelectedIndex == -1)
            {


                this.Close();
            }
            
        }

        private void pictureBox_History_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_Favs_Click(object sender, EventArgs e)
        {
            string urlAdress = textBox_url.Text;


            if (favsSites.Contains(urlAdress))
            {
                MessageBox.Show("Сайтът вече е добавен!", "Любими сайтове");
                return;

            }
            using (StreamWriter sw = new StreamWriter(SignIn.loggedUser, true))

            {
                if(urlAdress!=String.Empty)
                sw.WriteLine(urlAdress);


                sw.Close();

            }
            if (textBox_url.Text != "")
            {
                FavsList.Items.Add(urlAdress);
                favsSites.Add(urlAdress);
            }

        }

        private void FavsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////////////////
           
        }

        private void BrowserFormNew_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webTab_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Favs_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Favs.Image = Browser.Properties.Resources.filledStar;

        }

        private void pictureBox_Favs_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Favs.Image = Browser.Properties.Resources.iconfinder_star_circle_353442;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Go_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Go.Image = Browser.Properties.Resources.GoArrow;
        }

        private void pictureBox_Go_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Go.Image = Browser.Properties.Resources.iconfinder_130_ArrowRightDouble_183527;
        }

        private void pictureBox_Back_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Back.Image = Browser.Properties.Resources.backPressed;
        }

        private void pictureBox_Back_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Back.Image = Browser.Properties.Resources.back;
        }
        private void pictureBox_Forward_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Forward.Image = Browser.Properties.Resources.forwardPressed;
        }
        private void pictureBox_Forward_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Forward.Image = Browser.Properties.Resources.forward1;
        }

        private void pictureBox_NewTab_MouseHover(object sender, EventArgs e)
        {
            pictureBox_NewTab.Image = Browser.Properties.Resources.AddPressed;
        }

        private void pictureBox_NewTab_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_NewTab.Image = Browser.Properties.Resources.iconfinder_add_126583;
        }

        private void pictureBox_CloseTab_MouseHover(object sender, EventArgs e)
        {
            pictureBox_CloseTab.Image = Browser.Properties.Resources.CloseTabRed;
        }

        private void pictureBox_CloseTab_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_CloseTab.Image = Browser.Properties.Resources.iconfinder_icon_minus_round_211863;
        }

        private void FavsList_DoubleClick(object sender, EventArgs e)
        {
            if (FavsList.SelectedItem != null)
            {
                string webSitetoLoad = FavsList.SelectedItem.ToString();
                //  webBrowser2.Navigate(webSitetoLoad);
                // FavsList.Visible = false;
                // label_FavsText.Visible = false;
                //textBox_url.Text ="https://"+ webSitetoLoad;


                TabPage tab = new TabPage();

                tabControl.Controls.Add(tab);
                tabControl.SelectTab(tabControl.TabCount - 1);
                webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
                webTab.Parent = tab;
                webTab.Dock = DockStyle.Fill;
                webTab.Navigate(webSitetoLoad);
                textBox_url.Text = webSitetoLoad;
                webTab.DocumentCompleted += WebTab_DocumentCompleted;
                if (tabControl.TabCount > 1)
                {
                    pictureBox_CloseTab.Visible = true;
                }




            }
        }

        private void button_DeleteSelectedIndex_Click(object sender, EventArgs e)
        {


            File.WriteAllText(SignIn.loggedUser, String.Empty);

            int currentIndex = FavsList.SelectedIndex;
            if (FavsList.SelectedIndex >= 0)
            {
                FavsList.Items.RemoveAt(currentIndex);
                favsSites.RemoveAt(currentIndex);
            }


            using (StreamWriter sw = new StreamWriter(SignIn.loggedUser, true))

            {
                for (int i = 0; i < favsSites.Count; i++)
                {
                    sw.WriteLine(favsSites[i]);

                }

                sw.Close();

            }



        

        

    }

        private void button_DeleteAll_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SignIn.loggedUser, String.Empty);
            favsSites.Clear();
            FavsList.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_ReloadSite_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_ReloadSite.Image = Browser.Properties.Resources.iconfinder___07_1720774;
        }

        private void pictureBox_ReloadSite_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_ReloadSite.Image = Browser.Properties.Resources.unpressedReload;
        }

        private void contextMenuStrip_Settings_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            contextMenuStrip_Settings.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn signinForm = new SignIn();
            signinForm.Show();
        }

        private void заПриложениетоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
} 
