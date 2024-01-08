namespace WorkTasks.Forms
{
    partial class UserMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainPage));
            Logout_btn = new Button();
            EmployeePage = new Label();
            LoggedAs = new Label();
            TasksFlowLayout2 = new FlowLayoutPanel();
            LoadTasks_btn = new Button();
            SuspendLayout();
            // 
            // Logout_btn
            // 
            Logout_btn.BackColor = Color.Cyan;
            Logout_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Logout_btn.Location = new Point(931, 12);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(151, 50);
            Logout_btn.TabIndex = 0;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = false;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // EmployeePage
            // 
            EmployeePage.AutoSize = true;
            EmployeePage.BackColor = Color.Transparent;
            EmployeePage.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeePage.Location = new Point(391, 24);
            EmployeePage.Name = "EmployeePage";
            EmployeePage.Size = new Size(399, 53);
            EmployeePage.TabIndex = 1;
            EmployeePage.Text = "Employee Page";
            // 
            // LoggedAs
            // 
            LoggedAs.AutoSize = true;
            LoggedAs.BackColor = Color.Transparent;
            LoggedAs.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedAs.Location = new Point(447, 87);
            LoggedAs.Name = "LoggedAs";
            LoggedAs.Size = new Size(59, 25);
            LoggedAs.TabIndex = 2;
            LoggedAs.Text = "label1";
            // 
            // TasksFlowLayout2
            // 
            TasksFlowLayout2.AutoScroll = true;
            TasksFlowLayout2.BackColor = Color.LightGray;
            TasksFlowLayout2.Location = new Point(38, 190);
            TasksFlowLayout2.Name = "TasksFlowLayout2";
            TasksFlowLayout2.Size = new Size(1044, 520);
            TasksFlowLayout2.TabIndex = 11;
            // 
            // LoadTasks_btn
            // 
            LoadTasks_btn.BackColor = Color.Cyan;
            LoadTasks_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoadTasks_btn.Location = new Point(931, 87);
            LoadTasks_btn.Name = "LoadTasks_btn";
            LoadTasks_btn.Size = new Size(151, 50);
            LoadTasks_btn.TabIndex = 12;
            LoadTasks_btn.Text = "Load";
            LoadTasks_btn.UseVisualStyleBackColor = false;
            LoadTasks_btn.Click += LoadTasks_btn_Click;
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 722);
            Controls.Add(LoadTasks_btn);
            Controls.Add(TasksFlowLayout2);
            Controls.Add(LoggedAs);
            Controls.Add(EmployeePage);
            Controls.Add(Logout_btn);
            Name = "UserMainPage";
            Text = "UserMainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logout_btn;
        private Label EmployeePage;
        private Label LoggedAs;
        private FlowLayoutPanel TasksFlowLayout2;
        private Button LoadTasks_btn;
    }
}