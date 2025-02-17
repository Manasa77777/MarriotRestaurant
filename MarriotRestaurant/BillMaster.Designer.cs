namespace MarriotRestaurant
{
    partial class BillMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillMaster));
            lblBillNum = new Label();
            txtBillNum = new TextBox();
            txtBillDate = new TextBox();
            lblBillDate = new Label();
            lblBillAmount = new Label();
            txtBillAmount = new TextBox();
            label1 = new Label();
            txtSgst = new TextBox();
            lblCgst = new Label();
            txtCgst = new TextBox();
            lblSgst = new Label();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblTBillAmt = new Label();
            txtTBillAmt = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnAddItm = new Button();
            SuspendLayout();
            // 
            // lblBillNum
            // 
            lblBillNum.AutoSize = true;
            lblBillNum.BackColor = Color.Tan;
            lblBillNum.Location = new Point(53, 53);
            lblBillNum.Name = "lblBillNum";
            lblBillNum.Size = new Size(193, 25);
            lblBillNum.TabIndex = 14;
            lblBillNum.Text = "Enter Bill Number";
            // 
            // txtBillNum
            // 
            txtBillNum.BackColor = SystemColors.InactiveBorder;
            txtBillNum.Enabled = false;
            txtBillNum.Location = new Point(343, 50);
            txtBillNum.Name = "txtBillNum";
            txtBillNum.Size = new Size(435, 32);
            txtBillNum.TabIndex = 13;
            // 
            // txtBillDate
            // 
            txtBillDate.BackColor = SystemColors.InactiveBorder;
            txtBillDate.Enabled = false;
            txtBillDate.Location = new Point(343, 127);
            txtBillDate.Name = "txtBillDate";
            txtBillDate.Size = new Size(435, 32);
            txtBillDate.TabIndex = 15;
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.BackColor = Color.Tan;
            lblBillDate.Location = new Point(125, 127);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(121, 25);
            lblBillDate.TabIndex = 16;
            lblBillDate.Text = "Bill Date is";
            // 
            // lblBillAmount
            // 
            lblBillAmount.AutoSize = true;
            lblBillAmount.BackColor = Color.Tan;
            lblBillAmount.Location = new Point(93, 196);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(153, 25);
            lblBillAmount.TabIndex = 18;
            lblBillAmount.Text = "Bill Amount is";
            // 
            // txtBillAmount
            // 
            txtBillAmount.BackColor = SystemColors.InactiveBorder;
            txtBillAmount.Enabled = false;
            txtBillAmount.Location = new Point(343, 196);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(435, 32);
            txtBillAmount.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 258);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 20;
            // 
            // txtSgst
            // 
            txtSgst.BackColor = SystemColors.InactiveBorder;
            txtSgst.Enabled = false;
            txtSgst.Location = new Point(343, 258);
            txtSgst.Name = "txtSgst";
            txtSgst.Size = new Size(435, 32);
            txtSgst.TabIndex = 19;
            // 
            // lblCgst
            // 
            lblCgst.AutoSize = true;
            lblCgst.BackColor = Color.Tan;
            lblCgst.Location = new Point(155, 319);
            lblCgst.Name = "lblCgst";
            lblCgst.Size = new Size(91, 25);
            lblCgst.TabIndex = 22;
            lblCgst.Text = "CGST is";
            // 
            // txtCgst
            // 
            txtCgst.BackColor = SystemColors.InactiveBorder;
            txtCgst.Enabled = false;
            txtCgst.Location = new Point(343, 319);
            txtCgst.Name = "txtCgst";
            txtCgst.Size = new Size(435, 32);
            txtCgst.TabIndex = 21;
            // 
            // lblSgst
            // 
            lblSgst.AutoSize = true;
            lblSgst.BackColor = Color.Tan;
            lblSgst.Location = new Point(155, 265);
            lblSgst.Name = "lblSgst";
            lblSgst.Size = new Size(91, 25);
            lblSgst.TabIndex = 23;
            lblSgst.Text = "SGST is";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.BackColor = Color.Tan;
            lblDiscount.Location = new Point(85, 386);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(161, 25);
            lblDiscount.TabIndex = 25;
            lblDiscount.Text = "Enter Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = SystemColors.InactiveBorder;
            txtDiscount.Location = new Point(343, 383);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(435, 32);
            txtDiscount.TabIndex = 24;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // lblTBillAmt
            // 
            lblTBillAmt.AutoSize = true;
            lblTBillAmt.BackColor = Color.Tan;
            lblTBillAmt.Location = new Point(61, 442);
            lblTBillAmt.Name = "lblTBillAmt";
            lblTBillAmt.Size = new Size(185, 25);
            lblTBillAmt.TabIndex = 27;
            lblTBillAmt.Text = "Total Bill Amount";
            // 
            // txtTBillAmt
            // 
            txtTBillAmt.BackColor = SystemColors.InactiveBorder;
            txtTBillAmt.Enabled = false;
            txtTBillAmt.Location = new Point(343, 439);
            txtTBillAmt.Name = "txtTBillAmt";
            txtTBillAmt.Size = new Size(435, 32);
            txtTBillAmt.TabIndex = 26;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Tan;
            btnSave.Location = new Point(224, 550);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tan;
            btnClear.Location = new Point(358, 550);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tan;
            btnClose.Location = new Point(496, 551);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 38);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddItm
            // 
            btnAddItm.BackColor = Color.Tan;
            btnAddItm.Location = new Point(334, 494);
            btnAddItm.Name = "btnAddItm";
            btnAddItm.Size = new Size(159, 37);
            btnAddItm.TabIndex = 31;
            btnAddItm.Text = "Add Item";
            btnAddItm.UseVisualStyleBackColor = false;
            btnAddItm.Click += btnAddItm_Click;
            // 
            // BillMaster
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 641);
            Controls.Add(btnAddItm);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblTBillAmt);
            Controls.Add(txtTBillAmt);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblSgst);
            Controls.Add(lblCgst);
            Controls.Add(txtCgst);
            Controls.Add(label1);
            Controls.Add(txtSgst);
            Controls.Add(lblBillAmount);
            Controls.Add(txtBillAmount);
            Controls.Add(lblBillDate);
            Controls.Add(txtBillDate);
            Controls.Add(lblBillNum);
            Controls.Add(txtBillNum);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "BillMaster";
            Text = "Bill Master";
            Load += BillMaster_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBillNum;
        private TextBox txtBillNum;
        private TextBox txtBillDate;
        private Label lblBillDate;
        private Label lblBillAmount;
        private TextBox txtBillAmount;
        private Label label1;
        private TextBox txtSgst;
        private Label lblCgst;
        private TextBox txtCgst;
        private Label lblSgst;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblTBillAmt;
        private TextBox txtTBillAmt;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
        private Button btnAddItm;
    }
}