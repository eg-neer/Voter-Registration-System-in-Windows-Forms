namespace Voter_Registration_System
{
    partial class adminStatisticsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminStatisticsTab));
            panel3 = new Panel();
            panel1 = new Panel();
            btnSignOut = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            sidePanel = new Panel();
            btnStatistics = new Button();
            btnSearch = new Button();
            btnList = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(221, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(715, 25);
            panel3.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnStatistics);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnList);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 573);
            panel1.TabIndex = 29;
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
            btnSignOut.Location = new Point(12, 499);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(209, 74);
            btnSignOut.TabIndex = 10;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(80, 37);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 8;
            label7.Text = "Hi Admin!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Gold;
            sidePanel.Location = new Point(0, 126);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 83);
            sidePanel.TabIndex = 3;
            // 
            // btnStatistics
            // 
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(12, 304);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(207, 83);
            btnStatistics.TabIndex = 3;
            btnStatistics.Text = "          Statistics";
            btnStatistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(12, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(206, 83);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "          Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnList
            // 
            btnList.FlatAppearance.BorderSize = 0;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnList.ForeColor = Color.White;
            btnList.Image = (Image)resources.GetObject("btnList.Image");
            btnList.ImageAlign = ContentAlignment.MiddleLeft;
            btnList.Location = new Point(12, 126);
            btnList.Name = "btnList";
            btnList.Size = new Size(207, 83);
            btnList.TabIndex = 0;
            btnList.Text = "          List";
            btnList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // adminStatisticsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 573);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminStatisticsTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminStatisticsTab";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel sidePanel;
        private Button btnStatistics;
        private Button btnSearch;
        private Button btnList;
        private Button btnSignOut;
    }
}