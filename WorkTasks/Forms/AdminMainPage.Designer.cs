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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            Logout_btn = new Button();
            AdminPage = new Label();
            EmployeesPage_btn = new Button();
            TasksPage_btn = new Button();
            loggedAs = new Label();
            SuspendLayout();
            // 
            // Logout_btn
            // 
            Logout_btn.BackColor = Color.Aqua;
            Logout_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Logout_btn.Location = new Point(708, 9);
            Logout_btn.Margin = new Padding(3, 2, 3, 2);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(132, 38);
            Logout_btn.TabIndex = 1;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // AdminPage
            // 
            AdminPage.AutoSize = true;
            AdminPage.BackColor = Color.Transparent;
            AdminPage.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            AdminPage.Location = new Point(298, 64);
            AdminPage.Name = "AdminPage";
            AdminPage.Size = new Size(251, 42);
            AdminPage.TabIndex = 2;
            AdminPage.Text = "Admin Page";
            // 
            // EmployeesPage_btn
            // 
            EmployeesPage_btn.BackColor = Color.Aqua;
            EmployeesPage_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeesPage_btn.Location = new Point(330, 164);
            EmployeesPage_btn.Margin = new Padding(3, 2, 3, 2);
            EmployeesPage_btn.Name = "EmployeesPage_btn";
            EmployeesPage_btn.Size = new Size(194, 51);
            EmployeesPage_btn.TabIndex = 3;
            EmployeesPage_btn.Text = "All Employees";
            EmployeesPage_btn.UseVisualStyleBackColor = false;
            EmployeesPage_btn.Click += EmployeesPage_btn_Click;
            // 
            // TasksPage_btn
            // 
            TasksPage_btn.BackColor = Color.Aqua;
            TasksPage_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TasksPage_btn.Location = new Point(330, 267);
            TasksPage_btn.Margin = new Padding(3, 2, 3, 2);
            TasksPage_btn.Name = "TasksPage_btn";
            TasksPage_btn.Size = new Size(194, 51);
            TasksPage_btn.TabIndex = 4;
            TasksPage_btn.Text = "All Tasks";
            TasksPage_btn.UseVisualStyleBackColor = false;
            TasksPage_btn.Click += TasksPage_btn_Click_1;
            // 
            // loggedAs
            // 
            loggedAs.AutoSize = true;
            loggedAs.BackColor = Color.Transparent;
            loggedAs.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            loggedAs.Location = new Point(708, 49);
            loggedAs.Name = "loggedAs";
            loggedAs.Size = new Size(42, 20);
            loggedAs.TabIndex = 5;
            loggedAs.Text = "label";
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 431);
            Controls.Add(loggedAs);
            Controls.Add(TasksPage_btn);
            Controls.Add(EmployeesPage_btn);
            Controls.Add(AdminPage);
            Controls.Add(Logout_btn);
            Margin = new Padding(3, 2, 3, 2);
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