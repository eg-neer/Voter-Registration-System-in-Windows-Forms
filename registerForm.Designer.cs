﻿namespace Voter_Registration_System
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            pBoxBack = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnLogin = new Button();
            label4 = new Label();
            btnRegister = new Button();
            txbLname = new TextBox();
            label3 = new Label();
            txbFname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboxSex = new ComboBox();
            label6 = new Label();
            dtpDOB = new DateTimePicker();
            label7 = new Label();
            cboxProvince = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cboxMuniCity = new ComboBox();
            label10 = new Label();
            cboxBarangay = new ComboBox();
            label11 = new Label();
            txbEmail = new TextBox();
            label12 = new Label();
            txbMname = new TextBox();
            cboxConsent = new CheckBox();
            btnUpload = new Button();
            label13 = new Label();
            pictureBoxPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxBack).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // pBoxBack
            // 
            pBoxBack.Image = (Image)resources.GetObject("pBoxBack.Image");
            pBoxBack.Location = new Point(887, 31);
            pBoxBack.Name = "pBoxBack";
            pBoxBack.Size = new Size(37, 34);
            pBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxBack.TabIndex = 4;
            pBoxBack.TabStop = false;
            pBoxBack.Click += pBoxBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 573);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 255);
            label5.Name = "label5";
            label5.Size = new Size(292, 24);
            label5.TabIndex = 2;
            label5.Text = "Voter Management System";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Goldenrod;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(36, 508);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(305, 30);
            btnLogin.TabIndex = 1;
            btnLogin.Text = " Login Here!";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(82, 484);
            label4.Name = "label4";
            label4.Size = new Size(224, 21);
            label4.TabIndex = 0;
            label4.Text = "Already have an Account?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gold;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(728, 492);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(141, 47);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txbLname
            // 
            txbLname.Location = new Point(677, 157);
            txbLname.Name = "txbLname";
            txbLname.Size = new Size(192, 23);
            txbLname.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(674, 133);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 15;
            label3.Text = "Last Name";
            // 
            // txbFname
            // 
            txbFname.Location = new Point(406, 157);
            txbFname.Name = "txbFname";
            txbFname.Size = new Size(225, 23);
            txbFname.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(403, 133);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 13;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 68);
            label1.Name = "label1";
            label1.Size = new Size(256, 36);
            label1.TabIndex = 12;
            label1.Text = "Register Account";
            // 
            // cboxSex
            // 
            cboxSex.FormattingEnabled = true;
            cboxSex.Items.AddRange(new object[] { "F", "M" });
            cboxSex.Location = new Point(677, 230);
            cboxSex.Name = "cboxSex";
            cboxSex.Size = new Size(64, 23);
            cboxSex.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(674, 206);
            label6.Name = "label6";
            label6.Size = new Size(36, 21);
            label6.TabIndex = 20;
            label6.Text = "Sex";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(406, 296);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(225, 23);
            dtpDOB.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(404, 272);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 22;
            label7.Text = "Date of Birth";
            // 
            // cboxProvince
            // 
            cboxProvince.FormattingEnabled = true;
            cboxProvince.Items.AddRange(new object[] { "Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Bohol", "Bulacan", "Bukidnon", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Davao del Norte", "Davao del Sur", "Davao Oriental", "Eastern Samar", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao", "NCR, City of Manila, First District", "Marinduque", "Masbate", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "North Cotabato", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar (Western Samar)", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "NCR, Second District", "NCR, Third District", "NCR, Fourth District", "Aurora", "Biliran", "Guimaras", "Sarangani", "Apayao", "Davao de Oro", "Zamboanga Sibugay", "---", "Dinagat Islands", "Davao Occidental", "Maguindanao del Norte", "Maguindanao del Sur" });
            cboxProvince.Location = new Point(406, 364);
            cboxProvince.Name = "cboxProvince";
            cboxProvince.Size = new Size(225, 23);
            cboxProvince.TabIndex = 23;
            cboxProvince.SelectedIndexChanged += cboxProvince_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(402, 340);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 24;
            label8.Text = "Province";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(670, 340);
            label9.Name = "label9";
            label9.Size = new Size(150, 21);
            label9.TabIndex = 26;
            label9.Text = "City / Municipality";
            // 
            // cboxMuniCity
            // 
            cboxMuniCity.FormattingEnabled = true;
            cboxMuniCity.Location = new Point(674, 364);
            cboxMuniCity.Name = "cboxMuniCity";
            cboxMuniCity.Size = new Size(225, 23);
            cboxMuniCity.TabIndex = 25;
            cboxMuniCity.SelectedIndexChanged += cboxMuniCity_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(402, 406);
            label10.Name = "label10";
            label10.Size = new Size(86, 21);
            label10.TabIndex = 28;
            label10.Text = "Barangay";
            // 
            // cboxBarangay
            // 
            cboxBarangay.FormattingEnabled = true;
            cboxBarangay.Location = new Point(406, 430);
            cboxBarangay.Name = "cboxBarangay";
            cboxBarangay.Size = new Size(225, 23);
            cboxBarangay.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(674, 272);
            label11.Name = "label11";
            label11.Size = new Size(117, 21);
            label11.TabIndex = 29;
            label11.Text = "Email Address";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(674, 296);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(225, 23);
            txbEmail.TabIndex = 30;
            txbEmail.Text = "@gmail.com";
            txbEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(406, 206);
            label12.Name = "label12";
            label12.Size = new Size(115, 21);
            label12.TabIndex = 31;
            label12.Text = "Middle Name";
            // 
            // txbMname
            // 
            txbMname.Location = new Point(406, 230);
            txbMname.Name = "txbMname";
            txbMname.Size = new Size(225, 23);
            txbMname.TabIndex = 32;
            // 
            // cboxConsent
            // 
            cboxConsent.AutoSize = true;
            cboxConsent.Location = new Point(674, 432);
            cboxConsent.Name = "cboxConsent";
            cboxConsent.Size = new Size(166, 19);
            cboxConsent.TabIndex = 33;
            cboxConsent.Text = "Oath, Notice, and Consent";
            cboxConsent.UseVisualStyleBackColor = true;
            cboxConsent.Click += cboxConsent_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(413, 494);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 34;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(406, 470);
            label13.Name = "label13";
            label13.Size = new Size(223, 21);
            label13.TabIndex = 35;
            label13.Text = "Add Government Issued ID";
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(512, 494);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(119, 67);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 36;
            pictureBoxPhoto.TabStop = false;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 573);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(label13);
            Controls.Add(btnUpload);
            Controls.Add(cboxConsent);
            Controls.Add(txbMname);
            Controls.Add(label12);
            Controls.Add(txbEmail);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboxBarangay);
            Controls.Add(label9);
            Controls.Add(cboxMuniCity);
            Controls.Add(label8);
            Controls.Add(cboxProvince);
            Controls.Add(label7);
            Controls.Add(dtpDOB);
            Controls.Add(label6);
            Controls.Add(cboxSex);
            Controls.Add(btnRegister);
            Controls.Add(txbLname);
            Controls.Add(label3);
            Controls.Add(txbFname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pBoxBack);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerForm";
            Load += registerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxBack;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnLogin;
        private Label label4;
        private Button btnRegister;
        private TextBox txbLname;
        private Label label3;
        private TextBox txbFname;
        private Label label2;
        private Label label1;
        private ComboBox cboxSex;
        private Label label6;
        private DateTimePicker dtpDOB;
        private Label label7;
        private ComboBox cboxProvince;
        private Label label8;
        private Label label9;
        private ComboBox cboxMuniCity;
        private Label label10;
        private ComboBox cboxBarangay;
        private Label label11;
        private TextBox txbEmail;
        private Label label12;
        private TextBox txbMname;
        private CheckBox cboxConsent;
        private Button btnUpload;
        private Label label13;
        private PictureBox pictureBoxPhoto;
    }
}