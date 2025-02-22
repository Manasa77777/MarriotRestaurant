namespace MarriotRestaurant
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            txtHA = new TextBox();
            lblHA = new Label();
            cmbHintQ = new ComboBox();
            lblHQ = new Label();
            lblFPwd = new Label();
            btnValidate = new Button();
            SuspendLayout();
            // 
            // txtHA
            // 
            txtHA.Location = new Point(294, 170);
            txtHA.Margin = new Padding(5, 4, 5, 4);
            txtHA.Name = "txtHA";
            txtHA.Size = new Size(600, 32);
            txtHA.TabIndex = 18;
            // 
            // lblHA
            // 
            lblHA.AutoSize = true;
            lblHA.BackColor = SystemColors.WindowFrame;
            lblHA.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHA.ForeColor = SystemColors.ButtonFace;
            lblHA.Location = new Point(43, 174);
            lblHA.Margin = new Padding(5, 0, 5, 0);
            lblHA.Name = "lblHA";
            lblHA.Size = new Size(197, 25);
            lblHA.TabIndex = 17;
            lblHA.Text = "Enter Hint Answer";
            // 
            // cmbHintQ
            // 
            cmbHintQ.FormattingEnabled = true;
            cmbHintQ.Items.AddRange(new object[] { "What was the name of your favorite childhood pet?", "What is your favorite sport?", "What’s your home address?", "What is your brightest childhood dream?", "What was the name of your first childhood friend?", "whats your DOB?" });
            cmbHintQ.Location = new Point(292, 118);
            cmbHintQ.Margin = new Padding(5, 4, 5, 4);
            cmbHintQ.Name = "cmbHintQ";
            cmbHintQ.Size = new Size(600, 33);
            cmbHintQ.TabIndex = 16;
            // 
            // lblHQ
            // 
            lblHQ.AutoSize = true;
            lblHQ.BackColor = SystemColors.WindowFrame;
            lblHQ.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHQ.ForeColor = SystemColors.ButtonFace;
            lblHQ.Location = new Point(40, 119);
            lblHQ.Margin = new Padding(5, 0, 5, 0);
            lblHQ.Name = "lblHQ";
            lblHQ.Size = new Size(220, 25);
            lblHQ.TabIndex = 15;
            lblHQ.Text = "Select Hint Question";
            // 
            // lblFPwd
            // 
            lblFPwd.AutoSize = true;
            lblFPwd.Font = new Font("Verdana", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFPwd.Location = new Point(345, 32);
            lblFPwd.Margin = new Padding(5, 0, 5, 0);
            lblFPwd.Name = "lblFPwd";
            lblFPwd.Size = new Size(264, 36);
            lblFPwd.TabIndex = 19;
            lblFPwd.Text = "Forgot Password";
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.Location = new Point(380, 241);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(170, 48);
            btnValidate.TabIndex = 20;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.billmasterbg;
            ClientSize = new Size(931, 309);
            Controls.Add(btnValidate);
            Controls.Add(lblFPwd);
            Controls.Add(txtHA);
            Controls.Add(lblHA);
            Controls.Add(cmbHintQ);
            Controls.Add(lblHQ);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            Load += ForgetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHA;
        private Label lblHA;
        private ComboBox cmbHintQ;
        private Label lblHQ;
        private Label lblFPwd;
        private Button btnValidate;
    }
}