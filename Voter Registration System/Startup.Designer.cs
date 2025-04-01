namespace Voter_Registration_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            sidePanel = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            btnSchedule = new Button();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pBoxExit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxExit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 573);
            panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Gold;
            sidePanel.Location = new Point(0, 126);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 83);
            sidePanel.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(12, 524);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(209, 49);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(12, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 83);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "          Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(12, 215);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(206, 83);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "          Schedule";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(12, 126);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(207, 83);
            btnHome.TabIndex = 0;
            btnHome.Text = "          Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(221, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(715, 25);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(715, 25);
            panel3.TabIndex = 2;
            // 
            // pBoxExit
            // 
            pBoxExit.Image = (Image)resources.GetObject("pBoxExit.Image");
            pBoxExit.Location = new Point(887, 31);
            pBoxExit.Name = "pBoxExit";
            pBoxExit.Size = new Size(37, 34);
            pBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxExit.TabIndex = 2;
            pBoxExit.TabStop = false;
            pBoxExit.Click += pBoxExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(936, 573);
            Controls.Add(pBoxExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHome;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnSchedule;
        private PictureBox pBoxExit;
        private Panel sidePanel;
    }
}
