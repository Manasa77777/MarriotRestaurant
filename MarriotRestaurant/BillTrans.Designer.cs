namespace MarriotRestaurant
{
    partial class BillTrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillTrans));
            dgvItems = new DataGridView();
            lblSelItm = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblTotPrice = new Label();
            txtTotPrice = new TextBox();
            btnAdd = new Button();
            cmbSelItm = new ComboBox();
            btnOk = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Dock = DockStyle.Right;
            dgvItems.Location = new Point(532, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(823, 434);
            dgvItems.TabIndex = 0;
            dgvItems.RowHeaderMouseClick += dgvItems_RowHeaderMouseClick;
            // 
            // lblSelItm
            // 
            lblSelItm.AutoSize = true;
            lblSelItm.BackColor = Color.Lavender;
            lblSelItm.Location = new Point(64, 78);
            lblSelItm.Name = "lblSelItm";
            lblSelItm.Size = new Size(128, 25);
            lblSelItm.TabIndex = 18;
            lblSelItm.Text = "Select Item";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Lavender;
            lblPrice.Location = new Point(108, 146);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(84, 25);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Price is";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Menu;
            txtPrice.Enabled = false;
            txtPrice.Location = new Point(210, 139);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(292, 32);
            txtPrice.TabIndex = 19;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Lavender;
            lblQuantity.Location = new Point(30, 216);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(162, 25);
            lblQuantity.TabIndex = 22;
            lblQuantity.Text = "Enter Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Menu;
            txtQuantity.Location = new Point(210, 213);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(292, 32);
            txtQuantity.TabIndex = 21;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // lblTotPrice
            // 
            lblTotPrice.AutoSize = true;
            lblTotPrice.BackColor = Color.Lavender;
            lblTotPrice.Location = new Point(76, 294);
            lblTotPrice.Name = "lblTotPrice";
            lblTotPrice.Size = new Size(116, 25);
            lblTotPrice.TabIndex = 24;
            lblTotPrice.Text = "Total Price";
            // 
            // txtTotPrice
            // 
            txtTotPrice.BackColor = SystemColors.Menu;
            txtTotPrice.Enabled = false;
            txtTotPrice.Location = new Point(210, 287);
            txtTotPrice.Name = "txtTotPrice";
            txtTotPrice.Size = new Size(292, 32);
            txtTotPrice.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tan;
            btnAdd.Location = new Point(74, 369);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 38);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbSelItm
            // 
            cmbSelItm.BackColor = SystemColors.Menu;
            cmbSelItm.FormattingEnabled = true;
            cmbSelItm.Location = new Point(211, 82);
            cmbSelItm.Name = "cmbSelItm";
            cmbSelItm.Size = new Size(296, 33);
            cmbSelItm.TabIndex = 26;
            cmbSelItm.Text = "--Select item--";
            cmbSelItm.SelectedIndexChanged += cmbSelItm_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Tan;
            btnOk.Location = new Point(348, 369);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(118, 38);
            btnOk.TabIndex = 27;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Tan;
            btnRemove.Location = new Point(207, 369);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 38);
            btnRemove.TabIndex = 28;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // BillTrans
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1355, 434);
            Controls.Add(btnRemove);
            Controls.Add(btnOk);
            Controls.Add(cmbSelItm);
            Controls.Add(btnAdd);
            Controls.Add(lblTotPrice);
            Controls.Add(txtTotPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblSelItm);
            Controls.Add(dgvItems);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "BillTrans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Items";
            Load += BillTrans_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private Label lblSelItm;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblTotPrice;
        private TextBox txtTotPrice;
        private Button btnAdd;
        private ComboBox cmbSelItm;
        private Button btnOk;
        private Button btnRemove;
    }
}