namespace Voter_Registration_System
{
    partial class userDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userDashboard));
            panel1 = new Panel();
            labelUSer = new Label();
            btnSignOut = new Button();
            sidePanel = new Panel();
            btnAccount = new Button();
            btnSchedule = new Button();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            panel3 = new Panel();
            dgvSenators = new DataGridView();
            dgvPartylist = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            labelCountdown = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSenators).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartylist).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(labelUSer);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 1080);
            panel1.TabIndex = 3;
            // 
            // labelUSer
            // 
            labelUSer.AutoSize = true;
            labelUSer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUSer.ForeColor = Color.WhiteSmoke;
            labelUSer.Location = new Point(80, 37);
            labelUSer.Name = "labelUSer";
            labelUSer.Size = new Size(64, 21);
            labelUSer.TabIndex = 6;
            labelUSer.Text = "Hi User!";
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
            btnSignOut.TabIndex = 5;
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
            panel3.TabIndex = 5;
            // 
            // dgvSenators
            // 
            dgvSenators.AllowUserToAddRows = false;
            dgvSenators.AllowUserToDeleteRows = false;
            dgvSenators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSenators.Location = new Point(390, 180);
            dgvSenators.Name = "dgvSenators";
            dgvSenators.ReadOnly = true;
            dgvSenators.Size = new Size(542, 888);
            dgvSenators.TabIndex = 6;
            // 
            // dgvPartylist
            // 
            dgvPartylist.AllowUserToAddRows = false;
            dgvPartylist.AllowUserToDeleteRows = false;
            dgvPartylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartylist.Location = new Point(1055, 180);
            dgvPartylist.Name = "dgvPartylist";
            dgvPartylist.ReadOnly = true;
            dgvPartylist.Size = new Size(542, 888);
            dgvPartylist.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(1206, 143);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 15;
            label2.Text = "PARTY LIST / Vote for 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(544, 143);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 14;
            label1.Text = "SENATOR / Vote for 12";
            // 
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCountdown.ForeColor = SystemColors.ActiveCaptionText;
            labelCountdown.Location = new Point(503, 49);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(1010, 65);
            labelCountdown.TabIndex = 13;
            labelCountdown.Text = "2025 Phillipine General Election Candidates";
            labelCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCountdown);
            Controls.Add(dgvPartylist);
            Controls.Add(dgvSenators);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userDashboard";
            Load += userDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSenators).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartylist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel sidePanel;
        private Button btnAccount;
        private Button btnSchedule;
        private PictureBox pictureBox1;
        private Button btnHome;
        private Button btnSignOut;
        private Label labelUSer;
        private Panel panel3;
        private DataGridView dgvSenators;
        private DataGridView dgvPartylist;
        private Label label2;
        private Label label1;
        private Label labelCountdown;
    }
}