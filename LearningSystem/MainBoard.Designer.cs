namespace LearningSystem
{
    partial class MainBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.pageTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.customTopicList = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.topicList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboCategories = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.courseList = new System.Windows.Forms.ListBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lecturesTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hoursTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.detailTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.topicList2 = new System.Windows.Forms.ListBox();
            this.courseList2 = new System.Windows.Forms.ListBox();
            this.progressGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.userProgress = new System.Windows.Forms.DataGridView();
            this.listPanel1 = new System.Windows.Forms.Panel();
            this.userList = new System.Windows.Forms.FlowLayoutPanel();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProgress)).BeginInit();
            this.listPanel1.SuspendLayout();
            this.userList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTab
            // 
            this.pageTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageTab.Controls.Add(this.tabPage2);
            this.pageTab.Controls.Add(this.tabPage3);
            this.pageTab.Controls.Add(this.tabPage1);
            this.pageTab.Location = new System.Drawing.Point(0, 31);
            this.pageTab.Name = "pageTab";
            this.pageTab.SelectedIndex = 0;
            this.pageTab.Size = new System.Drawing.Size(1062, 671);
            this.pageTab.TabIndex = 0;
            this.pageTab.SelectedIndexChanged += new System.EventHandler(this.pageTab_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.topicList);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.enrollButton);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 639);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.customTopicList);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(733, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 639);
            this.panel5.TabIndex = 22;
            // 
            // customTopicList
            // 
            this.customTopicList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customTopicList.AutoScroll = true;
            this.customTopicList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customTopicList.Location = new System.Drawing.Point(3, 37);
            this.customTopicList.Name = "customTopicList";
            this.customTopicList.Size = new System.Drawing.Size(312, 604);
            this.customTopicList.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Topics";
            // 
            // topicList
            // 
            this.topicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.topicList.FormattingEnabled = true;
            this.topicList.ItemHeight = 20;
            this.topicList.Location = new System.Drawing.Point(347, 17);
            this.topicList.Name = "topicList";
            this.topicList.Size = new System.Drawing.Size(348, 564);
            this.topicList.TabIndex = 7;
            this.topicList.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboCategories);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.courseList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 639);
            this.panel4.TabIndex = 21;
            // 
            // comboCategories
            // 
            this.comboCategories.DisplayMember = "Category";
            this.comboCategories.FormattingEnabled = true;
            this.comboCategories.Location = new System.Drawing.Point(93, 17);
            this.comboCategories.Name = "comboCategories";
            this.comboCategories.Size = new System.Drawing.Size(219, 21);
            this.comboCategories.TabIndex = 3;
            this.comboCategories.Text = "Categories";
            this.comboCategories.ValueMember = "CourseId";
            this.comboCategories.SelectedIndexChanged += new System.EventHandler(this.comboCategories_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Courses";
            // 
            // courseList
            // 
            this.courseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseList.DisplayMember = "Name";
            this.courseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.courseList.FormattingEnabled = true;
            this.courseList.ItemHeight = 20;
            this.courseList.Location = new System.Drawing.Point(3, 37);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(312, 604);
            this.courseList.TabIndex = 1;
            this.courseList.ValueMember = "Id";
            this.courseList.Click += new System.EventHandler(this.CourseListItem_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(347, 170);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(331, 28);
            this.enrollButton.TabIndex = 2;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lecturesTxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.hoursTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.detailTxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.authorTxt);
            this.panel2.Location = new System.Drawing.Point(347, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 210);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Author";
            // 
            // lecturesTxt
            // 
            this.lecturesTxt.AutoSize = true;
            this.lecturesTxt.Location = new System.Drawing.Point(87, 139);
            this.lecturesTxt.Name = "lecturesTxt";
            this.lecturesTxt.Size = new System.Drawing.Size(54, 15);
            this.lecturesTxt.TabIndex = 19;
            this.lecturesTxt.Text = "Lectures";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Details";
            // 
            // hoursTxt
            // 
            this.hoursTxt.AutoSize = true;
            this.hoursTxt.Location = new System.Drawing.Point(87, 113);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(40, 15);
            this.hoursTxt.TabIndex = 18;
            this.hoursTxt.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hours";
            // 
            // detailTxt
            // 
            this.detailTxt.AutoSize = true;
            this.detailTxt.Location = new System.Drawing.Point(87, 87);
            this.detailTxt.Name = "detailTxt";
            this.detailTxt.Size = new System.Drawing.Size(45, 15);
            this.detailTxt.TabIndex = 17;
            this.detailTxt.Text = "Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lectures";
            // 
            // authorTxt
            // 
            this.authorTxt.AutoSize = true;
            this.authorTxt.Location = new System.Drawing.Point(87, 61);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(42, 15);
            this.authorTxt.TabIndex = 16;
            this.authorTxt.Text = "Author";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainStatus
            // 
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.topicList2);
            this.tabPage3.Controls.Add(this.courseList2);
            this.tabPage3.Controls.Add(this.progressGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1054, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Progress";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Learn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // topicList2
            // 
            this.topicList2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topicList2.DisplayMember = "Name";
            this.topicList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.topicList2.FormattingEnabled = true;
            this.topicList2.ItemHeight = 20;
            this.topicList2.Location = new System.Drawing.Point(739, 3);
            this.topicList2.Name = "topicList2";
            this.topicList2.Size = new System.Drawing.Size(315, 324);
            this.topicList2.TabIndex = 3;
            this.topicList2.ValueMember = "Id";
            // 
            // courseList2
            // 
            this.courseList2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseList2.DisplayMember = "Course";
            this.courseList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.courseList2.FormattingEnabled = true;
            this.courseList2.ItemHeight = 20;
            this.courseList2.Location = new System.Drawing.Point(3, 3);
            this.courseList2.Name = "courseList2";
            this.courseList2.Size = new System.Drawing.Size(307, 324);
            this.courseList2.TabIndex = 2;
            this.courseList2.ValueMember = "CourseId";
            this.courseList2.Click += new System.EventHandler(this.CourseList2_Click);
            // 
            // progressGrid
            // 
            this.progressGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.progressGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressGrid.Location = new System.Drawing.Point(57, 385);
            this.progressGrid.Name = "progressGrid";
            this.progressGrid.Size = new System.Drawing.Size(905, 281);
            this.progressGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.userProgress);
            this.tabPage1.Controls.Add(this.listPanel1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Users & Progress";
            // 
            // userProgress
            // 
            this.userProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userProgress.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.userProgress.Location = new System.Drawing.Point(297, 332);
            this.userProgress.Name = "userProgress";
            this.userProgress.Size = new System.Drawing.Size(754, 317);
            this.userProgress.TabIndex = 11;
            // 
            // listPanel1
            // 
            this.listPanel1.AutoScroll = true;
            this.listPanel1.Controls.Add(this.userList);
            this.listPanel1.Location = new System.Drawing.Point(3, 6);
            this.listPanel1.Name = "listPanel1";
            this.listPanel1.Size = new System.Drawing.Size(288, 660);
            this.listPanel1.TabIndex = 10;
            // 
            // userList
            // 
            this.userList.AutoScroll = true;
            this.userList.AutoSize = true;
            this.userList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userList.Controls.Add(this.courseGrid);
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(288, 660);
            this.userList.TabIndex = 3;
            // 
            // courseGrid
            // 
            this.courseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(3, 3);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.Size = new System.Drawing.Size(651, 0);
            this.courseGrid.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(297, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 244);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(156, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(156, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(458, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(156, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(156, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(458, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logoutToolStripMenuItem.Tag = "4";
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Tag = "0";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(LearningSystem.Model.DB.Course);
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1062, 726);
            this.Controls.Add(this.pageTab);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELearning";
            this.pageTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProgress)).EndInit();
            this.listPanel1.ResumeLayout(false);
            this.listPanel1.PerformLayout();
            this.userList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl pageTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox courseList;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel userList;
        private System.Windows.Forms.Panel listPanel1;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mainStatus;
        private System.Windows.Forms.ListBox topicList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label authorTxt;
        private System.Windows.Forms.Label lecturesTxt;
        private System.Windows.Forms.Label hoursTxt;
        private System.Windows.Forms.Label detailTxt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView progressGrid;
        private System.Windows.Forms.ListBox topicList2;
        private System.Windows.Forms.ListBox courseList2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView userProgress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboCategories;
        private System.Windows.Forms.FlowLayoutPanel customTopicList;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

