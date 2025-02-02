namespace MarriotRestaurant
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblTitle = new Label();
            lblUname = new Label();
            txtUname = new TextBox();
            txtPwd = new TextBox();
            lblPwd = new Label();
            btnLogin = new Button();
            btnClear = new Button();
            linkLabelForget = new LinkLabel();
            linkLabelUser = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Tan;
            lblTitle.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(279, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // lblUname
            // 
            lblUname.AutoSize = true;
            lblUname.BackColor = Color.Tan;
            lblUname.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUname.Location = new Point(110, 121);
            lblUname.Name = "lblUname";
            lblUname.Size = new Size(114, 25);
            lblUname.TabIndex = 1;
            lblUname.Text = "Username";
            // 
            // txtUname
            // 
            txtUname.Location = new Point(257, 122);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(335, 28);
            txtUname.TabIndex = 3;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(258, 173);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(335, 28);
            txtPwd.TabIndex = 5;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.BackColor = Color.Tan;
            lblPwd.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPwd.Location = new Point(109, 172);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(105, 25);
            lblPwd.TabIndex = 4;
            lblPwd.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Tan;
            btnLogin.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(208, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tan;
            btnClear.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(338, 230);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 39);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // linkLabelForget
            // 
            linkLabelForget.AutoSize = true;
            linkLabelForget.BackColor = Color.MistyRose;
            linkLabelForget.Location = new Point(203, 301);
            linkLabelForget.Name = "linkLabelForget";
            linkLabelForget.Size = new Size(159, 20);
            linkLabelForget.TabIndex = 8;
            linkLabelForget.TabStop = true;
            linkLabelForget.Text = "Forget Password?";
            linkLabelForget.LinkClicked += linkLabelForget_LinkClicked;
            // 
            // linkLabelUser
            // 
            linkLabelUser.AutoSize = true;
            linkLabelUser.BackColor = Color.MistyRose;
            linkLabelUser.Location = new Point(377, 301);
            linkLabelUser.Name = "linkLabelUser";
            linkLabelUser.Size = new Size(90, 20);
            linkLabelUser.TabIndex = 9;
            linkLabelUser.TabStop = true;
            linkLabelUser.Text = "New User";
            linkLabelUser.LinkClicked += linkLabelUser_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 450);
            Controls.Add(linkLabelUser);
            Controls.Add(linkLabelForget);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(lblPwd);
            Controls.Add(txtUname);
            Controls.Add(lblUname);
            Controls.Add(lblTitle);
            Font = new Font("Verdana", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Marriot Restraunt";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUname;
        private TextBox txtUname;
        private TextBox txtPwd;
        private Label lblPwd;
        private Button btnLogin;
        private Button btnClear;
        private LinkLabel linkLabelForget;
        private LinkLabel linkLabelUser;
    }
}
