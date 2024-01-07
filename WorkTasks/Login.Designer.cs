namespace WorkTasks
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            NameBox = new TextBox();
            EmailBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(404, 98);
            label1.Name = "label1";
            label1.Size = new Size(217, 54);
            label1.TabIndex = 2;
            label1.Text = "Work Tasks";
            // 
            // button1
            // 
            button1.Location = new Point(404, 377);
            button1.Name = "button1";
            button1.Size = new Size(194, 56);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(393, 198);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(393, 281);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(496, 202);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(496, 285);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(125, 27);
            EmailBox.TabIndex = 7;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 595);
            Controls.Add(EmailBox);
            Controls.Add(NameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox NameBox;
        private TextBox EmailBox;
    }
}