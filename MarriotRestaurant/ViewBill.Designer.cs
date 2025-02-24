namespace MarriotRestaurant
{
    partial class ViewBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBill));
            cmbSBillNum = new ComboBox();
            lblSBillNum = new Label();
            lblBillDetails = new Label();
            dgvBillDetails = new DataGridView();
            lblItemsDetails = new Label();
            dgvItemsDetails = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsDetails).BeginInit();
            SuspendLayout();
            // 
            // cmbSBillNum
            // 
            cmbSBillNum.FormattingEnabled = true;
            cmbSBillNum.Location = new Point(396, 49);
            cmbSBillNum.Name = "cmbSBillNum";
            cmbSBillNum.Size = new Size(309, 33);
            cmbSBillNum.TabIndex = 0;
            cmbSBillNum.Text = "--Select Bill Number--";
            cmbSBillNum.SelectedIndexChanged += cmbSBillNum_SelectedIndexChanged;
            // 
            // lblSBillNum
            // 
            lblSBillNum.AutoSize = true;
            lblSBillNum.Location = new Point(151, 52);
            lblSBillNum.Name = "lblSBillNum";
            lblSBillNum.Size = new Size(200, 25);
            lblSBillNum.TabIndex = 1;
            lblSBillNum.Text = "Select Bill Number";
            // 
            // lblBillDetails
            // 
            lblBillDetails.AutoSize = true;
            lblBillDetails.Location = new Point(12, 125);
            lblBillDetails.Name = "lblBillDetails";
            lblBillDetails.Size = new Size(120, 25);
            lblBillDetails.TabIndex = 2;
            lblBillDetails.Text = "Bill Details";
            // 
            // dgvBillDetails
            // 
            dgvBillDetails.AllowUserToAddRows = false;
            dgvBillDetails.AllowUserToDeleteRows = false;
            dgvBillDetails.AllowUserToResizeColumns = false;
            dgvBillDetails.AllowUserToResizeRows = false;
            dgvBillDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetails.Location = new Point(12, 153);
            dgvBillDetails.Name = "dgvBillDetails";
            dgvBillDetails.RowHeadersWidth = 51;
            dgvBillDetails.Size = new Size(831, 140);
            dgvBillDetails.TabIndex = 3;
            // 
            // lblItemsDetails
            // 
            lblItemsDetails.AutoSize = true;
            lblItemsDetails.Location = new Point(23, 324);
            lblItemsDetails.Name = "lblItemsDetails";
            lblItemsDetails.Size = new Size(145, 25);
            lblItemsDetails.TabIndex = 4;
            lblItemsDetails.Text = "Items Details";
            // 
            // dgvItemsDetails
            // 
            dgvItemsDetails.AllowUserToAddRows = false;
            dgvItemsDetails.AllowUserToDeleteRows = false;
            dgvItemsDetails.AllowUserToResizeColumns = false;
            dgvItemsDetails.AllowUserToResizeRows = false;
            dgvItemsDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsDetails.Location = new Point(12, 365);
            dgvItemsDetails.Name = "dgvItemsDetails";
            dgvItemsDetails.RowHeadersWidth = 51;
            dgvItemsDetails.Size = new Size(831, 192);
            dgvItemsDetails.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(328, 580);
            btnClose.Margin = new Padding(5, 4, 5, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(194, 37);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ViewBill
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.marriotbg;
            ClientSize = new Size(870, 639);
            Controls.Add(btnClose);
            Controls.Add(dgvItemsDetails);
            Controls.Add(lblItemsDetails);
            Controls.Add(dgvBillDetails);
            Controls.Add(lblBillDetails);
            Controls.Add(lblSBillNum);
            Controls.Add(cmbSBillNum);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ViewBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Bill";
            Load += ViewBill_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSBillNum;
        private Label lblSBillNum;
        private Label lblBillDetails;
        private DataGridView dgvBillDetails;
        private Label lblItemsDetails;
        private DataGridView dgvItemsDetails;
        private Button btnClose;
    }
}