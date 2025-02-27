namespace MarriotRestaurant
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            dgvDeleteUser = new DataGridView();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteUser).BeginInit();
            SuspendLayout();
            // 
            // dgvDeleteUser
            // 
            dgvDeleteUser.AllowUserToAddRows = false;
            dgvDeleteUser.AllowUserToDeleteRows = false;
            dgvDeleteUser.AllowUserToResizeColumns = false;
            dgvDeleteUser.AllowUserToResizeRows = false;
            dgvDeleteUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteUser.Dock = DockStyle.Top;
            dgvDeleteUser.Location = new Point(0, 0);
            dgvDeleteUser.Name = "dgvDeleteUser";
            dgvDeleteUser.RowHeadersWidth = 51;
            dgvDeleteUser.Size = new Size(900, 418);
            dgvDeleteUser.TabIndex = 0;
            dgvDeleteUser.RowHeaderMouseClick += dgvDeleteUser_RowHeaderMouseClick;
            dgvDeleteUser.RowValidating += dgvDeleteUser_RowValidating;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(237, 466);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(196, 44);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(439, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(181, 44);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 562);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(dgvDeleteUser);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "DeleteUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete User";
            Load += DeleteUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeleteUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDeleteUser;
        private Button btnDelete;
        private Button btnClose;
    }
}