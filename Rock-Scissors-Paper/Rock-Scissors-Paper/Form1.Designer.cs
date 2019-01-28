namespace Rock_Scissors_Paper
{
    partial class Form1
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
            this.pictureBox_ComputerChoose = new System.Windows.Forms.PictureBox();
            this.pictureBox_Scissors = new System.Windows.Forms.PictureBox();
            this.pictureBox_Paper = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerChoose = new System.Windows.Forms.PictureBox();
            this.pictureBox_Rock = new System.Windows.Forms.PictureBox();
            this.label_EnterNameText = new System.Windows.Forms.Label();
            this.textBox_playerName = new System.Windows.Forms.TextBox();
            this.label_playerName = new System.Windows.Forms.Label();
            this.label_Computer = new System.Windows.Forms.Label();
            this.label_ResultText = new System.Windows.Forms.Label();
            this.label_PLayerResult = new System.Windows.Forms.Label();
            this.label_ComputerResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComputerChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ComputerChoose
            // 
            this.pictureBox_ComputerChoose.Location = new System.Drawing.Point(189, 79);
            this.pictureBox_ComputerChoose.Name = "pictureBox_ComputerChoose";
            this.pictureBox_ComputerChoose.Size = new System.Drawing.Size(68, 70);
            this.pictureBox_ComputerChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ComputerChoose.TabIndex = 4;
            this.pictureBox_ComputerChoose.TabStop = false;
            // 
            // pictureBox_Scissors
            // 
            this.pictureBox_Scissors.Image = global::Rock_Scissors_Paper.Properties.Resources.Scissors;
            this.pictureBox_Scissors.Location = new System.Drawing.Point(105, 168);
            this.pictureBox_Scissors.Name = "pictureBox_Scissors";
            this.pictureBox_Scissors.Size = new System.Drawing.Size(68, 70);
            this.pictureBox_Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Scissors.TabIndex = 3;
            this.pictureBox_Scissors.TabStop = false;
            this.pictureBox_Scissors.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox_Paper
            // 
            this.pictureBox_Paper.Image = global::Rock_Scissors_Paper.Properties.Resources.Paper;
            this.pictureBox_Paper.Location = new System.Drawing.Point(189, 168);
            this.pictureBox_Paper.Name = "pictureBox_Paper";
            this.pictureBox_Paper.Size = new System.Drawing.Size(68, 70);
            this.pictureBox_Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Paper.TabIndex = 2;
            this.pictureBox_Paper.TabStop = false;
            this.pictureBox_Paper.Click += new System.EventHandler(this.pictureBox_Paper_Click);
            // 
            // pictureBox_PlayerChoose
            // 
            this.pictureBox_PlayerChoose.Location = new System.Drawing.Point(24, 79);
            this.pictureBox_PlayerChoose.Name = "pictureBox_PlayerChoose";
            this.pictureBox_PlayerChoose.Size = new System.Drawing.Size(68, 70);
            this.pictureBox_PlayerChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerChoose.TabIndex = 1;
            this.pictureBox_PlayerChoose.TabStop = false;
            // 
            // pictureBox_Rock
            // 
            this.pictureBox_Rock.Image = global::Rock_Scissors_Paper.Properties.Resources.Rock;
            this.pictureBox_Rock.Location = new System.Drawing.Point(24, 168);
            this.pictureBox_Rock.Name = "pictureBox_Rock";
            this.pictureBox_Rock.Size = new System.Drawing.Size(68, 70);
            this.pictureBox_Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Rock.TabIndex = 0;
            this.pictureBox_Rock.TabStop = false;
            this.pictureBox_Rock.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_EnterNameText
            // 
            this.label_EnterNameText.AutoSize = true;
            this.label_EnterNameText.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EnterNameText.Location = new System.Drawing.Point(8, 15);
            this.label_EnterNameText.Name = "label_EnterNameText";
            this.label_EnterNameText.Size = new System.Drawing.Size(163, 25);
            this.label_EnterNameText.TabIndex = 5;
            this.label_EnterNameText.Text = "Enter your name: ";
            // 
            // textBox_playerName
            // 
            this.textBox_playerName.BackColor = System.Drawing.Color.Cyan;
            this.textBox_playerName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_playerName.Location = new System.Drawing.Point(168, 19);
            this.textBox_playerName.Name = "textBox_playerName";
            this.textBox_playerName.Size = new System.Drawing.Size(100, 21);
            this.textBox_playerName.TabIndex = 6;
            this.textBox_playerName.TextChanged += new System.EventHandler(this.textBox_playerName_TextChanged);
            // 
            // label_playerName
            // 
            this.label_playerName.AutoSize = true;
            this.label_playerName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerName.Location = new System.Drawing.Point(23, 59);
            this.label_playerName.Name = "label_playerName";
            this.label_playerName.Size = new System.Drawing.Size(12, 15);
            this.label_playerName.TabIndex = 7;
            this.label_playerName.Text = " ";
            // 
            // label_Computer
            // 
            this.label_Computer.AutoSize = true;
            this.label_Computer.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Computer.Location = new System.Drawing.Point(188, 61);
            this.label_Computer.Name = "label_Computer";
            this.label_Computer.Size = new System.Drawing.Size(65, 15);
            this.label_Computer.TabIndex = 8;
            this.label_Computer.Text = "Computer";
            // 
            // label_ResultText
            // 
            this.label_ResultText.AutoSize = true;
            this.label_ResultText.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ResultText.ForeColor = System.Drawing.Color.Red;
            this.label_ResultText.Location = new System.Drawing.Point(100, 79);
            this.label_ResultText.Name = "label_ResultText";
            this.label_ResultText.Size = new System.Drawing.Size(73, 28);
            this.label_ResultText.TabIndex = 9;
            this.label_ResultText.Text = "Result";
            // 
            // label_PLayerResult
            // 
            this.label_PLayerResult.AutoSize = true;
            this.label_PLayerResult.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PLayerResult.ForeColor = System.Drawing.Color.Red;
            this.label_PLayerResult.Location = new System.Drawing.Point(100, 107);
            this.label_PLayerResult.Name = "label_PLayerResult";
            this.label_PLayerResult.Size = new System.Drawing.Size(24, 28);
            this.label_PLayerResult.TabIndex = 10;
            this.label_PLayerResult.Text = "0";
            // 
            // label_ComputerResult
            // 
            this.label_ComputerResult.AutoSize = true;
            this.label_ComputerResult.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ComputerResult.ForeColor = System.Drawing.Color.Red;
            this.label_ComputerResult.Location = new System.Drawing.Point(149, 107);
            this.label_ComputerResult.Name = "label_ComputerResult";
            this.label_ComputerResult.Size = new System.Drawing.Size(24, 28);
            this.label_ComputerResult.TabIndex = 11;
            this.label_ComputerResult.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // button_Start
            // 
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Start.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.ForeColor = System.Drawing.Color.Green;
            this.button_Start.Location = new System.Drawing.Point(24, 256);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(68, 23);
            this.button_Start.TabIndex = 13;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Reset.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Reset.Location = new System.Drawing.Point(105, 256);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(68, 23);
            this.button_Reset.TabIndex = 15;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Close.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(185, 256);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(68, 23);
            this.button_Close.TabIndex = 16;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(283, 302);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ComputerResult);
            this.Controls.Add(this.label_PLayerResult);
            this.Controls.Add(this.label_ResultText);
            this.Controls.Add(this.label_Computer);
            this.Controls.Add(this.label_playerName);
            this.Controls.Add(this.textBox_playerName);
            this.Controls.Add(this.label_EnterNameText);
            this.Controls.Add(this.pictureBox_ComputerChoose);
            this.Controls.Add(this.pictureBox_Scissors);
            this.Controls.Add(this.pictureBox_Paper);
            this.Controls.Add(this.pictureBox_PlayerChoose);
            this.Controls.Add(this.pictureBox_Rock);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock Scissors Paper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComputerChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Rock;
        private System.Windows.Forms.PictureBox pictureBox_PlayerChoose;
        private System.Windows.Forms.PictureBox pictureBox_Paper;
        private System.Windows.Forms.PictureBox pictureBox_Scissors;
        private System.Windows.Forms.PictureBox pictureBox_ComputerChoose;
        private System.Windows.Forms.Label label_EnterNameText;
        private System.Windows.Forms.TextBox textBox_playerName;
        private System.Windows.Forms.Label label_playerName;
        private System.Windows.Forms.Label label_Computer;
        private System.Windows.Forms.Label label_ResultText;
        private System.Windows.Forms.Label label_PLayerResult;
        private System.Windows.Forms.Label label_ComputerResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Close;
    }
}

