namespace BloodBankManagementSystem
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpositiveCount = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblOnegative = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.lblAnegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApositiveCount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegativeCount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblABpositiveCount = new System.Windows.Forms.Label();
            this.lblABpositive = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBpositiveCount = new System.Windows.Forms.Label();
            this.lblBpositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(8, 12, 0, 12);
            this.menuStripTop.Size = new System.Drawing.Size(1513, 51);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            this.menuStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripTop_ItemClicked);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorsToolStripMenuItem.Image")));
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.lblDeveloper);
            this.panelFooter.Controls.Add(this.lblDevTitle);
            this.panelFooter.Controls.Add(this.lblAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 701);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1513, 50);
            this.panelFooter.TabIndex = 1;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.Transparent;
            this.lblDeveloper.Image = ((System.Drawing.Image)(resources.GetObject("lblDeveloper.Image")));
            this.lblDeveloper.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDeveloper.Location = new System.Drawing.Point(990, 6);
            this.lblDeveloper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(124, 37);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "FUSASIS";
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDevTitle.Location = new System.Drawing.Point(730, 6);
            this.lblDevTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(248, 37);
            this.lblDevTitle.TabIndex = 1;
            this.lblDevTitle.Text = "co-engineered with";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Red;
            this.lblAppName.Location = new System.Drawing.Point(320, 6);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(401, 37);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "bloodbank Management System";
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpositive.Controls.Add(this.lblName);
            this.panelOpositive.Controls.Add(this.lblOpositiveCount);
            this.panelOpositive.Controls.Add(this.lblBloodGroup);
            this.panelOpositive.Location = new System.Drawing.Point(16, 100);
            this.panelOpositive.Margin = new System.Windows.Forms.Padding(4);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(267, 123);
            this.panelOpositive.TabIndex = 2;
            this.panelOpositive.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpositive_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(151, 73);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Donors";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblOpositiveCount
            // 
            this.lblOpositiveCount.AutoSize = true;
            this.lblOpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOpositiveCount.Location = new System.Drawing.Point(143, 14);
            this.lblOpositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpositiveCount.Name = "lblOpositiveCount";
            this.lblOpositiveCount.Size = new System.Drawing.Size(97, 60);
            this.lblOpositiveCount.TabIndex = 1;
            this.lblOpositiveCount.Text = "100";
            this.lblOpositiveCount.Click += new System.EventHandler(this.lblOpositiveCount_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBloodGroup.Location = new System.Drawing.Point(4, 18);
            this.lblBloodGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(122, 81);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "O+";
            this.lblBloodGroup.Click += new System.EventHandler(this.lblBloodGroup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegativeCount);
            this.panel1.Controls.Add(this.lblOnegative);
            this.panel1.Location = new System.Drawing.Point(305, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegativeCount.Location = new System.Drawing.Point(143, 14);
            this.lblOnegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(97, 60);
            this.lblOnegativeCount.TabIndex = 1;
            this.lblOnegativeCount.Text = "100";
            // 
            // lblOnegative
            // 
            this.lblOnegative.AutoSize = true;
            this.lblOnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegative.Location = new System.Drawing.Point(4, 18);
            this.lblOnegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnegative.Name = "lblOnegative";
            this.lblOnegative.Size = new System.Drawing.Size(104, 81);
            this.lblOnegative.TabIndex = 0;
            this.lblOnegative.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAnegativeCount);
            this.panel2.Controls.Add(this.lblAnegative);
            this.panel2.Location = new System.Drawing.Point(305, 250);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Donors";
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegativeCount.Location = new System.Drawing.Point(143, 14);
            this.lblAnegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(97, 60);
            this.lblAnegativeCount.TabIndex = 1;
            this.lblAnegativeCount.Text = "100";
            // 
            // lblAnegative
            // 
            this.lblAnegative.AutoSize = true;
            this.lblAnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegative.Location = new System.Drawing.Point(4, 18);
            this.lblAnegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnegative.Name = "lblAnegative";
            this.lblAnegative.Size = new System.Drawing.Size(101, 81);
            this.lblAnegative.TabIndex = 0;
            this.lblAnegative.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblApositiveCount);
            this.panel3.Controls.Add(this.lblApositive);
            this.panel3.Location = new System.Drawing.Point(16, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 123);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            this.lblApositiveCount.AutoSize = true;
            this.lblApositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApositiveCount.Location = new System.Drawing.Point(143, 14);
            this.lblApositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApositiveCount.Name = "lblApositiveCount";
            this.lblApositiveCount.Size = new System.Drawing.Size(97, 60);
            this.lblApositiveCount.TabIndex = 1;
            this.lblApositiveCount.Text = "100";
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApositive.Location = new System.Drawing.Point(4, 18);
            this.lblApositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(119, 81);
            this.lblApositive.TabIndex = 0;
            this.lblApositive.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABnegativeCount);
            this.panel4.Controls.Add(this.lblABnegative);
            this.panel4.Location = new System.Drawing.Point(305, 537);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 123);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(151, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            this.lblABnegativeCount.AutoSize = true;
            this.lblABnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegativeCount.Location = new System.Drawing.Point(143, 14);
            this.lblABnegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABnegativeCount.Name = "lblABnegativeCount";
            this.lblABnegativeCount.Size = new System.Drawing.Size(97, 60);
            this.lblABnegativeCount.TabIndex = 1;
            this.lblABnegativeCount.Text = "100";
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegative.Location = new System.Drawing.Point(4, 18);
            this.lblABnegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(139, 81);
            this.lblABnegative.TabIndex = 0;
            this.lblABnegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblABpositiveCount);
            this.panel5.Controls.Add(this.lblABpositive);
            this.panel5.Location = new System.Drawing.Point(16, 537);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 123);
            this.panel5.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(151, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // lblABpositiveCount
            // 
            this.lblABpositiveCount.AutoSize = true;
            this.lblABpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpositiveCount.Location = new System.Drawing.Point(143, 14);
            this.lblABpositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABpositiveCount.Name = "lblABpositiveCount";
            this.lblABpositiveCount.Size = new System.Drawing.Size(97, 60);
            this.lblABpositiveCount.TabIndex = 1;
            this.lblABpositiveCount.Text = "100";
            // 
            // lblABpositive
            // 
            this.lblABpositive.AutoSize = true;
            this.lblABpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpositive.Location = new System.Drawing.Point(4, 18);
            this.lblABpositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblABpositive.Name = "lblABpositive";
            this.lblABpositive.Size = new System.Drawing.Size(157, 81);
            this.lblABpositive.TabIndex = 0;
            this.lblABpositive.Text = "AB+";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblBnegativeCount);
            this.panel6.Controls.Add(this.lblBnegative);
            this.panel6.Location = new System.Drawing.Point(305, 391);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 123);
            this.panel6.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(151, 73);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegativeCount.Location = new System.Drawing.Point(143, 14);
            this.lblBnegativeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(97, 60);
            this.lblBnegativeCount.TabIndex = 1;
            this.lblBnegativeCount.Text = "100";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegative.Location = new System.Drawing.Point(4, 18);
            this.lblBnegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(97, 81);
            this.lblBnegative.TabIndex = 0;
            this.lblBnegative.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBpositiveCount);
            this.panel7.Controls.Add(this.lblBpositive);
            this.panel7.Location = new System.Drawing.Point(16, 391);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 123);
            this.panel7.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(151, 73);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            this.lblBpositiveCount.AutoSize = true;
            this.lblBpositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpositiveCount.Location = new System.Drawing.Point(143, 14);
            this.lblBpositiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBpositiveCount.Name = "lblBpositiveCount";
            this.lblBpositiveCount.Size = new System.Drawing.Size(97, 60);
            this.lblBpositiveCount.TabIndex = 1;
            this.lblBpositiveCount.Text = "100";
            // 
            // lblBpositive
            // 
            this.lblBpositive.AutoSize = true;
            this.lblBpositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpositive.Location = new System.Drawing.Point(4, 18);
            this.lblBpositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBpositive.Name = "lblBpositive";
            this.lblBpositive.Size = new System.Drawing.Size(115, 81);
            this.lblBpositive.TabIndex = 0;
            this.lblBpositive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(647, 161);
            this.dgvDonors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowHeadersWidth = 51;
            this.dgvDonors.Size = new System.Drawing.Size(839, 498);
            this.dgvDonors.TabIndex = 10;
            this.dgvDonors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonors_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(680, 103);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(114, 28);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Find Donor";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(812, 100);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(672, 34);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.White;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1463, 7);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(41, 36);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUserTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.Location = new System.Drawing.Point(19, 63);
            this.lblUserTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(106, 21);
            this.lblUserTitle.TabIndex = 14;
            this.lblUserTitle.Text = "Current User:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUser.Location = new System.Drawing.Point(134, 63);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(14, 20);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = ".";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1513, 751);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOpositiveCount;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.Label lblAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApositiveCount;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegativeCount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblABpositiveCount;
        private System.Windows.Forms.Label lblABpositive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBpositiveCount;
        private System.Windows.Forms.Label lblBpositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUser;
    }
}

