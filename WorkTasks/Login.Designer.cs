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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            NameBox = new TextBox();
            EmailBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 64);
            label1.Name = "label1";
            label1.Size = new Size(246, 42);
            label1.TabIndex = 2;
            label1.Text = "Work Tasks";
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(329, 289);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(228, 50);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(318, 150);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(318, 211);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(468, 152);
            NameBox.Margin = new Padding(3, 2, 3, 2);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(110, 23);
            NameBox.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(468, 212);
            EmailBox.Margin = new Padding(3, 2, 3, 2);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(110, 23);
            EmailBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 372);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 8;
            label4.Text = "(Data for testing)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 388);
            label5.Name = "label5";
            label5.Size = new Size(264, 16);
            label5.TabIndex = 9;
            label5.Text = "ADMIN SIDE:Name: admin / email: test";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 406);
            label6.Name = "label6";
            label6.Size = new Size(387, 16);
            label6.TabIndex = 10;
            label6.Text = "USER SIDE:Name: Lydiard / email:  elydiarda@senate.gov";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 431);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EmailBox);
            Controls.Add(NameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label4;
        private Label label5;
        private Label label6;
    }
}