namespace Voter_Registration_System
{
    partial class adminSearchTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminSearchTab));
            panel3 = new Panel();
            panel1 = new Panel();
            btnSignOut = new Button();
            labelAdmin = new Label();
            pictureBox1 = new PictureBox();
            sidePanel = new Panel();
            btnStatistics = new Button();
            btnSearch = new Button();
            btnList = new Button();
            txbVoterID = new TextBox();
            label6 = new Label();
            txbProvince = new TextBox();
            label5 = new Label();
            txbLname = new TextBox();
            label3 = new Label();
            txbFname = new TextBox();
            txbStatus = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvVoters = new DataGridView();
            btnSearch2 = new Button();
            panel4 = new Panel();
            pboxID = new PictureBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            txbRegisDate = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txbBrgy = new TextBox();
            label8 = new Label();
            txbMunicity = new TextBox();
            label7 = new Label();
            txbDOB = new TextBox();
            txbMname = new TextBox();
            label11 = new Label();
            txbLastVoted = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoters).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxID).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(221, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1699, 25);
            panel3.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(labelAdmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnStatistics);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnList);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 1080);
            panel1.TabIndex = 27;
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
            // txbVoterID
            // 
            txbVoterID.Location = new Point(264, 828);
            txbVoterID.Name = "txbVoterID";
            txbVoterID.ReadOnly = true;
            txbVoterID.Size = new Size(192, 23);
            txbVoterID.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(264, 804);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 39;
            label6.Text = "Voter ID";
            // 
            // txbProvince
            // 
            txbProvince.Location = new Point(264, 985);
            txbProvince.Name = "txbProvince";
            txbProvince.Size = new Size(192, 23);
            txbProvince.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 961);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 37;
            label5.Text = "Province";
            // 
            // txbLname
            // 
            txbLname.Location = new Point(725, 828);
            txbLname.Name = "txbLname";
            txbLname.Size = new Size(192, 23);
            txbLname.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(722, 804);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 35;
            label3.Text = "Last Name";
            // 
            // txbFname
            // 
            txbFname.Location = new Point(496, 828);
            txbFname.Name = "txbFname";
            txbFname.Size = new Size(192, 23);
            txbFname.TabIndex = 33;
            // 
            // txbStatus
            // 
            txbStatus.BackColor = SystemColors.Window;
            txbStatus.Location = new Point(264, 904);
            txbStatus.Name = "txbStatus";
            txbStatus.ReadOnly = true;
            txbStatus.Size = new Size(192, 23);
            txbStatus.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(496, 804);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 31;
            label4.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 880);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 32;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 756);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 30;
            label1.Text = "Voter Details";
            // 
            // dgvVoters
            // 
            dgvVoters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoters.Location = new Point(219, 31);
            dgvVoters.Name = "dgvVoters";
            dgvVoters.ReadOnly = true;
            dgvVoters.Size = new Size(1689, 697);
            dgvVoters.TabIndex = 29;
            dgvVoters.CellClick += dgvVoters_CellClick;
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.Gold;
            btnSearch2.FlatAppearance.BorderSize = 0;
            btnSearch2.FlatStyle = FlatStyle.Flat;
            btnSearch2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch2.Location = new Point(1762, 986);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(136, 68);
            btnSearch2.TabIndex = 41;
            btnSearch2.Text = "Search";
            btnSearch2.UseVisualStyleBackColor = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(pboxID);
            panel4.Location = new Point(1403, 756);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 298);
            panel4.TabIndex = 42;
            // 
            // pboxID
            // 
            pboxID.Location = new Point(12, 15);
            pboxID.Name = "pboxID";
            pboxID.Size = new Size(301, 273);
            pboxID.SizeMode = PictureBoxSizeMode.Zoom;
            pboxID.TabIndex = 0;
            pboxID.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(1762, 896);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 68);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(1762, 802);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 68);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbRegisDate
            // 
            txbRegisDate.Location = new Point(728, 910);
            txbRegisDate.Name = "txbRegisDate";
            txbRegisDate.Size = new Size(189, 23);
            txbRegisDate.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(725, 886);
            label10.Name = "label10";
            label10.Size = new Size(137, 21);
            label10.TabIndex = 50;
            label10.Text = "Date Registered";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(495, 884);
            label9.Name = "label9";
            label9.Size = new Size(107, 21);
            label9.TabIndex = 49;
            label9.Text = "Date of Birth";
            // 
            // txbBrgy
            // 
            txbBrgy.Location = new Point(728, 988);
            txbBrgy.Name = "txbBrgy";
            txbBrgy.Size = new Size(189, 23);
            txbBrgy.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(725, 964);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 47;
            label8.Text = "Barangay";
            // 
            // txbMunicity
            // 
            txbMunicity.Location = new Point(496, 988);
            txbMunicity.Name = "txbMunicity";
            txbMunicity.Size = new Size(192, 23);
            txbMunicity.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(496, 964);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 45;
            label7.Text = "City / Municipality";
            // 
            // txbDOB
            // 
            txbDOB.Location = new Point(496, 904);
            txbDOB.Name = "txbDOB";
            txbDOB.Size = new Size(192, 23);
            txbDOB.TabIndex = 52;
            // 
            // txbMname
            // 
            txbMname.Location = new Point(961, 828);
            txbMname.Name = "txbMname";
            txbMname.Size = new Size(192, 23);
            txbMname.TabIndex = 54;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(958, 804);
            label11.Name = "label11";
            label11.Size = new Size(115, 21);
            label11.TabIndex = 53;
            label11.Text = "Middle Name";
            // 
            // txbLastVoted
            // 
            txbLastVoted.Location = new Point(961, 904);
            txbLastVoted.Name = "txbLastVoted";
            txbLastVoted.Size = new Size(189, 23);
            txbLastVoted.TabIndex = 56;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(958, 880);
            label12.Name = "label12";
            label12.Size = new Size(94, 21);
            label12.TabIndex = 55;
            label12.Text = "Last Voted";
            // 
            // adminSearchTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(txbLastVoted);
            Controls.Add(label12);
            Controls.Add(txbMname);
            Controls.Add(label11);
            Controls.Add(txbDOB);
            Controls.Add(txbRegisDate);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txbBrgy);
            Controls.Add(label8);
            Controls.Add(txbMunicity);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(panel4);
            Controls.Add(btnSearch2);
            Controls.Add(txbVoterID);
            Controls.Add(label6);
            Controls.Add(txbProvince);
            Controls.Add(label5);
            Controls.Add(txbLname);
            Controls.Add(label3);
            Controls.Add(txbFname);
            Controls.Add(txbStatus);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvVoters);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminSearchTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminSearchTab";
            Load += adminSearchTab_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoters).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Label labelAdmin;
        private PictureBox pictureBox1;
        private Panel sidePanel;
        private Button btnStatistics;
        private Button btnSearch;
        private Button btnList;
        private Button btnSignOut;
        private TextBox txbVoterID;
        private Label label6;
        private TextBox txbProvince;
        private Label label5;
        private TextBox txbLname;
        private Label label3;
        private TextBox txbFname;
        private TextBox txbStatus;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgvVoters;
        private Button btnSearch2;
        private Panel panel4;
        private PictureBox pboxID;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txbRegisDate;
        private Label label10;
        private Label label9;
        private TextBox txbBrgy;
        private Label label8;
        private TextBox txbMunicity;
        private Label label7;
        private TextBox txbDOB;
        private TextBox txbMname;
        private Label label11;
        private TextBox txbLastVoted;
        private Label label12;
    }
}