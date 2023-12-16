namespace WorkTasks
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TasksPage_btn = new Button();
            EmployeesPage_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TasksPage_btn
            // 
            TasksPage_btn.Location = new Point(273, 247);
            TasksPage_btn.Name = "TasksPage_btn";
            TasksPage_btn.Size = new Size(222, 68);
            TasksPage_btn.TabIndex = 0;
            TasksPage_btn.Text = "Tasks";
            TasksPage_btn.UseVisualStyleBackColor = true;
            TasksPage_btn.Click += TasksPage_btn_Click;
            // 
            // EmployeesPage_btn
            // 
            EmployeesPage_btn.Location = new Point(273, 152);
            EmployeesPage_btn.Name = "EmployeesPage_btn";
            EmployeesPage_btn.Size = new Size(222, 68);
            EmployeesPage_btn.TabIndex = 1;
            EmployeesPage_btn.Text = "Employees";
            EmployeesPage_btn.UseVisualStyleBackColor = true;
            EmployeesPage_btn.Click += EmployeesPage_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 53);
            label1.Name = "label1";
            label1.Size = new Size(217, 54);
            label1.TabIndex = 2;
            label1.Text = "Work Tasks";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(EmployeesPage_btn);
            Controls.Add(TasksPage_btn);
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TasksPage_btn;
        private Button EmployeesPage_btn;
        private Label label1;
    }
}