namespace MarriotRestaurant
{
    partial class DeleteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItem));
            btnClose = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtItem = new TextBox();
            lblItem = new Label();
            dgvItem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Salmon;
            btnClose.Location = new Point(350, 505);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 42);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CadetBlue;
            btnSave.Location = new Point(191, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 42);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Khaki;
            btnDelete.Location = new Point(34, 505);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 42);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(204, 449);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(273, 32);
            txtPrice.TabIndex = 12;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 456);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(154, 25);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Selected Price";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(204, 411);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(273, 32);
            txtItem.TabIndex = 10;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(25, 418);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(152, 25);
            lblItem.TabIndex = 9;
            lblItem.Text = "Selected Item";
            // 
            // dgvItem
            // 
            dgvItem.AllowUserToAddRows = false;
            dgvItem.AllowUserToDeleteRows = false;
            dgvItem.AllowUserToResizeColumns = false;
            dgvItem.AllowUserToResizeRows = false;
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Dock = DockStyle.Top;
            dgvItem.Location = new Point(0, 0);
            dgvItem.Name = "dgvItem";
            dgvItem.RowHeadersWidth = 51;
            dgvItem.Size = new Size(518, 376);
            dgvItem.TabIndex = 8;
            dgvItem.RowHeaderMouseClick += dgvItem_RowHeaderMouseClick;
            // 
            // DeleteItem
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(518, 562);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtItem);
            Controls.Add(lblItem);
            Controls.Add(dgvItem);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "DeleteItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Items";
            Load += DeleteItem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtItem;
        private Label lblItem;
        private DataGridView dgvItem;
    }
}