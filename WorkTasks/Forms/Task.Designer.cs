namespace WorkTasks.Forms
{
    partial class TaskPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPage));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            TasksFlowLayout = new FlowLayoutPanel();
            DepartmentCombo = new ComboBox();
            label7 = new Label();
            StatusCombo = new ComboBox();
            NameBox = new TextBox();
            tabPage2 = new TabPage();
            label8 = new Label();
            deadlineCalendar = new MonthCalendar();
            CreateTask_btn = new Button();
            descTextbox = new RichTextBox();
            nameTextbox = new TextBox();
            departCheck5 = new CheckBox();
            departCheck4 = new CheckBox();
            departCheck3 = new CheckBox();
            departCheck2 = new CheckBox();
            statusRadio5 = new RadioButton();
            statusRadio4 = new RadioButton();
            statusRadio3 = new RadioButton();
            statusRadio2 = new RadioButton();
            statusRadio1 = new RadioButton();
            departCheck1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GoBack_btn = new Button();
            label6 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(955, 612);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(TasksFlowLayout);
            tabPage1.Controls.Add(DepartmentCombo);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(StatusCombo);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(NameBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(947, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search Tasks";
            // 
            // TasksFlowLayout
            // 
            TasksFlowLayout.AutoScroll = true;
            TasksFlowLayout.BackColor = Color.LightGray;
            TasksFlowLayout.Location = new Point(28, 95);
            TasksFlowLayout.Name = "TasksFlowLayout";
            TasksFlowLayout.Size = new Size(893, 456);
            TasksFlowLayout.TabIndex = 10;
            // 
            // DepartmentCombo
            // 
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Items.AddRange(new object[] { "Human Resources ", "Marketing", "Sales", "Support", "Research and Development" });
            DepartmentCombo.Location = new Point(770, 44);
            DepartmentCombo.Name = "DepartmentCombo";
            DepartmentCombo.Size = new Size(151, 28);
            DepartmentCombo.TabIndex = 6;
            DepartmentCombo.SelectedIndexChanged += DepartmentCombo_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(618, 38);
            label7.Name = "label7";
            label7.Size = new Size(146, 31);
            label7.TabIndex = 5;
            label7.Text = "Department:";
            // 
            // StatusCombo
            // 
            StatusCombo.FormattingEnabled = true;
            StatusCombo.Items.AddRange(new object[] { "Open", "InProgress", "Completed", "Blocked", "Cancelled" });
            StatusCombo.Location = new Point(412, 44);
            StatusCombo.Name = "StatusCombo";
            StatusCombo.Size = new Size(151, 28);
            StatusCombo.TabIndex = 4;
            StatusCombo.SelectedIndexChanged += StatusCombo_SelectedIndexChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(116, 42);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 2;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(deadlineCalendar);
            tabPage2.Controls.Add(CreateTask_btn);
            tabPage2.Controls.Add(descTextbox);
            tabPage2.Controls.Add(nameTextbox);
            tabPage2.Controls.Add(departCheck5);
            tabPage2.Controls.Add(departCheck4);
            tabPage2.Controls.Add(departCheck3);
            tabPage2.Controls.Add(departCheck2);
            tabPage2.Controls.Add(statusRadio5);
            tabPage2.Controls.Add(statusRadio4);
            tabPage2.Controls.Add(statusRadio3);
            tabPage2.Controls.Add(statusRadio2);
            tabPage2.Controls.Add(statusRadio1);
            tabPage2.Controls.Add(departCheck1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(947, 579);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Create Task";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(21, 372);
            label8.Name = "label8";
            label8.Size = new Size(112, 31);
            label8.TabIndex = 18;
            label8.Text = "Deadline:";
            // 
            // deadlineCalendar
            // 
            deadlineCalendar.Location = new Point(209, 363);
            deadlineCalendar.Name = "deadlineCalendar";
            deadlineCalendar.TabIndex = 17;
            // 
            // CreateTask_btn
            // 
            CreateTask_btn.BackColor = Color.Aqua;
            CreateTask_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTask_btn.Location = new Point(759, 509);
            CreateTask_btn.Name = "CreateTask_btn";
            CreateTask_btn.Size = new Size(165, 42);
            CreateTask_btn.TabIndex = 16;
            CreateTask_btn.Text = "Create";
            CreateTask_btn.UseVisualStyleBackColor = false;
            CreateTask_btn.Click += CreateTask_btn_Click;
            // 
            // descTextbox
            // 
            descTextbox.Location = new Point(209, 228);
            descTextbox.Name = "descTextbox";
            descTextbox.Size = new Size(596, 120);
            descTextbox.TabIndex = 15;
            descTextbox.Text = "";
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(209, 35);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(153, 27);
            nameTextbox.TabIndex = 14;
            // 
            // departCheck5
            // 
            departCheck5.AutoSize = true;
            departCheck5.Location = new Point(728, 98);
            departCheck5.Name = "departCheck5";
            departCheck5.Size = new Size(213, 24);
            departCheck5.TabIndex = 13;
            departCheck5.Text = "Research and Development";
            departCheck5.UseVisualStyleBackColor = true;
            // 
            // departCheck4
            // 
            departCheck4.AutoSize = true;
            departCheck4.Location = new Point(619, 98);
            departCheck4.Name = "departCheck4";
            departCheck4.Size = new Size(84, 24);
            departCheck4.TabIndex = 12;
            departCheck4.Text = "Support";
            departCheck4.UseVisualStyleBackColor = true;
            // 
            // departCheck3
            // 
            departCheck3.AutoSize = true;
            departCheck3.Location = new Point(524, 98);
            departCheck3.Name = "departCheck3";
            departCheck3.Size = new Size(65, 24);
            departCheck3.TabIndex = 11;
            departCheck3.Text = "Sales";
            departCheck3.UseVisualStyleBackColor = true;
            // 
            // departCheck2
            // 
            departCheck2.AutoSize = true;
            departCheck2.Location = new Point(392, 98);
            departCheck2.Name = "departCheck2";
            departCheck2.Size = new Size(98, 24);
            departCheck2.TabIndex = 10;
            departCheck2.Text = "Marketing";
            departCheck2.UseVisualStyleBackColor = true;
            // 
            // statusRadio5
            // 
            statusRadio5.AutoSize = true;
            statusRadio5.Location = new Point(710, 164);
            statusRadio5.Name = "statusRadio5";
            statusRadio5.Size = new Size(95, 24);
            statusRadio5.TabIndex = 9;
            statusRadio5.Text = "Cancelled";
            statusRadio5.UseVisualStyleBackColor = true;
            // 
            // statusRadio4
            // 
            statusRadio4.AutoSize = true;
            statusRadio4.Location = new Point(595, 164);
            statusRadio4.Name = "statusRadio4";
            statusRadio4.Size = new Size(83, 24);
            statusRadio4.TabIndex = 8;
            statusRadio4.Text = "Blocked";
            statusRadio4.UseVisualStyleBackColor = true;
            // 
            // statusRadio3
            // 
            statusRadio3.AutoSize = true;
            statusRadio3.Location = new Point(455, 164);
            statusRadio3.Name = "statusRadio3";
            statusRadio3.Size = new Size(104, 24);
            statusRadio3.TabIndex = 7;
            statusRadio3.Text = "Completed";
            statusRadio3.UseVisualStyleBackColor = true;
            // 
            // statusRadio2
            // 
            statusRadio2.AutoSize = true;
            statusRadio2.Location = new Point(312, 164);
            statusRadio2.Name = "statusRadio2";
            statusRadio2.Size = new Size(102, 24);
            statusRadio2.TabIndex = 6;
            statusRadio2.Text = "In Progress";
            statusRadio2.UseVisualStyleBackColor = true;
            // 
            // statusRadio1
            // 
            statusRadio1.AutoSize = true;
            statusRadio1.Location = new Point(209, 164);
            statusRadio1.Name = "statusRadio1";
            statusRadio1.Size = new Size(66, 24);
            statusRadio1.TabIndex = 5;
            statusRadio1.Text = "Open";
            statusRadio1.UseVisualStyleBackColor = true;
            // 
            // departCheck1
            // 
            departCheck1.AutoSize = true;
            departCheck1.Location = new Point(209, 97);
            departCheck1.Name = "departCheck1";
            departCheck1.Size = new Size(153, 24);
            departCheck1.TabIndex = 4;
            departCheck1.Text = " Human Resources";
            departCheck1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 222);
            label4.Name = "label4";
            label4.Size = new Size(140, 31);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 157);
            label3.Name = "label3";
            label3.Size = new Size(83, 31);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(172, 31);
            label2.TabIndex = 1;
            label2.Text = "Department(s):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // GoBack_btn
            // 
            GoBack_btn.BackColor = Color.Aqua;
            GoBack_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GoBack_btn.Location = new Point(775, 640);
            GoBack_btn.Name = "GoBack_btn";
            GoBack_btn.Size = new Size(192, 49);
            GoBack_btn.TabIndex = 12;
            GoBack_btn.Text = "Back";
            GoBack_btn.UseVisualStyleBackColor = false;
            GoBack_btn.Click += GoBack_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(323, 38);
            label6.Name = "label6";
            label6.Size = new Size(83, 31);
            label6.TabIndex = 3;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 36);
            label5.Name = "label5";
            label5.Size = new Size(82, 31);
            label5.TabIndex = 11;
            label5.Text = "Name:";
            // 
            // TaskPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(983, 716);
            Controls.Add(GoBack_btn);
            Controls.Add(tabControl1);
            Name = "TaskPage";
            Text = "Task Page";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private RadioButton statusRadio4;
        private RadioButton statusRadio3;
        private RadioButton statusRadio2;
        private RadioButton statusRadio1;
        private CheckBox departCheck1;
        private Label label4;
        private Label label3;
        private CheckBox departCheck5;
        private CheckBox departCheck4;
        private CheckBox departCheck3;
        private CheckBox departCheck2;
        private RadioButton statusRadio5;
        private Button CreateTask_btn;
        private RichTextBox descTextbox;
        private TextBox nameTextbox;
        private TextBox NameBox;
        private ListBox TasksListbox;
        private ComboBox DepartmentCombo;
        private Label label7;
        private ComboBox StatusCombo;
        private FlowLayoutPanel TasksFlowLayout;
        private Label label8;
        private MonthCalendar deadlineCalendar;
        private Button GoBack_btn;
        private Label label5;
        private Label label6;
    }
}