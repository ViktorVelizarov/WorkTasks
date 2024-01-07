namespace WorkTasks.UserControls
{
    partial class EmployeeItem
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
            firstNameLabel = new Label();
            idLabel = new Label();
            ssnLabel = new Label();
            lastNameLabel = new Label();
            genderLabel = new Label();
            emialLabel = new Label();
            departmentLabel = new Label();
            Add_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(81, 35);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(124, 31);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "FirstName";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.Location = new Point(28, 35);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(38, 31);
            idLabel.TabIndex = 2;
            idLabel.Text = "ID";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ssnLabel.Location = new Point(375, 35);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(49, 28);
            ssnLabel.TabIndex = 3;
            ssnLabel.Text = "SSN";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(211, 33);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(120, 31);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "LastName";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            genderLabel.Location = new Point(529, 35);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(79, 28);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Gender";
            // 
            // emialLabel
            // 
            emialLabel.AutoSize = true;
            emialLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emialLabel.Location = new Point(679, 36);
            emialLabel.Name = "emialLabel";
            emialLabel.Size = new Size(60, 28);
            emialLabel.TabIndex = 6;
            emialLabel.Text = "Email";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            departmentLabel.Location = new Point(28, 103);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(144, 31);
            departmentLabel.TabIndex = 7;
            departmentLabel.Text = "Department";
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.Chartreuse;
            Add_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add_btn.Location = new Point(791, 103);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(137, 50);
            Add_btn.TabIndex = 8;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 107);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // EmployeeItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(Add_btn);
            Controls.Add(departmentLabel);
            Controls.Add(emialLabel);
            Controls.Add(genderLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(ssnLabel);
            Controls.Add(idLabel);
            Controls.Add(firstNameLabel);
            Name = "EmployeeItem";
            Size = new Size(956, 169);
            Load += EmployeeItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label idLabel;
        private Label ssnLabel;
        private Label lastNameLabel;
        private Label genderLabel;
        private Label emialLabel;
        private Label departmentLabel;
        private Button Add_btn;
        private Label label1;
    }
}
