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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            EmployeesFlowLayout = new FlowLayoutPanel();
            GoBack_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // EmployeesFlowLayout
            // 
            EmployeesFlowLayout.AutoScroll = true;
            EmployeesFlowLayout.BackColor = Color.LightGray;
            EmployeesFlowLayout.Location = new Point(93, 138);
            EmployeesFlowLayout.Name = "EmployeesFlowLayout";
            EmployeesFlowLayout.Size = new Size(1010, 456);
            EmployeesFlowLayout.TabIndex = 11;
            // 
            // GoBack_btn
            // 
            GoBack_btn.BackColor = Color.Aqua;
            GoBack_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GoBack_btn.Location = new Point(93, 653);
            GoBack_btn.Name = "GoBack_btn";
            GoBack_btn.Size = new Size(192, 49);
            GoBack_btn.TabIndex = 13;
            GoBack_btn.Text = "Back";
            GoBack_btn.UseVisualStyleBackColor = false;
            GoBack_btn.Click += GoBack_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(424, 47);
            label1.Name = "label1";
            label1.Size = new Size(386, 53);
            label1.TabIndex = 15;
            label1.Text = "All Employees:";
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1170, 762);
            Controls.Add(label1);
            Controls.Add(GoBack_btn);
            Controls.Add(EmployeesFlowLayout);
            Name = "EmployeePage";
            Text = "Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel EmployeesFlowLayout;
        private Button GoBack_btn;
        private Label label1;
    }
}