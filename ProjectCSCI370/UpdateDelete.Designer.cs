namespace ProjectCSCI370
{
    partial class UpdateDelete
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
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            Time = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            Pamount = new TextBox();
            Gender = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            Age = new TextBox();
            label5 = new Label();
            Pnumber = new TextBox();
            label4 = new Label();
            Mname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            MemberSDVG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MemberSDVG).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(71, 581);
            button4.Name = "button4";
            button4.Size = new Size(116, 46);
            button4.TabIndex = 39;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(20, 529);
            button3.Name = "button3";
            button3.Size = new Size(128, 46);
            button3.TabIndex = 38;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(154, 529);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 37;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Time
            // 
            Time.FormattingEnabled = true;
            Time.Items.AddRange(new object[] { "Monday:8PM-10PM", "Monday:10PM-12PM", "Monday:12PM-2AM", "Tuesday:8PM-10PM", "Tuesday:10PM-12PM", "Tuesday:12PM-2AM", "Wednesday:8PM-10PM", "Wednesday:10PM-12PM", "Wednesday:12PM-2AM" });
            Time.Location = new Point(20, 495);
            Time.Name = "Time";
            Time.Size = new Size(250, 28);
            Time.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(20, 464);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 35;
            label9.Text = "Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(20, 379);
            label8.Name = "label8";
            label8.Size = new Size(225, 28);
            label8.TabIndex = 34;
            label8.Text = "Payment Ammount:";
            // 
            // Pamount
            // 
            Pamount.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pamount.Location = new Point(20, 410);
            Pamount.Name = "Pamount";
            Pamount.Size = new Size(250, 48);
            Pamount.TabIndex = 33;
            // 
            // Gender
            // 
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female" });
            Gender.Location = new Point(20, 347);
            Gender.Name = "Gender";
            Gender.Size = new Size(250, 28);
            Gender.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(20, 316);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 31;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(20, 234);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 30;
            label6.Text = "Age :";
            // 
            // Age
            // 
            Age.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Age.Location = new Point(20, 265);
            Age.Name = "Age";
            Age.Size = new Size(250, 48);
            Age.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(20, 144);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 28;
            label5.Text = "Phone Number :";
            // 
            // Pnumber
            // 
            Pnumber.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pnumber.Location = new Point(20, 175);
            Pnumber.Name = "Pnumber";
            Pnumber.Size = new Size(250, 48);
            Pnumber.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(20, 62);
            label4.Name = "label4";
            label4.Size = new Size(183, 28);
            label4.TabIndex = 26;
            label4.Text = "Member Name :";
            // 
            // Mname
            // 
            Mname.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mname.Location = new Point(20, 93);
            Mname.Name = "Mname";
            Mname.Size = new Size(250, 48);
            Mname.TabIndex = 25;
            Mname.TextChanged += Mname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(1113, 47);
            label3.Name = "label3";
            label3.Size = new Size(49, 47);
            label3.TabIndex = 24;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(473, 62);
            label2.Name = "label2";
            label2.Size = new Size(600, 40);
            label2.TabIndex = 23;
            label2.Text = "Click on a patient to update or delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(579, 9);
            label1.Name = "label1";
            label1.Size = new Size(386, 47);
            label1.TabIndex = 22;
            label1.Text = "HEALTHCENTER";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(717, 597);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 41;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MemberSDVG
            // 
            MemberSDVG.BackgroundColor = Color.White;
            MemberSDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberSDVG.Location = new Point(334, 105);
            MemberSDVG.Name = "MemberSDVG";
            MemberSDVG.RowHeadersWidth = 51;
            MemberSDVG.Size = new Size(794, 470);
            MemberSDVG.TabIndex = 42;
            MemberSDVG.CellContentClick += MemberSDVG_CellContentClick_1;
            // 
            // UpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 655);
            Controls.Add(MemberSDVG);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(Time);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Pamount);
            Controls.Add(Gender);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Age);
            Controls.Add(label5);
            Controls.Add(Pnumber);
            Controls.Add(label4);
            Controls.Add(Mname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDelete";
            Load += UpdateDelete_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button1;
        private ComboBox Time;
        private Label label9;
        private Label label8;
        private TextBox Pamount;
        private ComboBox Gender;
        private Label label7;
        private Label label6;
        private TextBox Age;
        private Label label5;
        private TextBox Pnumber;
        private Label label4;
        private TextBox Mname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private DataGridView MemberSDVG;
    }
}