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
            label7 = new Label();
            pictureBox1 = new PictureBox();
            sidePanel = new Panel();
            btnStatistics = new Button();
            btnSearch = new Button();
            btnList = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            txbLname = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            txbFname = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvVoters = new DataGridView();
            btnSearch2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoters).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(221, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(715, 25);
            panel3.TabIndex = 28;
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
            btnSignOut.Location = new Point(12, 499);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(209, 74);
            btnSignOut.TabIndex = 9;
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
            // textBox3
            // 
            textBox3.Location = new Point(242, 383);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(239, 359);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 39;
            label6.Text = "Voter ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(490, 450);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(418, 23);
            textBox2.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(487, 426);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 37;
            label5.Text = "Address";
            // 
            // txbLname
            // 
            txbLname.Location = new Point(716, 383);
            txbLname.Name = "txbLname";
            txbLname.Size = new Size(192, 23);
            txbLname.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(713, 359);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 35;
            label3.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 33;
            // 
            // txbFname
            // 
            txbFname.Location = new Point(239, 450);
            txbFname.Name = "txbFname";
            txbFname.Size = new Size(225, 23);
            txbFname.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(462, 359);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 31;
            label4.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 426);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 32;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 314);
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
            dgvVoters.Size = new Size(717, 253);
            dgvVoters.TabIndex = 29;
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.Gold;
            btnSearch2.FlatAppearance.BorderSize = 0;
            btnSearch2.FlatStyle = FlatStyle.Flat;
            btnSearch2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch2.Location = new Point(802, 513);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(106, 34);
            btnSearch2.TabIndex = 41;
            btnSearch2.Text = "Search";
            btnSearch2.UseVisualStyleBackColor = false;
            // 
            // adminSearchTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 573);
            Controls.Add(btnSearch2);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(txbLname);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(txbFname);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVoters).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox txbLname;
        private Label label3;
        private TextBox textBox1;
        private TextBox txbFname;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgvVoters;
        private Button btnSearch2;
    }
}