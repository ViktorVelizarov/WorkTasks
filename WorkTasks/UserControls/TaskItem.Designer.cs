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
            byUserLabel = new Label();
            dLabel = new Label();
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
            deadlineLabel.Location = new Point(452, 30);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(92, 28);
            deadlineLabel.TabIndex = 3;
            deadlineLabel.Text = "Deadline";
            // 
            // byUserLabel
            // 
            byUserLabel.AutoSize = true;
            byUserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            byUserLabel.Location = new Point(610, 30);
            byUserLabel.Name = "byUserLabel";
            byUserLabel.Size = new Size(34, 28);
            byUserLabel.TabIndex = 4;
            byUserLabel.Text = "By";
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
            // TaskItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dLabel);
            Controls.Add(byUserLabel);
            Controls.Add(deadlineLabel);
            Controls.Add(departmentsLabel);
            Controls.Add(statusLabel);
            Controls.Add(nameLabel);
            Name = "TaskItem";
            Size = new Size(667, 169);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label statusLabel;
        private Label departmentsLabel;
        private Label deadlineLabel;
        private Label byUserLabel;
        private Label dLabel;
    }
}
