namespace MarriotRestaurant
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            lblRegister = new Label();
            lblUname = new Label();
            txtUname = new TextBox();
            txtPwd = new TextBox();
            lblPwd = new Label();
            txtCPwd = new TextBox();
            lblCPwd = new Label();
            txtFName = new TextBox();
            lblFName = new Label();
            txtLName = new TextBox();
            lblLName = new Label();
            lblHQ = new Label();
            cmbHintQ = new ComboBox();
            txtHA = new TextBox();
            lblHA = new Label();
            btnCreate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = SystemColors.WindowFrame;
            lblRegister.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = SystemColors.ButtonHighlight;
            lblRegister.Location = new Point(219, 44);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(234, 34);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register Here";
            // 
            // lblUname
            // 
            lblUname.AutoSize = true;
            lblUname.BackColor = SystemColors.WindowFrame;
            lblUname.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUname.ForeColor = SystemColors.ButtonFace;
            lblUname.Location = new Point(45, 130);
            lblUname.Name = "lblUname";
            lblUname.Size = new Size(176, 25);
            lblUname.TabIndex = 1;
            lblUname.Text = "Enter Username";
            // 
            // txtUname
            // 
            txtUname.Location = new Point(270, 131);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(371, 28);
            txtUname.TabIndex = 2;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(270, 173);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(371, 28);
            txtPwd.TabIndex = 4;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.BackColor = SystemColors.WindowFrame;
            lblPwd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPwd.ForeColor = SystemColors.ButtonFace;
            lblPwd.Location = new Point(45, 172);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(167, 25);
            lblPwd.TabIndex = 3;
            lblPwd.Text = "Enter Password";
            // 
            // txtCPwd
            // 
            txtCPwd.Location = new Point(270, 212);
            txtCPwd.Name = "txtCPwd";
            txtCPwd.Size = new Size(371, 28);
            txtCPwd.TabIndex = 6;
            txtCPwd.UseSystemPasswordChar = true;
            // 
            // lblCPwd
            // 
            lblCPwd.AutoSize = true;
            lblCPwd.BackColor = SystemColors.WindowFrame;
            lblCPwd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCPwd.ForeColor = SystemColors.ButtonFace;
            lblCPwd.Location = new Point(45, 211);
            lblCPwd.Name = "lblCPwd";
            lblCPwd.Size = new Size(192, 25);
            lblCPwd.TabIndex = 5;
            lblCPwd.Text = "Confirm Password";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(270, 252);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(371, 28);
            txtFName.TabIndex = 8;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.BackColor = SystemColors.WindowFrame;
            lblFName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFName.ForeColor = SystemColors.ButtonFace;
            lblFName.Location = new Point(45, 251);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(184, 25);
            lblFName.TabIndex = 7;
            lblFName.Text = "Enter First Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(270, 290);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(371, 28);
            txtLName.TabIndex = 10;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.BackColor = SystemColors.WindowFrame;
            lblLName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.ForeColor = SystemColors.ButtonFace;
            lblLName.Location = new Point(45, 289);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(180, 25);
            lblLName.TabIndex = 9;
            lblLName.Text = "Enter Last Name";
            // 
            // lblHQ
            // 
            lblHQ.AutoSize = true;
            lblHQ.BackColor = SystemColors.WindowFrame;
            lblHQ.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHQ.ForeColor = SystemColors.ButtonFace;
            lblHQ.Location = new Point(44, 333);
            lblHQ.Name = "lblHQ";
            lblHQ.Size = new Size(220, 25);
            lblHQ.TabIndex = 11;
            lblHQ.Text = "Select Hint Question";
            // 
            // cmbHintQ
            // 
            cmbHintQ.FormattingEnabled = true;
            cmbHintQ.Items.AddRange(new object[] { "What was the name of your favorite childhood pet?", "What is your favorite sport?", "What’s your home address?", "What is your brightest childhood dream?", "What was the name of your first childhood friend?", "whats your DOB?" });
            cmbHintQ.Location = new Point(270, 336);
            cmbHintQ.Name = "cmbHintQ";
            cmbHintQ.Size = new Size(371, 28);
            cmbHintQ.TabIndex = 12;
            // 
            // txtHA
            // 
            txtHA.Location = new Point(271, 378);
            txtHA.Name = "txtHA";
            txtHA.Size = new Size(371, 28);
            txtHA.TabIndex = 14;
            // 
            // lblHA
            // 
            lblHA.AutoSize = true;
            lblHA.BackColor = SystemColors.WindowFrame;
            lblHA.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHA.ForeColor = SystemColors.ButtonFace;
            lblHA.Location = new Point(46, 377);
            lblHA.Name = "lblHA";
            lblHA.Size = new Size(197, 25);
            lblHA.TabIndex = 13;
            lblHA.Text = "Enter Hint Answer";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkKhaki;
            btnCreate.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(112, 435);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 39);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGreen;
            btnClear.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(262, 435);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 39);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightCoral;
            btnClose.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(412, 435);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 39);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.reg;
            ClientSize = new Size(694, 521);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(txtHA);
            Controls.Add(lblHA);
            Controls.Add(cmbHintQ);
            Controls.Add(lblHQ);
            Controls.Add(txtLName);
            Controls.Add(lblLName);
            Controls.Add(txtFName);
            Controls.Add(lblFName);
            Controls.Add(txtCPwd);
            Controls.Add(lblCPwd);
            Controls.Add(txtPwd);
            Controls.Add(lblPwd);
            Controls.Add(txtUname);
            Controls.Add(lblUname);
            Controls.Add(lblRegister);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marriot Restraunt";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private Label lblUname;
        private TextBox txtUname;
        private TextBox txtPwd;
        private Label lblPwd;
        private TextBox txtCPwd;
        private Label lblCPwd;
        private TextBox txtFName;
        private Label lblFName;
        private TextBox txtLName;
        private Label lblLName;
        private Label lblHQ;
        private ComboBox cmbHintQ;
        private TextBox txtHA;
        private Label lblHA;
        private Button btnCreate;
        private Button btnClear;
        private Button btnClose;
    }
}