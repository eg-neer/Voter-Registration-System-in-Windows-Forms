namespace Voter_Registration_System
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            panel1 = new Panel();
            labelAdmin = new Label();
            pictureBox1 = new PictureBox();
            btnSignOut = new Button();
            sidePanel = new Panel();
            btnStatistics = new Button();
            btnSearch = new Button();
            btnList = new Button();
            dgvApplicants = new DataGridView();
            txbMname = new TextBox();
            label3 = new Label();
            txbStatus = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txbFname = new TextBox();
            tbxProvince = new TextBox();
            label5 = new Label();
            txbLname = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            btnApprove = new Button();
            btnDecline = new Button();
            panel4 = new Panel();
            pboxID = new PictureBox();
            txbMunicity = new TextBox();
            label7 = new Label();
            txbBrgy = new TextBox();
            label8 = new Label();
            txbDOB = new TextBox();
            label9 = new Label();
            txbAppDate = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxID).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(labelAdmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnStatistics);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnList);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 1080);
            panel1.TabIndex = 3;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = Color.WhiteSmoke;
            labelAdmin.Location = new Point(80, 37);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(84, 21);
            labelAdmin.TabIndex = 8;
            labelAdmin.Text = "Hi Admin!";
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
            btnSignOut.TabIndex = 6;
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
            // btnStatistics
            // 
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(14, 510);
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
            btnSearch.Location = new Point(14, 421);
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
            btnList.Location = new Point(14, 332);
            btnList.Name = "btnList";
            btnList.Size = new Size(207, 83);
            btnList.TabIndex = 0;
            btnList.Text = "          Pending List";
            btnList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dgvApplicants
            // 
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicants.Location = new Point(219, 31);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.ReadOnly = true;
            dgvApplicants.Size = new Size(1689, 697);
            dgvApplicants.TabIndex = 5;
            dgvApplicants.CellClick += dgvApplicants_CellClick;
            // 
            // txbMname
            // 
            txbMname.Location = new Point(786, 827);
            txbMname.Name = "txbMname";
            txbMname.Size = new Size(192, 23);
            txbMname.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(783, 803);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 20;
            label3.Text = "Middle Name";
            // 
            // txbStatus
            // 
            txbStatus.Location = new Point(274, 903);
            txbStatus.Name = "txbStatus";
            txbStatus.Size = new Size(192, 23);
            txbStatus.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(274, 879);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 18;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 756);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 17;
            label1.Text = "Applicant Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(511, 803);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 18;
            label4.Text = "First Name";
            // 
            // txbFname
            // 
            txbFname.Location = new Point(514, 827);
            txbFname.Name = "txbFname";
            txbFname.Size = new Size(225, 23);
            txbFname.TabIndex = 19;
            // 
            // tbxProvince
            // 
            tbxProvince.Location = new Point(277, 981);
            tbxProvince.Name = "tbxProvince";
            tbxProvince.Size = new Size(189, 23);
            tbxProvince.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(274, 957);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 22;
            label5.Text = "Province";
            // 
            // txbLname
            // 
            txbLname.Location = new Point(274, 827);
            txbLname.Name = "txbLname";
            txbLname.Size = new Size(192, 23);
            txbLname.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(271, 803);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 24;
            label6.Text = "Last Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(221, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1699, 25);
            panel3.TabIndex = 26;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Gold;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApprove.Location = new Point(1792, 1020);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(106, 34);
            btnApprove.TabIndex = 27;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.Black;
            btnDecline.FlatAppearance.BorderSize = 0;
            btnDecline.FlatStyle = FlatStyle.Flat;
            btnDecline.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecline.ForeColor = Color.White;
            btnDecline.Location = new Point(1680, 1020);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(106, 34);
            btnDecline.TabIndex = 28;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(pboxID);
            panel4.Location = new Point(1107, 770);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 259);
            panel4.TabIndex = 29;
            // 
            // pboxID
            // 
            pboxID.Location = new Point(11, 8);
            pboxID.Name = "pboxID";
            pboxID.Size = new Size(258, 244);
            pboxID.SizeMode = PictureBoxSizeMode.Zoom;
            pboxID.TabIndex = 0;
            pboxID.TabStop = false;
            // 
            // txbMunicity
            // 
            txbMunicity.Location = new Point(517, 981);
            txbMunicity.Name = "txbMunicity";
            txbMunicity.Size = new Size(222, 23);
            txbMunicity.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(514, 957);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 30;
            label7.Text = "City / Municipality";
            // 
            // txbBrgy
            // 
            txbBrgy.Location = new Point(786, 981);
            txbBrgy.Name = "txbBrgy";
            txbBrgy.Size = new Size(189, 23);
            txbBrgy.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(783, 957);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 32;
            label8.Text = "Barangay";
            // 
            // txbDOB
            // 
            txbDOB.Location = new Point(517, 903);
            txbDOB.Name = "txbDOB";
            txbDOB.Size = new Size(222, 23);
            txbDOB.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(514, 879);
            label9.Name = "label9";
            label9.Size = new Size(107, 21);
            label9.TabIndex = 34;
            label9.Text = "Date of Birth";
            // 
            // txbAppDate
            // 
            txbAppDate.Location = new Point(786, 903);
            txbAppDate.Name = "txbAppDate";
            txbAppDate.Size = new Size(189, 23);
            txbAppDate.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(783, 879);
            label10.Name = "label10";
            label10.Size = new Size(146, 21);
            label10.TabIndex = 36;
            label10.Text = "Application Date";
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(txbAppDate);
            Controls.Add(label10);
            Controls.Add(txbDOB);
            Controls.Add(label9);
            Controls.Add(txbBrgy);
            Controls.Add(label8);
            Controls.Add(txbMunicity);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(btnDecline);
            Controls.Add(btnApprove);
            Controls.Add(panel3);
            Controls.Add(txbLname);
            Controls.Add(label6);
            Controls.Add(tbxProvince);
            Controls.Add(label5);
            Controls.Add(txbMname);
            Controls.Add(label3);
            Controls.Add(txbFname);
            Controls.Add(txbStatus);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvApplicants);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminDashboard";
            Load += adminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel sidePanel;
        private Button btnStatistics;
        private Button btnSearch;
        private Button btnList;
        private DataGridView dgvApplicants;
        private Button btnSignOut;
        private TextBox txbMname;
        private Label label3;
        private TextBox txbStatus;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txbFname;
        private TextBox tbxProvince;
        private Label label5;
        private TextBox txbLname;
        private Label label6;
        private Label labelAdmin;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnApprove;
        private Button btnDecline;
        private Panel panel4;
        private PictureBox pboxID;
        private TextBox txbMunicity;
        private Label label7;
        private TextBox txbBrgy;
        private Label label8;
        private TextBox txbDOB;
        private Label label9;
        private TextBox txbAppDate;
        private Label label10;
    }
}