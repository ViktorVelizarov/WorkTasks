namespace WorkTasks.UserControls
{
    partial class TaskItem2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmployeesListbox = new ListBox();
            UpdateTask_btn = new Button();
            dLabel = new Label();
            deadlineLabel = new Label();
            departmentsLabel = new Label();
            statusLabel = new Label();
            nameLabel = new Label();
            StatusCombo = new ComboBox();
            SuspendLayout();
            // 
            // EmployeesListbox
            // 
            EmployeesListbox.FormattingEnabled = true;
            EmployeesListbox.ItemHeight = 15;
            EmployeesListbox.Location = new Point(430, 51);
            EmployeesListbox.Margin = new Padding(3, 2, 3, 2);
            EmployeesListbox.Name = "EmployeesListbox";
            EmployeesListbox.Size = new Size(253, 64);
            EmployeesListbox.TabIndex = 16;
            // 
            // UpdateTask_btn
            // 
            UpdateTask_btn.BackColor = Color.Aqua;
            UpdateTask_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateTask_btn.Location = new Point(699, 81);
            UpdateTask_btn.Margin = new Padding(3, 2, 3, 2);
            UpdateTask_btn.Name = "UpdateTask_btn";
            UpdateTask_btn.Size = new Size(113, 34);
            UpdateTask_btn.TabIndex = 14;
            UpdateTask_btn.Text = "Change Status";
            UpdateTask_btn.UseVisualStyleBackColor = false;
            UpdateTask_btn.Click += UpdateTask_btn_Click;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new Point(23, 91);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(67, 15);
            dLabel.TabIndex = 13;
            dLabel.Text = "Description";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.BackColor = Color.Transparent;
            deadlineLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deadlineLabel.Location = new Point(430, 17);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(74, 21);
            deadlineLabel.TabIndex = 12;
            deadlineLabel.Text = "Deadline";
            // 
            // departmentsLabel
            // 
            departmentsLabel.AutoSize = true;
            departmentsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            departmentsLabel.Location = new Point(23, 47);
            departmentsLabel.Name = "departmentsLabel";
            departmentsLabel.Size = new Size(115, 21);
            departmentsLabel.TabIndex = 11;
            departmentsLabel.Text = "Department(s)";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.Location = new Point(238, 17);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(55, 21);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(23, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(64, 25);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name";
            // 
            // StatusCombo
            // 
            StatusCombo.FormattingEnabled = true;
            StatusCombo.Items.AddRange(new object[] { "Open", "InProgress", "Completed", "Blocked", "Cancelled" });
            StatusCombo.Location = new Point(699, 54);
            StatusCombo.Margin = new Padding(3, 2, 3, 2);
            StatusCombo.Name = "StatusCombo";
            StatusCombo.Size = new Size(113, 23);
            StatusCombo.TabIndex = 17;
            // 
            // TaskItem2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(StatusCombo);
            Controls.Add(EmployeesListbox);
            Controls.Add(UpdateTask_btn);
            Controls.Add(dLabel);
            Controls.Add(deadlineLabel);
            Controls.Add(departmentsLabel);
            Controls.Add(statusLabel);
            Controls.Add(nameLabel);
            Name = "TaskItem2";
            Size = new Size(826, 127);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EmployeesListbox;
        private Button UpdateTask_btn;
        private Label dLabel;
        private Label deadlineLabel;
        private Label departmentsLabel;
        private Label statusLabel;
        private Label nameLabel;
        private ComboBox StatusCombo;
    }
}
