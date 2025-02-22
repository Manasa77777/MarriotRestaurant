namespace MarriotRestaurant
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            dgvItem = new DataGridView();
            lblItem = new Label();
            txtItem = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            SuspendLayout();
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
            dgvItem.Size = new Size(550, 376);
            dgvItem.TabIndex = 0;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(67, 399);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(121, 25);
            lblItem.TabIndex = 1;
            lblItem.Text = "Enter Item";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(204, 396);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(273, 32);
            txtItem.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(204, 434);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(273, 32);
            txtPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(67, 437);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(123, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Enter Price";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Khaki;
            btnAdd.Location = new Point(47, 490);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 42);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CadetBlue;
            btnSave.Location = new Point(204, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Salmon;
            btnClose.Location = new Point(363, 490);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 42);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(550, 562);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtItem);
            Controls.Add(lblItem);
            Controls.Add(dgvItem);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item";
            Load += AddItem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItem;
        private Label lblItem;
        private TextBox txtItem;
        private TextBox txtPrice;
        private Label lblPrice;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClose;
    }
}