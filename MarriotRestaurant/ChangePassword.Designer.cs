namespace MarriotRestaurant
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            btnSave = new Button();
            txtConPwd = new TextBox();
            lblConPwd = new Label();
            lblCPwd = new Label();
            lblNewPwd = new Label();
            txtNewPwd = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(394, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 48);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtConPwd
            // 
            txtConPwd.Location = new Point(286, 169);
            txtConPwd.Margin = new Padding(5, 4, 5, 4);
            txtConPwd.Name = "txtConPwd";
            txtConPwd.Size = new Size(600, 32);
            txtConPwd.TabIndex = 22;
            // 
            // lblConPwd
            // 
            lblConPwd.AutoSize = true;
            lblConPwd.BackColor = SystemColors.WindowFrame;
            lblConPwd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConPwd.ForeColor = SystemColors.ButtonFace;
            lblConPwd.Location = new Point(35, 173);
            lblConPwd.Margin = new Padding(5, 0, 5, 0);
            lblConPwd.Name = "lblConPwd";
            lblConPwd.Size = new Size(192, 25);
            lblConPwd.TabIndex = 21;
            lblConPwd.Text = "Confirm Password";
            // 
            // lblCPwd
            // 
            lblCPwd.AutoSize = true;
            lblCPwd.Font = new Font("Verdana", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCPwd.Location = new Point(335, 24);
            lblCPwd.Margin = new Padding(5, 0, 5, 0);
            lblCPwd.Name = "lblCPwd";
            lblCPwd.Size = new Size(282, 36);
            lblCPwd.TabIndex = 24;
            lblCPwd.Text = "Change Password";
            // 
            // lblNewPwd
            // 
            lblNewPwd.AutoSize = true;
            lblNewPwd.BackColor = SystemColors.WindowFrame;
            lblNewPwd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPwd.ForeColor = SystemColors.ButtonFace;
            lblNewPwd.Location = new Point(35, 113);
            lblNewPwd.Margin = new Padding(5, 0, 5, 0);
            lblNewPwd.Name = "lblNewPwd";
            lblNewPwd.Size = new Size(217, 25);
            lblNewPwd.TabIndex = 25;
            lblNewPwd.Text = "Enter New Password";
            // 
            // txtNewPwd
            // 
            txtNewPwd.Location = new Point(286, 110);
            txtNewPwd.Margin = new Padding(5, 4, 5, 4);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(600, 32);
            txtNewPwd.TabIndex = 26;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 301);
            Controls.Add(txtNewPwd);
            Controls.Add(lblNewPwd);
            Controls.Add(lblCPwd);
            Controls.Add(btnSave);
            Controls.Add(txtConPwd);
            Controls.Add(lblConPwd);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ChangePassword";
            Text = "Change Password";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtConPwd;
        private Label lblConPwd;
        private Label lblCPwd;
        private Label lblNewPwd;
        private TextBox txtNewPwd;
    }
}