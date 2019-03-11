namespace Browser
{
    partial class BrowserFormNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserFormNew));
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_FavsText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DeleteAll = new System.Windows.Forms.Button();
            this.button_DeleteSelectedIndex = new System.Windows.Forms.Button();
            this.FavsList = new System.Windows.Forms.ListBox();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip_Settings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ReloadSite = new System.Windows.Forms.PictureBox();
            this.pictureBox_CloseTab = new System.Windows.Forms.PictureBox();
            this.pictureBox_NewTab = new System.Windows.Forms.PictureBox();
            this.pictureBox_Favs = new System.Windows.Forms.PictureBox();
            this.pictureBox_Go = new System.Windows.Forms.PictureBox();
            this.pictureBox_Forward = new System.Windows.Forms.PictureBox();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПриложениетоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ReloadSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CloseTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NewTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Favs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_url
            // 
            this.textBox_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_url.BackColor = System.Drawing.Color.White;
            this.textBox_url.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_url.Location = new System.Drawing.Point(144, 14);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(480, 29);
            this.textBox_url.TabIndex = 5;
            this.textBox_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_url_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(-7, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(795, 396);
            this.tabControl.TabIndex = 7;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button_DeleteAll);
            this.tabPage1.Controls.Add(this.button_DeleteSelectedIndex);
            this.tabPage1.Controls.Add(this.FavsList);
            this.tabPage1.Controls.Add(this.webBrowser2);
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label_FavsText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(147, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 84);
            this.panel1.TabIndex = 24;
            // 
            // label_FavsText
            // 
            this.label_FavsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FavsText.AutoSize = true;
            this.label_FavsText.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FavsText.Location = new System.Drawing.Point(108, 6);
            this.label_FavsText.Name = "label_FavsText";
            this.label_FavsText.Size = new System.Drawing.Size(271, 45);
            this.label_FavsText.TabIndex = 21;
            this.label_FavsText.Text = "Любими сайтове";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Влезнали сте като:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_DeleteAll
            // 
            this.button_DeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteAll.Location = new System.Drawing.Point(455, 305);
            this.button_DeleteAll.Name = "button_DeleteAll";
            this.button_DeleteAll.Size = new System.Drawing.Size(91, 23);
            this.button_DeleteAll.TabIndex = 23;
            this.button_DeleteAll.Text = "Изтрий всичко";
            this.button_DeleteAll.UseVisualStyleBackColor = true;
            this.button_DeleteAll.Click += new System.EventHandler(this.button_DeleteAll_Click);
            // 
            // button_DeleteSelectedIndex
            // 
            this.button_DeleteSelectedIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteSelectedIndex.Location = new System.Drawing.Point(552, 305);
            this.button_DeleteSelectedIndex.Name = "button_DeleteSelectedIndex";
            this.button_DeleteSelectedIndex.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteSelectedIndex.TabIndex = 22;
            this.button_DeleteSelectedIndex.Text = "Изтрий";
            this.button_DeleteSelectedIndex.UseVisualStyleBackColor = true;
            this.button_DeleteSelectedIndex.Click += new System.EventHandler(this.button_DeleteSelectedIndex_Click);
            // 
            // FavsList
            // 
            this.FavsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FavsList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FavsList.FormattingEnabled = true;
            this.FavsList.Location = new System.Drawing.Point(147, 87);
            this.FavsList.Name = "FavsList";
            this.FavsList.Size = new System.Drawing.Size(480, 199);
            this.FavsList.TabIndex = 20;
            this.FavsList.SelectedIndexChanged += new System.EventHandler(this.FavsList_SelectedIndexChanged);
            this.FavsList.DoubleClick += new System.EventHandler(this.FavsList_DoubleClick);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(781, 364);
            this.webBrowser2.TabIndex = 16;
            this.webBrowser2.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(781, 364);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(787, 367);
            this.webBrowser1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip_Settings
            // 
            this.contextMenuStrip_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изходToolStripMenuItem,
            this.заПриложениетоToolStripMenuItem});
            this.contextMenuStrip_Settings.Name = "contextMenuStrip_Settings";
            this.contextMenuStrip_Settings.Size = new System.Drawing.Size(173, 48);
            this.contextMenuStrip_Settings.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Settings_Opening);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Browser.Properties.Resources.iconfinder_circle_more_detail_glyph_763454_1_;
            this.pictureBox1.Location = new System.Drawing.Point(681, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBox_ReloadSite
            // 
            this.pictureBox_ReloadSite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ReloadSite.Image = global::Browser.Properties.Resources.unpressedReload;
            this.pictureBox_ReloadSite.Location = new System.Drawing.Point(91, 15);
            this.pictureBox_ReloadSite.Name = "pictureBox_ReloadSite";
            this.pictureBox_ReloadSite.Size = new System.Drawing.Size(27, 26);
            this.pictureBox_ReloadSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ReloadSite.TabIndex = 12;
            this.pictureBox_ReloadSite.TabStop = false;
            this.pictureBox_ReloadSite.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox_ReloadSite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ReloadSite_MouseDown);
            this.pictureBox_ReloadSite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ReloadSite_MouseUp);
            // 
            // pictureBox_CloseTab
            // 
            this.pictureBox_CloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_CloseTab.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CloseTab.Image = global::Browser.Properties.Resources.iconfinder_icon_minus_round_211863;
            this.pictureBox_CloseTab.Location = new System.Drawing.Point(738, 15);
            this.pictureBox_CloseTab.Name = "pictureBox_CloseTab";
            this.pictureBox_CloseTab.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_CloseTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CloseTab.TabIndex = 11;
            this.pictureBox_CloseTab.TabStop = false;
            this.pictureBox_CloseTab.Visible = false;
            this.pictureBox_CloseTab.Click += new System.EventHandler(this.pictureBox_CloseTab_Click);
            this.pictureBox_CloseTab.MouseLeave += new System.EventHandler(this.pictureBox_CloseTab_MouseLeave);
            this.pictureBox_CloseTab.MouseHover += new System.EventHandler(this.pictureBox_CloseTab_MouseHover);
            // 
            // pictureBox_NewTab
            // 
            this.pictureBox_NewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_NewTab.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_NewTab.Image = global::Browser.Properties.Resources.iconfinder_add_126583;
            this.pictureBox_NewTab.Location = new System.Drawing.Point(766, 15);
            this.pictureBox_NewTab.Name = "pictureBox_NewTab";
            this.pictureBox_NewTab.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_NewTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_NewTab.TabIndex = 10;
            this.pictureBox_NewTab.TabStop = false;
            this.pictureBox_NewTab.Click += new System.EventHandler(this.pictureBox_NewTab_Click);
            this.pictureBox_NewTab.MouseLeave += new System.EventHandler(this.pictureBox_NewTab_MouseLeave);
            this.pictureBox_NewTab.MouseHover += new System.EventHandler(this.pictureBox_NewTab_MouseHover);
            // 
            // pictureBox_Favs
            // 
            this.pictureBox_Favs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Favs.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Favs.Image = global::Browser.Properties.Resources.iconfinder_star_circle_353442;
            this.pictureBox_Favs.Location = new System.Drawing.Point(655, 17);
            this.pictureBox_Favs.Name = "pictureBox_Favs";
            this.pictureBox_Favs.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Favs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Favs.TabIndex = 9;
            this.pictureBox_Favs.TabStop = false;
            this.pictureBox_Favs.Click += new System.EventHandler(this.pictureBox_Favs_Click);
            this.pictureBox_Favs.MouseLeave += new System.EventHandler(this.pictureBox_Favs_MouseLeave);
            this.pictureBox_Favs.MouseHover += new System.EventHandler(this.pictureBox_Favs_MouseHover);
            // 
            // pictureBox_Go
            // 
            this.pictureBox_Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Go.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Go.Image = global::Browser.Properties.Resources.iconfinder_130_ArrowRightDouble_183527;
            this.pictureBox_Go.Location = new System.Drawing.Point(629, 17);
            this.pictureBox_Go.Name = "pictureBox_Go";
            this.pictureBox_Go.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Go.TabIndex = 6;
            this.pictureBox_Go.TabStop = false;
            this.pictureBox_Go.Click += new System.EventHandler(this.pictureBox_Go_Click);
            this.pictureBox_Go.MouseLeave += new System.EventHandler(this.pictureBox_Go_MouseLeave);
            this.pictureBox_Go.MouseHover += new System.EventHandler(this.pictureBox_Go_MouseHover);
            // 
            // pictureBox_Forward
            // 
            this.pictureBox_Forward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Forward.Image = global::Browser.Properties.Resources.forward1;
            this.pictureBox_Forward.Location = new System.Drawing.Point(47, 15);
            this.pictureBox_Forward.Name = "pictureBox_Forward";
            this.pictureBox_Forward.Size = new System.Drawing.Size(27, 26);
            this.pictureBox_Forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Forward.TabIndex = 4;
            this.pictureBox_Forward.TabStop = false;
            this.pictureBox_Forward.Click += new System.EventHandler(this.pictureBox_Forward_Click);
            this.pictureBox_Forward.MouseLeave += new System.EventHandler(this.pictureBox_Forward_MouseLeave);
            this.pictureBox_Forward.MouseHover += new System.EventHandler(this.pictureBox_Forward_MouseHover);
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Back.Image = global::Browser.Properties.Resources.back;
            this.pictureBox_Back.Location = new System.Drawing.Point(11, 15);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(27, 26);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Back.TabIndex = 3;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            this.pictureBox_Back.MouseLeave += new System.EventHandler(this.pictureBox_Back_MouseLeave);
            this.pictureBox_Back.MouseHover += new System.EventHandler(this.pictureBox_Back_MouseHover);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Image = global::Browser.Properties.Resources.iconfinder_icons_exit2_1564506;
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // заПриложениетоToolStripMenuItem
            // 
            this.заПриложениетоToolStripMenuItem.Image = global::Browser.Properties.Resources.iconfinder_info_outline_326659;
            this.заПриложениетоToolStripMenuItem.Name = "заПриложениетоToolStripMenuItem";
            this.заПриложениетоToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.заПриложениетоToolStripMenuItem.Text = "За приложението";
            this.заПриложениетоToolStripMenuItem.Click += new System.EventHandler(this.заПриложениетоToolStripMenuItem_Click);
            // 
            // BrowserFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_ReloadSite);
            this.Controls.Add(this.pictureBox_CloseTab);
            this.Controls.Add(this.pictureBox_NewTab);
            this.Controls.Add(this.pictureBox_Favs);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox_Go);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.pictureBox_Forward);
            this.Controls.Add(this.pictureBox_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserFormNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChromZilla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrowserFormNew_Load);
            this.SizeChanged += new System.EventHandler(this.BrowserFormNew_SizeChanged);
            this.Click += new System.EventHandler(this.BrowserFormNew_Click);
            this.Resize += new System.EventHandler(this.BrowserFormNew_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ReloadSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CloseTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NewTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Favs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.PictureBox pictureBox_Forward;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.PictureBox pictureBox_Go;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox_Favs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_NewTab;
        private System.Windows.Forms.PictureBox pictureBox_CloseTab;
        private System.Windows.Forms.WebBrowser webBrowser2;
        //private System.Windows.Forms.PictureBox pictureBox4;
        //private System.Windows.Forms.PictureBox pictureBox3;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FavsList;
        private System.Windows.Forms.Label label_FavsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_DeleteSelectedIndex;
        private System.Windows.Forms.Button button_DeleteAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_ReloadSite;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заПриложениетоToolStripMenuItem;
    }
}