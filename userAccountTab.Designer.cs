namespace Voter_Registration_System
{
    partial class userAccountTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAccountTab));
            labelUser = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSignOut = new Button();
            sidePanel = new Panel();
            btnAccount = new Button();
            btnSchedule = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            pboxID = new PictureBox();
            dgvUser = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.WhiteSmoke;
            labelUser.Location = new Point(80, 37);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(46, 42);
            labelUser.TabIndex = 6;
            labelUser.Text = "Hi \r\nUser!\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 1080);
            panel1.TabIndex = 7;
            // 
            // btnSignOut
            // 
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Image = (Image)resources.GetObject("btnSignOut.Image");
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(14, 997);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(207, 83);
            btnSignOut.TabIndex = 9;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Gold;
            sidePanel.Location = new Point(0, 332);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 83);
            sidePanel.TabIndex = 3;
            // 
            // btnAccount
            // 
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(14, 510);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(207, 83);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "          Account";
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(14, 421);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(206, 83);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "          Schedule";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(14, 332);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(207, 83);
            btnHome.TabIndex = 0;
            btnHome.Text = "          Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(221, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1699, 25);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(pboxID);
            panel4.Location = new Point(1240, 367);
            panel4.Name = "panel4";
            panel4.Size = new Size(498, 377);
            panel4.TabIndex = 12;
            // 
            // pboxID
            // 
            pboxID.Location = new Point(20, 13);
            pboxID.Name = "pboxID";
            pboxID.Size = new Size(461, 354);
            pboxID.SizeMode = PictureBoxSizeMode.Zoom;
            pboxID.TabIndex = 0;
            pboxID.TabStop = false;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(346, 277);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.Size = new Size(618, 592);
            dgvUser.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(1240, 1038);
            label1.Name = "label1";
            label1.Size = new Size(664, 21);
            label1.TabIndex = 14;
            label1.Text = "For any corrections or corrections, please send an email to info.votermanagement@gmail.com.\r\n";
            // 
            // userAccountTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(dgvUser);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userAccountTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userAccountTab";
            Load += userAccountTab_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel sidePanel;
        private Button btnAccount;
        private Button btnSchedule;
        private Button btnHome;
        private Panel panel3;
        private Button btnSignOut;
        private Panel panel4;
        private PictureBox pboxID;
        private DataGridView dgvUser;
        private Label label1;
    }
}