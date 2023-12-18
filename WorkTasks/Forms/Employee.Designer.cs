namespace WorkTasks.Forms
{
    partial class EmployeePage
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
            EmployeesFlowLayout = new FlowLayoutPanel();
            GoBack_btn = new Button();
            LoadEmployees_btn = new Button();
            SuspendLayout();
            // 
            // EmployeesFlowLayout
            // 
            EmployeesFlowLayout.AutoScroll = true;
            EmployeesFlowLayout.BackColor = Color.LightGray;
            EmployeesFlowLayout.Location = new Point(79, 138);
            EmployeesFlowLayout.Name = "EmployeesFlowLayout";
            EmployeesFlowLayout.Size = new Size(1018, 456);
            EmployeesFlowLayout.TabIndex = 11;
            // 
            // GoBack_btn
            // 
            GoBack_btn.Location = new Point(79, 654);
            GoBack_btn.Name = "GoBack_btn";
            GoBack_btn.Size = new Size(192, 49);
            GoBack_btn.TabIndex = 13;
            GoBack_btn.Text = "Back";
            GoBack_btn.UseVisualStyleBackColor = true;
            GoBack_btn.Click += GoBack_btn_Click;
            // 
            // LoadEmployees_btn
            // 
            LoadEmployees_btn.Location = new Point(905, 654);
            LoadEmployees_btn.Name = "LoadEmployees_btn";
            LoadEmployees_btn.Size = new Size(192, 49);
            LoadEmployees_btn.TabIndex = 14;
            LoadEmployees_btn.Text = "Load Employees";
            LoadEmployees_btn.UseVisualStyleBackColor = true;
            LoadEmployees_btn.Click += LoadEmployees_btn_Click;
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 762);
            Controls.Add(LoadEmployees_btn);
            Controls.Add(GoBack_btn);
            Controls.Add(EmployeesFlowLayout);
            Name = "EmployeePage";
            Text = "Employee";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel EmployeesFlowLayout;
        private Button GoBack_btn;
        private Button LoadEmployees_btn;
    }
}