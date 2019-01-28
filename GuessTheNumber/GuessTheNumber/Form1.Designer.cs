namespace GuessTheNumber
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
            this.comboBox_LevelChoose = new System.Windows.Forms.ComboBox();
            this.label_LevelText = new System.Windows.Forms.Label();
            this.button_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_InputDigit = new System.Windows.Forms.TextBox();
            this.button_Go = new System.Windows.Forms.Button();
            this.label_TriesText = new System.Windows.Forms.Label();
            this.pictureBox_Result = new System.Windows.Forms.PictureBox();
            this.pictureBox_upDown = new System.Windows.Forms.PictureBox();
            this.label_GuessText = new System.Windows.Forms.Label();
            this.label2_Tries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_LevelChoose
            // 
            this.comboBox_LevelChoose.FormattingEnabled = true;
            this.comboBox_LevelChoose.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox_LevelChoose.Items.AddRange(new object[] {
            "1-10",
            "1-50",
            "1-100",
            "1-1000"});
            this.comboBox_LevelChoose.Location = new System.Drawing.Point(49, 46);
            this.comboBox_LevelChoose.Name = "comboBox_LevelChoose";
            this.comboBox_LevelChoose.Size = new System.Drawing.Size(141, 21);
            this.comboBox_LevelChoose.TabIndex = 0;
            // 
            // label_LevelText
            // 
            this.label_LevelText.AutoSize = true;
            this.label_LevelText.Location = new System.Drawing.Point(92, 30);
            this.label_LevelText.Name = "label_LevelText";
            this.label_LevelText.Size = new System.Drawing.Size(72, 13);
            this.label_LevelText.TabIndex = 1;
            this.label_LevelText.Text = "Choose Level";
            // 
            // button_Play
            // 
            this.button_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Play.Location = new System.Drawing.Point(264, 40);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(75, 28);
            this.button_Play.TabIndex = 2;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // textBox_InputDigit
            // 
            this.textBox_InputDigit.Location = new System.Drawing.Point(49, 109);
            this.textBox_InputDigit.Name = "textBox_InputDigit";
            this.textBox_InputDigit.Size = new System.Drawing.Size(141, 20);
            this.textBox_InputDigit.TabIndex = 5;
            this.textBox_InputDigit.TextChanged += new System.EventHandler(this.textBox_InputDigit_TextChanged);
            this.textBox_InputDigit.Enter += new System.EventHandler(this.textBox_InputDigit_Enter);
            this.textBox_InputDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InputDigit_KeyPress);
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(64, 262);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(100, 23);
            this.button_Go.TabIndex = 6;
            this.button_Go.Text = "Go!";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_TriesText
            // 
            this.label_TriesText.AutoSize = true;
            this.label_TriesText.Location = new System.Drawing.Point(97, 232);
            this.label_TriesText.Name = "label_TriesText";
            this.label_TriesText.Size = new System.Drawing.Size(35, 13);
            this.label_TriesText.TabIndex = 8;
            this.label_TriesText.Text = "label2";
            // 
            // pictureBox_Result
            // 
            this.pictureBox_Result.Location = new System.Drawing.Point(250, 135);
            this.pictureBox_Result.Name = "pictureBox_Result";
            this.pictureBox_Result.Size = new System.Drawing.Size(100, 89);
            this.pictureBox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Result.TabIndex = 7;
            this.pictureBox_Result.TabStop = false;
            // 
            // pictureBox_upDown
            // 
            this.pictureBox_upDown.Location = new System.Drawing.Point(64, 135);
            this.pictureBox_upDown.Name = "pictureBox_upDown";
            this.pictureBox_upDown.Size = new System.Drawing.Size(100, 89);
            this.pictureBox_upDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_upDown.TabIndex = 4;
            this.pictureBox_upDown.TabStop = false;
            // 
            // label_GuessText
            // 
            this.label_GuessText.AutoSize = true;
            this.label_GuessText.Location = new System.Drawing.Point(53, 93);
            this.label_GuessText.Name = "label_GuessText";
            this.label_GuessText.Size = new System.Drawing.Size(134, 13);
            this.label_GuessText.TabIndex = 9;
            this.label_GuessText.Text = "Guess the random number!";
            // 
            // label2_Tries
            // 
            this.label2_Tries.AutoSize = true;
            this.label2_Tries.Location = new System.Drawing.Point(61, 232);
            this.label2_Tries.Name = "label2_Tries";
            this.label2_Tries.Size = new System.Drawing.Size(33, 13);
            this.label2_Tries.TabIndex = 10;
            this.label2_Tries.Text = "Tries:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 384);
            this.Controls.Add(this.label2_Tries);
            this.Controls.Add(this.label_GuessText);
            this.Controls.Add(this.label_TriesText);
            this.Controls.Add(this.pictureBox_Result);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.textBox_InputDigit);
            this.Controls.Add(this.pictureBox_upDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.label_LevelText);
            this.Controls.Add(this.comboBox_LevelChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_upDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_LevelChoose;
        private System.Windows.Forms.Label label_LevelText;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_upDown;
        private System.Windows.Forms.TextBox textBox_InputDigit;
        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.PictureBox pictureBox_Result;
        private System.Windows.Forms.Label label_TriesText;
        private System.Windows.Forms.Label label_GuessText;
        private System.Windows.Forms.Label label2_Tries;
    }
}

