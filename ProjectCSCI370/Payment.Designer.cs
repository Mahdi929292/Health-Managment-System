namespace ProjectCSCI370
{
    partial class Payment
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            Pdate = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            Mamount = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            Mname = new ComboBox();
            PaymentDVG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PaymentDVG).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(312, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(386, 47);
            label2.TabIndex = 12;
            label2.Text = "HEALTHCENTER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(438, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 25;
            label1.Text = "Payments";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(18, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 28);
            label4.TabIndex = 27;
            label4.Text = "Payment Month :";
            // 
            // Pdate
            // 
            Pdate.Location = new Point(18, 187);
            Pdate.Margin = new Padding(4, 3, 4, 3);
            Pdate.Name = "Pdate";
            Pdate.Size = new Size(373, 32);
            Pdate.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(18, 237);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 30;
            label3.Text = "Member Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(18, 319);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 32;
            label5.Text = "Amount:";
            // 
            // Mamount
            // 
            Mamount.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mamount.Location = new Point(18, 350);
            Mamount.Name = "Mamount";
            Mamount.Size = new Size(250, 48);
            Mamount.TabIndex = 31;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(152, 404);
            button3.Name = "button3";
            button3.Size = new Size(116, 102);
            button3.TabIndex = 39;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(18, 460);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 40;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(18, 404);
            button2.Name = "button2";
            button2.Size = new Size(128, 46);
            button2.TabIndex = 41;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(942, 10);
            label6.Name = "label6";
            label6.Size = new Size(49, 47);
            label6.TabIndex = 43;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Mname
            // 
            Mname.FormattingEnabled = true;
            Mname.Items.AddRange(new object[] { "Monday:8-10", "Monday:10-12", "Monday:12-2", "Tuesday:8-10", "Tuesday:10-12", "Tuesday:12-2", "Wednesday:8-10", "Wednesday:10-12", "Wednesday:12-2", "Thursday:8-10", "Thursday:10-12", "Thursday:12-2" });
            Mname.Location = new Point(18, 268);
            Mname.Name = "Mname";
            Mname.Size = new Size(266, 31);
            Mname.TabIndex = 50;
            // 
            // PaymentDVG
            // 
            PaymentDVG.BackgroundColor = Color.White;
            PaymentDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDVG.Location = new Point(411, 107);
            PaymentDVG.Name = "PaymentDVG";
            PaymentDVG.RowHeadersWidth = 51;
            PaymentDVG.Size = new Size(547, 387);
            PaymentDVG.TabIndex = 51;
            PaymentDVG.CellContentClick += PaymentDVG_CellContentClick;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 518);
            Controls.Add(PaymentDVG);
            Controls.Add(Mname);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(Mamount);
            Controls.Add(label3);
            Controls.Add(Pdate);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)PaymentDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker Pdate;
        private Label label3;
        private Label label5;
        private TextBox Mamount;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox Mname;
        private DataGridView PaymentDVG;
    }
}