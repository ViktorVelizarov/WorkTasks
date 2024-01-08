namespace WorkTasks.Forms
{
    partial class TaskUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskUpdate));
            AddEmployeeFlow = new FlowLayoutPanel();
            Back_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            StatusCombo = new ComboBox();
            SuspendLayout();
            // 
            // AddEmployeeFlow
            // 
            AddEmployeeFlow.AutoScroll = true;
            AddEmployeeFlow.BackColor = Color.LightGray;
            AddEmployeeFlow.Location = new Point(27, 68);
            AddEmployeeFlow.Name = "AddEmployeeFlow";
            AddEmployeeFlow.Size = new Size(1018, 456);
            AddEmployeeFlow.TabIndex = 3;
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Cyan;
            Back_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Back_btn.Location = new Point(896, 663);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(163, 53);
            Back_btn.TabIndex = 4;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            Back_btn.Click += Back_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 38);
            label1.TabIndex = 5;
            label1.Text = "Add Employee to Task:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 555);
            label2.Name = "label2";
            label2.Size = new Size(212, 38);
            label2.TabIndex = 6;
            label2.Text = "Change Status:";
            // 
            // StatusCombo
            // 
            StatusCombo.FormattingEnabled = true;
            StatusCombo.Items.AddRange(new object[] { "Open", "InProgress", "Completed", "Blocked", "Cancelled" });
            StatusCombo.Location = new Point(27, 613);
            StatusCombo.Name = "StatusCombo";
            StatusCombo.Size = new Size(151, 28);
            StatusCombo.TabIndex = 7;
            StatusCombo.SelectedIndexChanged += StatusCombo_SelectedIndexChanged;
            // 
            // TaskUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 728);
            Controls.Add(StatusCombo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back_btn);
            Controls.Add(AddEmployeeFlow);
            Name = "TaskUpdate";
            Text = "TaskUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel AddEmployeeFlow;
        private Button Back_btn;
        private Label label1;
        private Label label2;
        private ComboBox StatusCombo;
    }
}