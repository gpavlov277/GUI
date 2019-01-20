namespace Week2
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
            this.label_ChooseModel = new System.Windows.Forms.Label();
            this.radioButton_Audi = new System.Windows.Forms.RadioButton();
            this.radioButton_BMW = new System.Windows.Forms.RadioButton();
            this.radioButton_Mercedes = new System.Windows.Forms.RadioButton();
            this.label_AddsText = new System.Windows.Forms.Label();
            this.checkBox_ABS = new System.Windows.Forms.CheckBox();
            this.checkBox_Lights = new System.Windows.Forms.CheckBox();
            this.checkBox_Alarm = new System.Windows.Forms.CheckBox();
            this.label_PriceText = new System.Windows.Forms.Label();
            this.label_PriceValue = new System.Windows.Forms.Label();
            this.label_PayInCash = new System.Windows.Forms.Label();
            this.checkBox_PayInCash = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox_Auto = new System.Windows.Forms.PictureBox();
            this.labelPriceText = new System.Windows.Forms.Label();
            this.labelFinalPriceText = new System.Windows.Forms.Label();
            this.labelDiscountText = new System.Windows.Forms.Label();
            this.label_DiscountValue = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label_PriceValueExtraAdds = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_CloseForm = new System.Windows.Forms.Button();
            this.label_FinalPriceVlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Auto)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ChooseModel
            // 
            this.label_ChooseModel.AutoSize = true;
            this.label_ChooseModel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseModel.Location = new System.Drawing.Point(53, 12);
            this.label_ChooseModel.Name = "label_ChooseModel";
            this.label_ChooseModel.Size = new System.Drawing.Size(151, 18);
            this.label_ChooseModel.TabIndex = 1;
            this.label_ChooseModel.Text = "Choose your model ";
            // 
            // radioButton_Audi
            // 
            this.radioButton_Audi.AutoSize = true;
            this.radioButton_Audi.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Audi.Location = new System.Drawing.Point(56, 46);
            this.radioButton_Audi.Name = "radioButton_Audi";
            this.radioButton_Audi.Size = new System.Drawing.Size(55, 19);
            this.radioButton_Audi.TabIndex = 2;
            this.radioButton_Audi.TabStop = true;
            this.radioButton_Audi.Text = "Audi";
            this.radioButton_Audi.UseVisualStyleBackColor = true;
            this.radioButton_Audi.CheckedChanged += new System.EventHandler(this.radioButton_Audi_CheckedChanged);
            // 
            // radioButton_BMW
            // 
            this.radioButton_BMW.AutoSize = true;
            this.radioButton_BMW.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BMW.Location = new System.Drawing.Point(56, 81);
            this.radioButton_BMW.Name = "radioButton_BMW";
            this.radioButton_BMW.Size = new System.Drawing.Size(61, 19);
            this.radioButton_BMW.TabIndex = 3;
            this.radioButton_BMW.TabStop = true;
            this.radioButton_BMW.Text = "BMW";
            this.radioButton_BMW.UseVisualStyleBackColor = true;
            this.radioButton_BMW.CheckedChanged += new System.EventHandler(this.radioButton_BMW_CheckedChanged);
            // 
            // radioButton_Mercedes
            // 
            this.radioButton_Mercedes.AutoSize = true;
            this.radioButton_Mercedes.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Mercedes.Location = new System.Drawing.Point(56, 115);
            this.radioButton_Mercedes.Name = "radioButton_Mercedes";
            this.radioButton_Mercedes.Size = new System.Drawing.Size(80, 19);
            this.radioButton_Mercedes.TabIndex = 4;
            this.radioButton_Mercedes.TabStop = true;
            this.radioButton_Mercedes.Text = "Mercedes";
            this.radioButton_Mercedes.UseVisualStyleBackColor = true;
            this.radioButton_Mercedes.CheckedChanged += new System.EventHandler(this.radioButton_Mercedes_CheckedChanged);
            // 
            // label_AddsText
            // 
            this.label_AddsText.AutoSize = true;
            this.label_AddsText.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddsText.Location = new System.Drawing.Point(53, 188);
            this.label_AddsText.Name = "label_AddsText";
            this.label_AddsText.Size = new System.Drawing.Size(99, 18);
            this.label_AddsText.TabIndex = 5;
            this.label_AddsText.Text = "Extra  Adds";
            // 
            // checkBox_ABS
            // 
            this.checkBox_ABS.AutoSize = true;
            this.checkBox_ABS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ABS.Location = new System.Drawing.Point(56, 220);
            this.checkBox_ABS.Name = "checkBox_ABS";
            this.checkBox_ABS.Size = new System.Drawing.Size(54, 19);
            this.checkBox_ABS.TabIndex = 6;
            this.checkBox_ABS.Text = "ABS";
            this.checkBox_ABS.UseVisualStyleBackColor = true;
            this.checkBox_ABS.CheckedChanged += new System.EventHandler(this.checkBox_ABS_CheckedChanged);
            // 
            // checkBox_Lights
            // 
            this.checkBox_Lights.AutoSize = true;
            this.checkBox_Lights.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Lights.Location = new System.Drawing.Point(56, 243);
            this.checkBox_Lights.Name = "checkBox_Lights";
            this.checkBox_Lights.Size = new System.Drawing.Size(116, 19);
            this.checkBox_Lights.TabIndex = 7;
            this.checkBox_Lights.Text = "Lights for fog";
            this.checkBox_Lights.UseVisualStyleBackColor = true;
            this.checkBox_Lights.CheckedChanged += new System.EventHandler(this.checkBox_Lights_CheckedChanged);
            // 
            // checkBox_Alarm
            // 
            this.checkBox_Alarm.AutoSize = true;
            this.checkBox_Alarm.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Alarm.Location = new System.Drawing.Point(56, 266);
            this.checkBox_Alarm.Name = "checkBox_Alarm";
            this.checkBox_Alarm.Size = new System.Drawing.Size(65, 19);
            this.checkBox_Alarm.TabIndex = 8;
            this.checkBox_Alarm.Text = "Alram";
            this.checkBox_Alarm.UseVisualStyleBackColor = true;
            this.checkBox_Alarm.CheckedChanged += new System.EventHandler(this.checkBox_Alarm_CheckedChanged);
            // 
            // label_PriceText
            // 
            this.label_PriceText.AutoSize = true;
            this.label_PriceText.ForeColor = System.Drawing.Color.Red;
            this.label_PriceText.Location = new System.Drawing.Point(53, 149);
            this.label_PriceText.Name = "label_PriceText";
            this.label_PriceText.Size = new System.Drawing.Size(37, 13);
            this.label_PriceText.TabIndex = 9;
            this.label_PriceText.Text = "Price: ";
            // 
            // label_PriceValue
            // 
            this.label_PriceValue.AutoSize = true;
            this.label_PriceValue.ForeColor = System.Drawing.Color.Red;
            this.label_PriceValue.Location = new System.Drawing.Point(84, 149);
            this.label_PriceValue.Name = "label_PriceValue";
            this.label_PriceValue.Size = new System.Drawing.Size(31, 13);
            this.label_PriceValue.TabIndex = 10;
            this.label_PriceValue.Text = "Price";
            // 
            // label_PayInCash
            // 
            this.label_PayInCash.AutoSize = true;
            this.label_PayInCash.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_PayInCash.Location = new System.Drawing.Point(53, 301);
            this.label_PayInCash.Name = "label_PayInCash";
            this.label_PayInCash.Size = new System.Drawing.Size(133, 13);
            this.label_PayInCash.TabIndex = 11;
            this.label_PayInCash.Text = "Pay in cash and get 5% off";
            // 
            // checkBox_PayInCash
            // 
            this.checkBox_PayInCash.AutoSize = true;
            this.checkBox_PayInCash.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_PayInCash.Location = new System.Drawing.Point(56, 327);
            this.checkBox_PayInCash.Name = "checkBox_PayInCash";
            this.checkBox_PayInCash.Size = new System.Drawing.Size(89, 18);
            this.checkBox_PayInCash.TabIndex = 12;
            this.checkBox_PayInCash.Text = "Pay in cash";
            this.checkBox_PayInCash.UseVisualStyleBackColor = true;
            this.checkBox_PayInCash.CheckedChanged += new System.EventHandler(this.checkBox_PayInCash_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(420, 384);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(888, 349);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Auto
            // 
            this.pictureBox_Auto.BackgroundImage = global::Week2.Properties.Resources.mercedes;
            this.pictureBox_Auto.Image = global::Week2.Properties.Resources.Guess_the_car_sounds_655x368;
            this.pictureBox_Auto.Location = new System.Drawing.Point(228, 29);
            this.pictureBox_Auto.Name = "pictureBox_Auto";
            this.pictureBox_Auto.Size = new System.Drawing.Size(394, 256);
            this.pictureBox_Auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Auto.TabIndex = 0;
            this.pictureBox_Auto.TabStop = false;
            // 
            // labelPriceText
            // 
            this.labelPriceText.AutoSize = true;
            this.labelPriceText.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceText.Location = new System.Drawing.Point(225, 296);
            this.labelPriceText.Name = "labelPriceText";
            this.labelPriceText.Size = new System.Drawing.Size(51, 18);
            this.labelPriceText.TabIndex = 14;
            this.labelPriceText.Text = "Price:";
            // 
            // labelFinalPriceText
            // 
            this.labelFinalPriceText.AutoSize = true;
            this.labelFinalPriceText.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPriceText.Location = new System.Drawing.Point(223, 332);
            this.labelFinalPriceText.Name = "labelFinalPriceText";
            this.labelFinalPriceText.Size = new System.Drawing.Size(96, 18);
            this.labelFinalPriceText.TabIndex = 15;
            this.labelFinalPriceText.Text = "Final price:";
            // 
            // labelDiscountText
            // 
            this.labelDiscountText.AutoSize = true;
            this.labelDiscountText.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountText.Location = new System.Drawing.Point(223, 314);
            this.labelDiscountText.Name = "labelDiscountText";
            this.labelDiscountText.Size = new System.Drawing.Size(79, 18);
            this.labelDiscountText.TabIndex = 16;
            this.labelDiscountText.Text = "Discount:";
            // 
            // label_DiscountValue
            // 
            this.label_DiscountValue.AutoSize = true;
            this.label_DiscountValue.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiscountValue.Location = new System.Drawing.Point(299, 314);
            this.label_DiscountValue.Name = "label_DiscountValue";
            this.label_DiscountValue.Size = new System.Drawing.Size(79, 18);
            this.label_DiscountValue.TabIndex = 17;
            this.label_DiscountValue.Text = "Discount:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(46, 374);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 18;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label_PriceValueExtraAdds
            // 
            this.label_PriceValueExtraAdds.AutoSize = true;
            this.label_PriceValueExtraAdds.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PriceValueExtraAdds.Location = new System.Drawing.Point(273, 296);
            this.label_PriceValueExtraAdds.Name = "label_PriceValueExtraAdds";
            this.label_PriceValueExtraAdds.Size = new System.Drawing.Size(51, 18);
            this.label_PriceValueExtraAdds.TabIndex = 19;
            this.label_PriceValueExtraAdds.Text = "Price:";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(129, 374);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 20;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_CloseForm
            // 
            this.button_CloseForm.Location = new System.Drawing.Point(210, 374);
            this.button_CloseForm.Name = "button_CloseForm";
            this.button_CloseForm.Size = new System.Drawing.Size(75, 23);
            this.button_CloseForm.TabIndex = 21;
            this.button_CloseForm.Text = "Close";
            this.button_CloseForm.UseVisualStyleBackColor = true;
            this.button_CloseForm.Click += new System.EventHandler(this.button_CloseForm_Click);
            // 
            // label_FinalPriceVlue
            // 
            this.label_FinalPriceVlue.AutoSize = true;
            this.label_FinalPriceVlue.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FinalPriceVlue.Location = new System.Drawing.Point(319, 332);
            this.label_FinalPriceVlue.Name = "label_FinalPriceVlue";
            this.label_FinalPriceVlue.Size = new System.Drawing.Size(96, 18);
            this.label_FinalPriceVlue.TabIndex = 22;
            this.label_FinalPriceVlue.Text = "Final price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 419);
            this.Controls.Add(this.label_FinalPriceVlue);
            this.Controls.Add(this.button_CloseForm);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label_PriceValueExtraAdds);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label_DiscountValue);
            this.Controls.Add(this.labelDiscountText);
            this.Controls.Add(this.labelFinalPriceText);
            this.Controls.Add(this.labelPriceText);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox_PayInCash);
            this.Controls.Add(this.label_PayInCash);
            this.Controls.Add(this.label_PriceValue);
            this.Controls.Add(this.label_PriceText);
            this.Controls.Add(this.checkBox_Alarm);
            this.Controls.Add(this.checkBox_Lights);
            this.Controls.Add(this.checkBox_ABS);
            this.Controls.Add(this.label_AddsText);
            this.Controls.Add(this.radioButton_Mercedes);
            this.Controls.Add(this.radioButton_BMW);
            this.Controls.Add(this.radioButton_Audi);
            this.Controls.Add(this.label_ChooseModel);
            this.Controls.Add(this.pictureBox_Auto);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Configure Your Own Auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Auto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Auto;
        private System.Windows.Forms.Label label_ChooseModel;
        private System.Windows.Forms.RadioButton radioButton_Audi;
        private System.Windows.Forms.RadioButton radioButton_BMW;
        private System.Windows.Forms.RadioButton radioButton_Mercedes;
        private System.Windows.Forms.Label label_AddsText;
        private System.Windows.Forms.CheckBox checkBox_ABS;
        private System.Windows.Forms.CheckBox checkBox_Lights;
        private System.Windows.Forms.CheckBox checkBox_Alarm;
        private System.Windows.Forms.Label label_PriceText;
        private System.Windows.Forms.Label label_PriceValue;
        private System.Windows.Forms.Label label_PayInCash;
        private System.Windows.Forms.CheckBox checkBox_PayInCash;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelPriceText;
        private System.Windows.Forms.Label labelFinalPriceText;
        private System.Windows.Forms.Label labelDiscountText;
        private System.Windows.Forms.Label label_DiscountValue;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label_PriceValueExtraAdds;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_CloseForm;
        private System.Windows.Forms.Label label_FinalPriceVlue;
    }
}

