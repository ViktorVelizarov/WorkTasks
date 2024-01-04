namespace WorkTasks.UserControls
{
    partial class TaskItem
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
            nameLabel = new Label();
            statusLabel = new Label();
            departmentsLabel = new Label();
            deadlineLabel = new Label();
            dLabel = new Label();
            UpdateTask_btn = new Button();
            DeleteTask_btn = new Button();
            EmployeesListbox = new ListBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(19, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 31);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.Location = new Point(265, 30);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(67, 28);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Status";
            // 
            // departmentsLabel
            // 
            departmentsLabel.AutoSize = true;
            departmentsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            departmentsLabel.Location = new Point(19, 70);
            departmentsLabel.Name = "departmentsLabel";
            departmentsLabel.Size = new Size(145, 28);
            departmentsLabel.TabIndex = 2;
            departmentsLabel.Text = "Department(s)";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.BackColor = Color.Transparent;
            deadlineLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deadlineLabel.Location = new Point(484, 30);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(92, 28);
            deadlineLabel.TabIndex = 3;
            deadlineLabel.Text = "Deadline";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new Point(19, 128);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(85, 20);
            dLabel.TabIndex = 5;
            dLabel.Text = "Description";
            // 
            // UpdateTask_btn
            // 
            UpdateTask_btn.Location = new Point(729, 30);
            UpdateTask_btn.Name = "UpdateTask_btn";
            UpdateTask_btn.Size = new Size(125, 45);
            UpdateTask_btn.TabIndex = 6;
            UpdateTask_btn.Text = "Update";
            UpdateTask_btn.UseVisualStyleBackColor = true;
            UpdateTask_btn.Click += UpdateTask_btn_Click;
            // 
            // DeleteTask_btn
            // 
            DeleteTask_btn.Location = new Point(729, 94);
            DeleteTask_btn.Name = "DeleteTask_btn";
            DeleteTask_btn.Size = new Size(125, 45);
            DeleteTask_btn.TabIndex = 7;
            DeleteTask_btn.Text = "Delete";
            DeleteTask_btn.UseVisualStyleBackColor = true;
            DeleteTask_btn.Click += DeleteTask_btn_Click;
            // 
            // EmployeesListbox
            // 
            EmployeesListbox.FormattingEnabled = true;
            EmployeesListbox.ItemHeight = 20;
            EmployeesListbox.Location = new Point(361, 75);
            EmployeesListbox.Name = "EmployeesListbox";
            EmployeesListbox.Size = new Size(338, 84);
            EmployeesListbox.TabIndex = 8;
            // 
            // TaskItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(EmployeesListbox);
            Controls.Add(DeleteTask_btn);
            Controls.Add(UpdateTask_btn);
            Controls.Add(dLabel);
            Controls.Add(deadlineLabel);
            Controls.Add(departmentsLabel);
            Controls.Add(statusLabel);
            Controls.Add(nameLabel);
            Name = "TaskItem";
            Size = new Size(887, 169);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label statusLabel;
        private Label departmentsLabel;
        private Label deadlineLabel;
        private Label dLabel;
        private Button UpdateTask_btn;
        private Button DeleteTask_btn;
        private ListBox EmployeesListbox;
    }
}
