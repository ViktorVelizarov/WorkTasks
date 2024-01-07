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
            Logout_btn = new Button();
            EmployeePage = new Label();
            LoggedAs = new Label();
            SuspendLayout();
            // 
            // Logout_btn
            // 
            Logout_btn.Location = new Point(918, 24);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(151, 50);
            Logout_btn.TabIndex = 0;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = true;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // EmployeePage
            // 
            EmployeePage.AutoSize = true;
            EmployeePage.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeePage.Location = new Point(414, 87);
            EmployeePage.Name = "EmployeePage";
            EmployeePage.Size = new Size(272, 50);
            EmployeePage.TabIndex = 1;
            EmployeePage.Text = "Employee Page";
            // 
            // LoggedAs
            // 
            LoggedAs.AutoSize = true;
            LoggedAs.Location = new Point(526, 155);
            LoggedAs.Name = "LoggedAs";
            LoggedAs.Size = new Size(50, 20);
            LoggedAs.TabIndex = 2;
            LoggedAs.Text = "label1";
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 622);
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
    }
}