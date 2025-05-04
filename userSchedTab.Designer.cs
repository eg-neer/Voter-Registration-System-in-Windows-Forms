namespace Voter_Registration_System
{
    partial class userSchedTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSchedTab));
            labelUSer = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSignOut = new Button();
            sidePanel = new Panel();
            btnAccount = new Button();
            btnSchedule = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            label1 = new Label();
            labelCountdown = new Label();
            cboxFilter = new ComboBox();
            flowLayoutPanelSchedule = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUSer
            // 
            labelUSer.AutoSize = true;
            labelUSer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUSer.ForeColor = Color.WhiteSmoke;
            labelUSer.Location = new Point(80, 37);
            labelUSer.Name = "labelUSer";
            labelUSer.Size = new Size(46, 42);
            labelUSer.TabIndex = 6;
            labelUSer.Text = "Hi \r\nUser!";
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
            panel1.Controls.Add(labelUSer);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 1080);
            panel1.TabIndex = 6;
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
            btnSignOut.TabIndex = 8;
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
            panel3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(264, 126);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 12;
            label1.Text = "until the 2025 Midterm Elections";
            // 
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCountdown.ForeColor = SystemColors.ActiveCaptionText;
            labelCountdown.Location = new Point(254, 62);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(464, 65);
            labelCountdown.TabIndex = 11;
            labelCountdown.Text = "00 Days 00 : 00 : 00";
            labelCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboxFilter
            // 
            cboxFilter.FormattingEnabled = true;
            cboxFilter.Items.AddRange(new object[] { "Upcoming", "Ongoing", "Archived" });
            cboxFilter.Location = new Point(1769, 131);
            cboxFilter.Name = "cboxFilter";
            cboxFilter.Size = new Size(139, 23);
            cboxFilter.TabIndex = 13;
            // 
            // flowLayoutPanelSchedule
            // 
            flowLayoutPanelSchedule.AutoScroll = true;
            flowLayoutPanelSchedule.Location = new Point(241, 177);
            flowLayoutPanelSchedule.Name = "flowLayoutPanelSchedule";
            flowLayoutPanelSchedule.Size = new Size(1667, 891);
            flowLayoutPanelSchedule.TabIndex = 14;
            // 
            // userSchedTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(flowLayoutPanelSchedule);
            Controls.Add(cboxFilter);
            Controls.Add(label1);
            Controls.Add(labelCountdown);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userSchedTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userSchedTab";
            Load += userSchedTab_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUSer;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnSignOut;
        private Panel sidePanel;
        private Button btnAccount;
        private Button btnSchedule;
        private Button btnHome;
        private Panel panel3;
        private Label label1;
        private Label labelCountdown;
        private ComboBox cboxFilter;
        private FlowLayoutPanel flowLayoutPanelSchedule;
    }
}