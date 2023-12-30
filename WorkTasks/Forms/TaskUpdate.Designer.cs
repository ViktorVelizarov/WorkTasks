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
            listBox1 = new ListBox();
            AddEmployee_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(24, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 344);
            listBox1.TabIndex = 0;
            // 
            // AddEmployee_btn
            // 
            AddEmployee_btn.Location = new Point(352, 34);
            AddEmployee_btn.Name = "AddEmployee_btn";
            AddEmployee_btn.Size = new Size(178, 45);
            AddEmployee_btn.TabIndex = 1;
            AddEmployee_btn.Text = "Add Employee(s)";
            AddEmployee_btn.UseVisualStyleBackColor = true;
            AddEmployee_btn.Click += AddEmployee_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 114);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // TaskUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 411);
            Controls.Add(label1);
            Controls.Add(AddEmployee_btn);
            Controls.Add(listBox1);
            Name = "TaskUpdate";
            Text = "TaskUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button AddEmployee_btn;
        private Label label1;
    }
}