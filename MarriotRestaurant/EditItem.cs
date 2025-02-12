using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.CodeDom.Compiler;

namespace MarriotRestaurant
{
    public partial class EditItem : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;
        DataRow dr;
        String str;
        int row;
        public EditItem()
        {
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {

            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            da = new SqlDataAdapter("Select ItemName,Price from Items Where Status=1", str);
            da.SelectCommand.CommandType = CommandType.Text;
            ds = new DataSet();
            da.Fill(ds, "Items");
            da.FillSchema(ds, SchemaType.Source, "Items");
            cmb = new SqlCommandBuilder(da);
            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = ds.Tables["Items"];
            GenerateColumns();

        }
        public void GenerateColumns()
        {
            dgvItem.Columns.Clear();
            DataGridViewTextBoxColumn colItemName = new DataGridViewTextBoxColumn();
            colItemName.HeaderText = "Item Name";
            colItemName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colItemName.Width = 300;
            colItemName.DataPropertyName = "ItemName";
            colItemName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvItem.Columns.Add(colItemName);


            DataGridViewTextBoxColumn colItemPrice = new DataGridViewTextBoxColumn();
            colItemPrice.HeaderText = "Price";
            colItemPrice.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colItemPrice.Width = 190;
            colItemPrice.DataPropertyName = "Price";
            colItemPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItem.Columns.Add(colItemPrice);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
          if(txtPrice.Text!="" && txtItem.Text!="")
            {
                ds.Tables["Items"].Rows[row]["Price"] = txtPrice.Text;
                MessageBox.Show("Item Price Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Text = txtItem.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select an item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ds.HasChanges())
            {
                da.Update(ds, "Items");
                MessageBox.Show("Item Price Updated Successfully in DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItem.Text = txtPrice.Text = "";
            }
            else
            {
                MessageBox.Show("No changes has to be done to save in database","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = e.RowIndex;
            txtItem.Text = dgvItem.Rows[row].Cells[0].Value.ToString();
            txtPrice.Text = dgvItem.Rows[row].Cells[1].Value.ToString();

        }
    }
}
