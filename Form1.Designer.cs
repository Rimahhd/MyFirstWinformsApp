namespace MyFirstWinformsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TripdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.MyPhotoBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to winforms app";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(12, 107);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(257, 23);
            this.NametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your Name Here";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 175);
            this.PhoneTextBox.Mask = "(999) 00-000000";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(257, 23);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Your Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Your birth date";
            // 
            // DOBTextBox
            // 
            this.DOBTextBox.Location = new System.Drawing.Point(14, 238);
            this.DOBTextBox.Mask = "00/00/0000";
            this.DOBTextBox.Name = "DOBTextBox";
            this.DOBTextBox.Size = new System.Drawing.Size(255, 23);
            this.DOBTextBox.TabIndex = 6;
            this.DOBTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // TripdateTimePicker
            // 
            this.TripdateTimePicker.Location = new System.Drawing.Point(12, 365);
            this.TripdateTimePicker.Name = "TripdateTimePicker";
            this.TripdateTimePicker.Size = new System.Drawing.Size(279, 23);
            this.TripdateTimePicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter date and time of your trip";
            // 
            // MyPhotoBox
            // 
            this.MyPhotoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyPhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPhotoBox.Location = new System.Drawing.Point(662, 49);
            this.MyPhotoBox.Name = "MyPhotoBox";
            this.MyPhotoBox.Size = new System.Drawing.Size(326, 325);
            this.MyPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPhotoBox.TabIndex = 9;
            this.MyPhotoBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(794, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Your Photo Here";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter Your email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(14, 301);
            this.EmailTextBox.Mask = "aaaaaaaaa@aaaaaaaaaaa.com";
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(257, 23);
            this.EmailTextBox.TabIndex = 12;
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.EnterBtn.Location = new System.Drawing.Point(862, 401);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(126, 37);
            this.EnterBtn.TabIndex = 13;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadBtn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.UploadBtn.Location = new System.Drawing.Point(662, 9);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(126, 37);
            this.UploadBtn.TabIndex = 14;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Location = new System.Drawing.Point(730, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paris",
            "London",
            "Rome",
            "Athen",
            "Beirut",
            "Cairo",
            "Istamboul"});
            this.comboBox1.Location = new System.Drawing.Point(308, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 23);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Paris",
            "London",
            "Rome",
            "Athen",
            "Beirut",
            "Cairo",
            "Istamboul"});
            this.comboBox2.Location = new System.Drawing.Point(308, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 23);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(308, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Your Departure City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(308, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Your Destination City";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(310, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 25);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "First CLass";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MyPhotoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TripdateTimePicker);
            this.Controls.Add(this.DOBTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Name = "Form1";
            this.Text = "This is a form";
            ((System.ComponentModel.ISupportInitialize)(this.MyPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NametextBox;
        private Label label2;
        private MaskedTextBox PhoneTextBox;
        private Label label3;
        private Label label4;
        private MaskedTextBox DOBTextBox;
        private DateTimePicker TripdateTimePicker;
        private Label label5;
        private PictureBox MyPhotoBox;
        private Label label6;
        private Label label7;
        private MaskedTextBox EmailTextBox;
        private Button EnterBtn;
        private Button UploadBtn;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
    }
}