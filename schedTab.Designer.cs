namespace Voter_Registration_System
{
    partial class schedTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schedTab));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnRegister = new Button();
            sidePanel = new Panel();
            btnLogin = new Button();
            btnSchedule = new Button();
            btnHome = new Button();
            pBoxBack = new PictureBox();
            panel3 = new Panel();
            labelCountdown = new Label();
            label1 = new Label();
            flowLayoutPanelSchedule = new FlowLayoutPanel();
            cboxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBack).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 1080);
            panel1.TabIndex = 4;
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
            btnRegister.Location = new Point(14, 997);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(207, 83);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Gold;
            sidePanel.Location = new Point(0, 332);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 83);
            sidePanel.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(14, 510);
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
            // pBoxBack
            // 
            pBoxBack.Image = (Image)resources.GetObject("pBoxBack.Image");
            pBoxBack.Location = new Point(1871, 31);
            pBoxBack.Name = "pBoxBack";
            pBoxBack.Size = new Size(37, 34);
            pBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxBack.TabIndex = 7;
            pBoxBack.TabStop = false;
            pBoxBack.Click += pBoxBack_Click;
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
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCountdown.ForeColor = SystemColors.ActiveCaptionText;
            labelCountdown.Location = new Point(254, 62);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(464, 65);
            labelCountdown.TabIndex = 9;
            labelCountdown.Text = "00 Days 00 : 00 : 00";
            labelCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(264, 126);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 10;
            label1.Text = "until the 2025 Midterm Elections";
            // 
            // flowLayoutPanelSchedule
            // 
            flowLayoutPanelSchedule.AutoScroll = true;
            flowLayoutPanelSchedule.Location = new Point(241, 177);
            flowLayoutPanelSchedule.Name = "flowLayoutPanelSchedule";
            flowLayoutPanelSchedule.Size = new Size(1667, 891);
            flowLayoutPanelSchedule.TabIndex = 11;
            // 
            // cboxFilter
            // 
            cboxFilter.FormattingEnabled = true;
            cboxFilter.Items.AddRange(new object[] { "Upcoming", "Ongoing", "Archived" });
            cboxFilter.Location = new Point(1769, 131);
            cboxFilter.Name = "cboxFilter";
            cboxFilter.Size = new Size(139, 23);
            cboxFilter.TabIndex = 12;
            cboxFilter.SelectedIndexChanged += cboxFilter_SelectedIndexChanged;
            // 
            // schedTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(cboxFilter);
            Controls.Add(flowLayoutPanelSchedule);
            Controls.Add(label1);
            Controls.Add(labelCountdown);
            Controls.Add(panel3);
            Controls.Add(pBoxBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "schedTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "shcedTab";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel sidePanel;
        private Button btnLogin;
        private Button btnSchedule;
        private Button btnHome;
        private Button btnRegister;
        private PictureBox pBoxBack;
        private Panel panel3;
        private Label labelCountdown;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelSchedule;
        private ComboBox cboxFilter;
    }
}