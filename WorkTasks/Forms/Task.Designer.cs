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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DeleteTask_btn = new Button();
            UpdateTask_btn = new Button();
            LoadAllTasks_btn = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            TasksListbox = new ListBox();
            tabPage2 = new TabPage();
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
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1148, 612);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DeleteTask_btn);
            tabPage1.Controls.Add(UpdateTask_btn);
            tabPage1.Controls.Add(LoadAllTasks_btn);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(TasksListbox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1140, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search Tasks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteTask_btn
            // 
            DeleteTask_btn.Location = new Point(733, 254);
            DeleteTask_btn.Name = "DeleteTask_btn";
            DeleteTask_btn.Size = new Size(192, 49);
            DeleteTask_btn.TabIndex = 9;
            DeleteTask_btn.Text = "Delete Task";
            DeleteTask_btn.UseVisualStyleBackColor = true;
            // 
            // UpdateTask_btn
            // 
            UpdateTask_btn.Location = new Point(733, 173);
            UpdateTask_btn.Name = "UpdateTask_btn";
            UpdateTask_btn.Size = new Size(192, 49);
            UpdateTask_btn.TabIndex = 8;
            UpdateTask_btn.Text = "Update Task";
            UpdateTask_btn.UseVisualStyleBackColor = true;
            // 
            // LoadAllTasks_btn
            // 
            LoadAllTasks_btn.Location = new Point(733, 95);
            LoadAllTasks_btn.Name = "LoadAllTasks_btn";
            LoadAllTasks_btn.Size = new Size(192, 49);
            LoadAllTasks_btn.TabIndex = 7;
            LoadAllTasks_btn.Text = "Load All Tasks";
            LoadAllTasks_btn.UseVisualStyleBackColor = true;
            LoadAllTasks_btn.Click += LoadAllTasks_btn_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(884, 29);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(687, 32);
            label7.Name = "label7";
            label7.Size = new Size(191, 25);
            label7.TabIndex = 5;
            label7.Text = "Search by department:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(496, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(345, 32);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 3;
            label6.Text = "Search by status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 30);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 1;
            label5.Text = "Search by name:";
            // 
            // TasksListbox
            // 
            TasksListbox.FormattingEnabled = true;
            TasksListbox.ItemHeight = 20;
            TasksListbox.Location = new Point(28, 95);
            TasksListbox.Name = "TasksListbox";
            TasksListbox.Size = new Size(658, 464);
            TasksListbox.TabIndex = 0;
            // 
            // tabPage2
            // 
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
            tabPage2.Size = new Size(1140, 579);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Create Task";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateTask_btn
            // 
            CreateTask_btn.Location = new Point(394, 444);
            CreateTask_btn.Name = "CreateTask_btn";
            CreateTask_btn.Size = new Size(165, 42);
            CreateTask_btn.TabIndex = 16;
            CreateTask_btn.Text = "Create";
            CreateTask_btn.UseVisualStyleBackColor = true;
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
            nameTextbox.Size = new Size(125, 27);
            nameTextbox.TabIndex = 14;
            // 
            // departCheck5
            // 
            departCheck5.AutoSize = true;
            departCheck5.Location = new Point(752, 98);
            departCheck5.Name = "departCheck5";
            departCheck5.Size = new Size(213, 24);
            departCheck5.TabIndex = 13;
            departCheck5.Text = "Research and Development";
            departCheck5.UseVisualStyleBackColor = true;
            // 
            // departCheck4
            // 
            departCheck4.AutoSize = true;
            departCheck4.Location = new Point(639, 98);
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
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 222);
            label4.Name = "label4";
            label4.Size = new Size(136, 31);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 157);
            label3.Name = "label3";
            label3.Size = new Size(81, 31);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 1;
            label2.Text = "Department(s):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1140, 579);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update Task";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1140, 579);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete Task";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // TaskPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 636);
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
        private TabPage tabPage3;
        private TabPage tabPage4;
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
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private ListBox TasksListbox;
        private Button DeleteTask_btn;
        private Button UpdateTask_btn;
        private Button LoadAllTasks_btn;
        private ComboBox comboBox2;
        private Label label7;
        private ComboBox comboBox1;
    }
}