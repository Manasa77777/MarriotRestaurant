namespace MarriotRestaurant
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            rbOldPwd = new RadioButton();
            rbHintQue = new RadioButton();
            lblType = new Label();
            cmbHQ = new ComboBox();
            txtOldPwd = new TextBox();
            lblSelectHQ = new Label();
            lblOPwd = new Label();
            lblHAns = new Label();
            txtHAns = new TextBox();
            lblNPwd = new Label();
            txtNPwd = new TextBox();
            lblRNPwd = new Label();
            txtRNPwd = new TextBox();
            btnClose = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // rbOldPwd
            // 
            rbOldPwd.AutoSize = true;
            rbOldPwd.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbOldPwd.Location = new Point(99, 100);
            rbOldPwd.Name = "rbOldPwd";
            rbOldPwd.Size = new Size(258, 29);
            rbOldPwd.TabIndex = 0;
            rbOldPwd.TabStop = true;
            rbOldPwd.Text = "Using Old Password";
            rbOldPwd.UseVisualStyleBackColor = true;
            rbOldPwd.CheckedChanged += rbOldPwd_CheckedChanged;
            // 
            // rbHintQue
            // 
            rbHintQue.AutoSize = true;
            rbHintQue.Font = new Font("Verdana", 12F, FontStyle.Bold);
            rbHintQue.Location = new Point(366, 100);
            rbHintQue.Name = "rbHintQue";
            rbHintQue.Size = new Size(257, 29);
            rbHintQue.TabIndex = 1;
            rbHintQue.TabStop = true;
            rbHintQue.Text = "Using Hint Question";
            rbHintQue.UseVisualStyleBackColor = true;
            rbHintQue.CheckedChanged += rbHintQue_CheckedChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(284, 23);
            lblType.Name = "lblType";
            lblType.Size = new Size(198, 34);
            lblType.TabIndex = 2;
            lblType.Text = "Select Type";
            // 
            // cmbHQ
            // 
            cmbHQ.FormattingEnabled = true;
            cmbHQ.Items.AddRange(new object[] { "----Select Security Question----", "What was the name of your favorite childhood pet?", "What is your favorite sport?", "What’s your home address?", "What is your brightest childhood dream?", "What was the name of your first childhood friend?", "whats your DOB?" });
            cmbHQ.Location = new Point(327, 161);
            cmbHQ.Name = "cmbHQ";
            cmbHQ.Size = new Size(435, 33);
            cmbHQ.TabIndex = 3;
            cmbHQ.Text = "----Select Security Question----";
            // 
            // txtOldPwd
            // 
            txtOldPwd.Location = new Point(327, 223);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(435, 32);
            txtOldPwd.TabIndex = 4;
            txtOldPwd.MouseLeave += txtOldPwd_MouseLeave;
            // 
            // lblSelectHQ
            // 
            lblSelectHQ.AutoSize = true;
            lblSelectHQ.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblSelectHQ.Location = new Point(31, 164);
            lblSelectHQ.Name = "lblSelectHQ";
            lblSelectHQ.Size = new Size(241, 25);
            lblSelectHQ.TabIndex = 5;
            lblSelectHQ.Text = "Select Hint Question";
            // 
            // lblOPwd
            // 
            lblOPwd.AutoSize = true;
            lblOPwd.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblOPwd.Location = new Point(31, 226);
            lblOPwd.Name = "lblOPwd";
            lblOPwd.Size = new Size(234, 25);
            lblOPwd.TabIndex = 6;
            lblOPwd.Text = "Enter Old Password";
            // 
            // lblHAns
            // 
            lblHAns.AutoSize = true;
            lblHAns.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblHAns.Location = new Point(31, 238);
            lblHAns.Name = "lblHAns";
            lblHAns.Size = new Size(218, 25);
            lblHAns.TabIndex = 8;
            lblHAns.Text = "Enter Hint Answer";
            // 
            // txtHAns
            // 
            txtHAns.Location = new Point(327, 235);
            txtHAns.Name = "txtHAns";
            txtHAns.Size = new Size(435, 32);
            txtHAns.TabIndex = 7;
            txtHAns.MouseLeave += txtHAns_MouseLeave;
            // 
            // lblNPwd
            // 
            lblNPwd.AutoSize = true;
            lblNPwd.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblNPwd.Location = new Point(31, 304);
            lblNPwd.Name = "lblNPwd";
            lblNPwd.Size = new Size(246, 25);
            lblNPwd.TabIndex = 10;
            lblNPwd.Text = "Enter New Password";
            // 
            // txtNPwd
            // 
            txtNPwd.Enabled = false;
            txtNPwd.Location = new Point(327, 301);
            txtNPwd.Name = "txtNPwd";
            txtNPwd.Size = new Size(435, 32);
            txtNPwd.TabIndex = 9;
            // 
            // lblRNPwd
            // 
            lblRNPwd.AutoSize = true;
            lblRNPwd.Font = new Font("Verdana", 12F, FontStyle.Bold);
            lblRNPwd.Location = new Point(31, 383);
            lblRNPwd.Name = "lblRNPwd";
            lblRNPwd.Size = new Size(285, 25);
            lblRNPwd.TabIndex = 12;
            lblRNPwd.Text = "Re-Enter New Password";
            // 
            // txtRNPwd
            // 
            txtRNPwd.Enabled = false;
            txtRNPwd.Location = new Point(327, 380);
            txtRNPwd.Name = "txtRNPwd";
            txtRNPwd.Size = new Size(435, 32);
            txtRNPwd.TabIndex = 11;
            txtRNPwd.Validating += txtRNPwd_Validating;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.RosyBrown;
            btnClose.Location = new Point(435, 456);
            btnClose.Margin = new Padding(5, 4, 5, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(194, 37);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LightGreen;
            btnSubmit.Location = new Point(214, 456);
            btnSubmit.Margin = new Padding(5, 4, 5, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(195, 37);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 562);
            Controls.Add(btnSubmit);
            Controls.Add(btnClose);
            Controls.Add(lblRNPwd);
            Controls.Add(txtRNPwd);
            Controls.Add(lblNPwd);
            Controls.Add(txtNPwd);
            Controls.Add(lblHAns);
            Controls.Add(txtHAns);
            Controls.Add(lblOPwd);
            Controls.Add(lblSelectHQ);
            Controls.Add(txtOldPwd);
            Controls.Add(cmbHQ);
            Controls.Add(lblType);
            Controls.Add(rbHintQue);
            Controls.Add(rbOldPwd);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password";
            Load += PasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbOldPwd;
        private RadioButton rbHintQue;
        private Label lblType;
        private ComboBox cmbHQ;
        private TextBox txtOldPwd;
        private Label lblSelectHQ;
        private Label lblOPwd;
        private Label lblHAns;
        private TextBox txtHAns;
        private Label lblNPwd;
        private TextBox txtNPwd;
        private Label lblRNPwd;
        private TextBox txtRNPwd;
        private Button btnClose;
        private Button btnSubmit;
    }
}