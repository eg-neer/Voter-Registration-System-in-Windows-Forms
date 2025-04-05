namespace Voter_Registration_System
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            pBoxBack = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnRegister = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            label3 = new Label();
            cboxShowPass = new CheckBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pBoxBack).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pBoxBack
            // 
            pBoxBack.Image = (Image)resources.GetObject("pBoxBack.Image");
            pBoxBack.Location = new Point(887, 31);
            pBoxBack.Name = "pBoxBack";
            pBoxBack.Size = new Size(37, 34);
            pBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxBack.TabIndex = 3;
            pBoxBack.TabStop = false;
            pBoxBack.Click += pBoxBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 573);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 258);
            label5.Name = "label5";
            label5.Size = new Size(292, 24);
            label5.TabIndex = 2;
            label5.Text = "Voter Management System";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Goldenrod;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(36, 508);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(305, 30);
            btnRegister.TabIndex = 1;
            btnRegister.Text = " Register Here!";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(131, 484);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 0;
            label4.Text = "No Account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(448, 110);
            label1.Name = "label1";
            label1.Size = new Size(219, 36);
            label1.TabIndex = 5;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(461, 193);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(461, 217);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(381, 23);
            txbUsername.TabIndex = 7;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(461, 306);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(381, 23);
            txbPassword.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 282);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // cboxShowPass
            // 
            cboxShowPass.AutoSize = true;
            cboxShowPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxShowPass.Location = new Point(721, 335);
            cboxShowPass.Name = "cboxShowPass";
            cboxShowPass.Size = new Size(127, 21);
            cboxShowPass.TabIndex = 10;
            cboxShowPass.Text = "Show Password";
            cboxShowPass.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(461, 416);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 47);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyDown += btnLogin_KeyDown;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(936, 573);
            Controls.Add(btnLogin);
            Controls.Add(cboxShowPass);
            Controls.Add(txbPassword);
            Controls.Add(label3);
            Controls.Add(txbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pBoxBack);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            KeyDown += btnLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pBoxBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxBack;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private Label label3;
        private CheckBox cboxShowPass;
        private Button btnRegister;
        private Label label4;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label5;
    }
}