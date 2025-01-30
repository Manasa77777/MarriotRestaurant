namespace MarriotRestaurant
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            btnClose = new Button();
            btnSave = new Button();
            btnEdit = new Button();
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
            btnClose.Location = new Point(350, 513);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 42);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CadetBlue;
            btnSave.Location = new Point(191, 513);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 42);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Location = new Point(34, 513);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 42);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(204, 457);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(273, 32);
            txtPrice.TabIndex = 20;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(59, 463);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(123, 25);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "Enter Price";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(204, 419);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(273, 32);
            txtItem.TabIndex = 18;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(61, 425);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(59, 25);
            lblItem.TabIndex = 17;
            lblItem.Text = "Item";
            // 
            // dgvItem
            // 
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Dock = DockStyle.Top;
            dgvItem.Location = new Point(0, 0);
            dgvItem.Name = "dgvItem";
            dgvItem.RowHeadersWidth = 51;
            dgvItem.Size = new Size(549, 395);
            dgvItem.TabIndex = 16;
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(549, 562);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtItem);
            Controls.Add(lblItem);
            Controls.Add(dgvItem);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "EditItem";
            Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private Button btnEdit;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtItem;
        private Label lblItem;
        private DataGridView dgvItem;
    }
}