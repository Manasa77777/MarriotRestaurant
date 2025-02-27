namespace MarriotRestaurant
{
    partial class ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            dgvViewUser = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewUser).BeginInit();
            SuspendLayout();
            // 
            // dgvViewUser
            // 
            dgvViewUser.AllowUserToAddRows = false;
            dgvViewUser.AllowUserToDeleteRows = false;
            dgvViewUser.AllowUserToResizeColumns = false;
            dgvViewUser.AllowUserToResizeRows = false;
            dgvViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewUser.Dock = DockStyle.Top;
            dgvViewUser.Enabled = false;
            dgvViewUser.Location = new Point(0, 0);
            dgvViewUser.Margin = new Padding(5, 4, 5, 4);
            dgvViewUser.Name = "dgvViewUser";
            dgvViewUser.RowHeadersWidth = 51;
            dgvViewUser.Size = new Size(842, 522);
            dgvViewUser.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(290, 544);
            btnClose.Margin = new Padding(5, 4, 5, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(294, 55);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(842, 626);
            Controls.Add(btnClose);
            Controls.Add(dgvViewUser);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ViewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View User";
            Load += ViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewUser;
        private Button btnClose;
    }
}