namespace WorkTasks.Forms
{
    partial class AdminMainPage
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
            Logout_btn = new Button();
            AdminPage = new Label();
            EmployeesPage_btn = new Button();
            TasksPage_btn = new Button();
            loggedAs = new Label();
            SuspendLayout();
            // 
            // Logout_btn
            // 
            Logout_btn.Location = new Point(917, 24);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(151, 50);
            Logout_btn.TabIndex = 1;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = true;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // AdminPage
            // 
            AdminPage.AutoSize = true;
            AdminPage.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminPage.Location = new Point(430, 87);
            AdminPage.Name = "AdminPage";
            AdminPage.Size = new Size(220, 50);
            AdminPage.TabIndex = 2;
            AdminPage.Text = "Admin Page";
            // 
            // EmployeesPage_btn
            // 
            EmployeesPage_btn.Location = new Point(430, 198);
            EmployeesPage_btn.Name = "EmployeesPage_btn";
            EmployeesPage_btn.Size = new Size(222, 68);
            EmployeesPage_btn.TabIndex = 3;
            EmployeesPage_btn.Text = "All Employees";
            EmployeesPage_btn.UseVisualStyleBackColor = true;
            EmployeesPage_btn.Click += EmployeesPage_btn_Click;
            // 
            // TasksPage_btn
            // 
            TasksPage_btn.Location = new Point(430, 323);
            TasksPage_btn.Name = "TasksPage_btn";
            TasksPage_btn.Size = new Size(222, 68);
            TasksPage_btn.TabIndex = 4;
            TasksPage_btn.Text = "All Tasks";
            TasksPage_btn.UseVisualStyleBackColor = true;
            TasksPage_btn.Click += TasksPage_btn_Click_1;
            // 
            // loggedAs
            // 
            loggedAs.AutoSize = true;
            loggedAs.Location = new Point(516, 147);
            loggedAs.Name = "loggedAs";
            loggedAs.Size = new Size(42, 20);
            loggedAs.TabIndex = 5;
            loggedAs.Text = "label";
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 620);
            Controls.Add(loggedAs);
            Controls.Add(TasksPage_btn);
            Controls.Add(EmployeesPage_btn);
            Controls.Add(AdminPage);
            Controls.Add(Logout_btn);
            Name = "AdminMainPage";
            Text = "AdminMainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logout_btn;
        private Label AdminPage;
        private Button EmployeesPage_btn;
        private Button TasksPage_btn;
        private Label loggedAs;
    }
}