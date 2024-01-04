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
            AddEmployeeFlow = new FlowLayoutPanel();
            Back_btn = new Button();
            SuspendLayout();
            // 
            // AddEmployeeFlow
            // 
            AddEmployeeFlow.AutoScroll = true;
            AddEmployeeFlow.BackColor = Color.LightGray;
            AddEmployeeFlow.Location = new Point(27, 25);
            AddEmployeeFlow.Name = "AddEmployeeFlow";
            AddEmployeeFlow.Size = new Size(1018, 456);
            AddEmployeeFlow.TabIndex = 3;
            // 
            // Back_btn
            // 
            Back_btn.Location = new Point(27, 542);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(152, 53);
            Back_btn.TabIndex = 4;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = true;
            Back_btn.Click += Back_btn_Click;
            // 
            // TaskUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 650);
            Controls.Add(Back_btn);
            Controls.Add(AddEmployeeFlow);
            Name = "TaskUpdate";
            Text = "TaskUpdate";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel AddEmployeeFlow;
        private Button Back_btn;
    }
}