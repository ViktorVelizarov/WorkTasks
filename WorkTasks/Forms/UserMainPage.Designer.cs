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
            SuspendLayout();
            // 
            // Logout_btn
            // 
            Logout_btn.BackColor = Color.Cyan;
            Logout_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Logout_btn.Location = new Point(773, 18);
            Logout_btn.Margin = new Padding(3, 2, 3, 2);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(132, 38);
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
            EmployeePage.Location = new Point(342, 18);
            EmployeePage.Name = "EmployeePage";
            EmployeePage.Size = new Size(316, 42);
            EmployeePage.TabIndex = 1;
            EmployeePage.Text = "Employee Page";
            // 
            // LoggedAs
            // 
            LoggedAs.AutoSize = true;
            LoggedAs.BackColor = Color.Transparent;
            LoggedAs.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedAs.Location = new Point(773, 58);
            LoggedAs.Name = "LoggedAs";
            LoggedAs.Size = new Size(50, 20);
            LoggedAs.TabIndex = 2;
            LoggedAs.Text = "label1";
            // 
            // TasksFlowLayout2
            // 
            TasksFlowLayout2.AutoScroll = true;
            TasksFlowLayout2.BackColor = Color.LightGray;
            TasksFlowLayout2.Location = new Point(69, 121);
            TasksFlowLayout2.Margin = new Padding(3, 2, 3, 2);
            TasksFlowLayout2.Name = "TasksFlowLayout2";
            TasksFlowLayout2.Size = new Size(836, 390);
            TasksFlowLayout2.TabIndex = 11;
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(979, 542);
            Controls.Add(TasksFlowLayout2);
            Controls.Add(LoggedAs);
            Controls.Add(EmployeePage);
            Controls.Add(Logout_btn);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}