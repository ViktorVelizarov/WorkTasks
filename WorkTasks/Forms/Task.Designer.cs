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
            tabPage2 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            CreateTask_btn = new Button();
            tabControl1.SuspendLayout();
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1140, 579);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search Tasks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CreateTask_btn);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(checkBox5);
            tabPage2.Controls.Add(checkBox4);
            tabPage2.Controls.Add(checkBox3);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(radioButton5);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(checkBox1);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(209, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(153, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = " Human Resources";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(209, 164);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 24);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "Open";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(312, 164);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 24);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "In Progress";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(455, 164);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 24);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "Completed";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(595, 164);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(83, 24);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "Blocked";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(710, 164);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(95, 24);
            radioButton5.TabIndex = 9;
            radioButton5.Text = "Cancelled";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(392, 98);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Marketing";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(524, 98);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Sales";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(639, 98);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(84, 24);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Support";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(752, 98);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(213, 24);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "Research and Development";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(209, 228);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(596, 120);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // CreateTask_btn
            // 
            CreateTask_btn.Location = new Point(394, 471);
            CreateTask_btn.Name = "CreateTask_btn";
            CreateTask_btn.Size = new Size(165, 42);
            CreateTask_btn.TabIndex = 16;
            CreateTask_btn.Text = "Create";
            CreateTask_btn.UseVisualStyleBackColor = true;
            CreateTask_btn.Click += CreateTask_btn_Click;
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
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private Label label4;
        private Label label3;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton radioButton5;
        private Button CreateTask_btn;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}