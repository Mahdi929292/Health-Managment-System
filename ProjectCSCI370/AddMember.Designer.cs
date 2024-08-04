namespace ProjectCSCI370
{
    partial class AddMember
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
            NameTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            AgeTb = new TextBox();
            label8 = new Label();
            PhoneTb = new TextBox();
            label3 = new Label();
            Gendercb = new ComboBox();
            label5 = new Label();
            AmountTb = new TextBox();
            Timecb = new ComboBox();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTb.Location = new Point(22, 181);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(266, 48);
            NameTb.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(426, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 40);
            label1.TabIndex = 31;
            label1.Text = "Add New Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(380, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(386, 47);
            label2.TabIndex = 30;
            label2.Text = "HEALTHCENTER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(22, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 28);
            label4.TabIndex = 32;
            label4.Text = "Patient Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(836, 150);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 40;
            label7.Text = "Age:";
            // 
            // AgeTb
            // 
            AgeTb.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeTb.Location = new Point(836, 181);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(266, 48);
            AgeTb.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(426, 150);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(179, 28);
            label8.TabIndex = 42;
            label8.Text = "Phone Number:";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(426, 181);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(266, 48);
            PhoneTb.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(22, 378);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 44;
            label3.Text = "Gender:";
            // 
            // Gendercb
            // 
            Gendercb.FormattingEnabled = true;
            Gendercb.Items.AddRange(new object[] { "Male", "Female" });
            Gendercb.Location = new Point(22, 422);
            Gendercb.Name = "Gendercb";
            Gendercb.Size = new Size(266, 28);
            Gendercb.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(426, 378);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 47;
            label5.Text = "Monthly Amount:";
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountTb.Location = new Point(426, 409);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(266, 48);
            AmountTb.TabIndex = 46;
            // 
            // Timecb
            // 
            Timecb.FormattingEnabled = true;
            Timecb.Items.AddRange(new object[] { "Monday:8-10", "Monday:10-12", "Monday:12-2", "Tuesday:8-10", "Tuesday:10-12", "Tuesday:12-2", "Wednesday:8-10", "Wednesday:10-12", "Wednesday:12-2", "Thursday:8-10", "Thursday:10-12", "Thursday:12-2" });
            Timecb.Location = new Point(836, 422);
            Timecb.Name = "Timecb";
            Timecb.Size = new Size(266, 28);
            Timecb.TabIndex = 49;
            Timecb.SelectedIndexChanged += Timecb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(836, 378);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 28);
            label6.TabIndex = 48;
            label6.Text = "Time:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(194, 557);
            button2.Name = "button2";
            button2.Size = new Size(201, 66);
            button2.TabIndex = 50;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(477, 557);
            button1.Name = "button1";
            button1.Size = new Size(201, 66);
            button1.TabIndex = 51;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(768, 557);
            button4.Name = "button4";
            button4.Size = new Size(201, 66);
            button4.TabIndex = 53;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(1073, 9);
            label9.Name = "label9";
            label9.Size = new Size(49, 47);
            label9.TabIndex = 54;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 756);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(Timecb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AmountTb);
            Controls.Add(Gendercb);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(PhoneTb);
            Controls.Add(label7);
            Controls.Add(AgeTb);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(NameTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMember";
            Load += AddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTb;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label7;
        private TextBox AgeTb;
        private Label label8;
        private TextBox PhoneTb;
        private Label label3;
        private ComboBox Gendercb;
        private Label label5;
        private TextBox AmountTb;
        private ComboBox Timecb;
        private Label label6;
        private Button button2;
        private Button button1;
        private Button button4;
        private Label label9;
    }
}