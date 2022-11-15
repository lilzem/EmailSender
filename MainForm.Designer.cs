namespace EmailSender
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.messageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recipientText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.receivePanel = new System.Windows.Forms.Panel();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.receivePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.subjectText);
            this.panel2.Location = new System.Drawing.Point(110, 274);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(405, 41);
            this.panel2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(10, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(385, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 2;
            // 
            // subjectText
            // 
            this.subjectText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.subjectText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectText.ForeColor = System.Drawing.Color.White;
            this.subjectText.Location = new System.Drawing.Point(10, 10);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(385, 20);
            this.subjectText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.messagePanel.Controls.Add(this.messageText);
            this.messagePanel.Location = new System.Drawing.Point(110, 332);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Padding = new System.Windows.Forms.Padding(10);
            this.messagePanel.Size = new System.Drawing.Size(405, 178);
            this.messagePanel.TabIndex = 8;
            // 
            // messageText
            // 
            this.messageText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageText.ForeColor = System.Drawing.Color.White;
            this.messageText.Location = new System.Drawing.Point(10, 10);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(385, 158);
            this.messageText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sendBtn.Location = new System.Drawing.Point(110, 533);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(159, 51);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "Send Email";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hack", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rom4kMail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.recipientText);
            this.panel1.Location = new System.Drawing.Point(110, 217);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(405, 41);
            this.panel1.TabIndex = 7;
            // 
            // recipientText
            // 
            this.recipientText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.recipientText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipientText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipientText.ForeColor = System.Drawing.Color.White;
            this.recipientText.Location = new System.Drawing.Point(10, 10);
            this.recipientText.Name = "recipientText";
            this.recipientText.Size = new System.Drawing.Size(385, 20);
            this.recipientText.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(962, 20);
            this.textBox2.TabIndex = 11;
            // 
            // receivePanel
            // 
            this.receivePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.receivePanel.Controls.Add(this.receiveText);
            this.receivePanel.Location = new System.Drawing.Point(545, 28);
            this.receivePanel.Name = "receivePanel";
            this.receivePanel.Padding = new System.Windows.Forms.Padding(10);
            this.receivePanel.Size = new System.Drawing.Size(405, 482);
            this.receivePanel.TabIndex = 9;
            // 
            // receiveBtn
            // 
            this.receiveBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.receiveBtn.FlatAppearance.BorderSize = 0;
            this.receiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.receiveBtn.Location = new System.Drawing.Point(545, 533);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(159, 51);
            this.receiveBtn.TabIndex = 12;
            this.receiveBtn.Text = "Receive";
            this.receiveBtn.UseVisualStyleBackColor = false;
            this.receiveBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // receiveText
            // 
            this.receiveText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.receiveText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiveText.ForeColor = System.Drawing.Color.White;
            this.receiveText.Location = new System.Drawing.Point(10, 10);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.Size = new System.Drawing.Size(385, 462);
            this.receiveText.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.emailText);
            this.panel3.Location = new System.Drawing.Point(110, 99);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(405, 41);
            this.panel3.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailText.ForeColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(10, 10);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(385, 20);
            this.emailText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.passwordText);
            this.panel4.Location = new System.Drawing.Point(110, 160);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(405, 41);
            this.panel4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordText.ForeColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(10, 10);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(385, 20);
            this.passwordText.TabIndex = 13;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(962, 605);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.receivePanel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hack", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Text = "Rom4kMail";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.receivePanel.ResumeLayout(false);
            this.receivePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox recipientText;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel receivePanel;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.TextBox receiveText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox passwordText;
        private System.Windows.Forms.Label label6;
    }
}

