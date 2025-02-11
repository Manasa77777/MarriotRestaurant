using Microsoft.Data.SqlClient;
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

namespace MarriotRestaurant
{
    public partial class DeleteItem : Form
    {

        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlCommandBuilder cmb;
        string str;
        int row;
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtItem.Text != "" && txtPrice.Text != "")
            {
                ds.Tables["Items"].Rows[row].Delete();
                txtItem.Text = txtPrice.Text = "";
                MessageBox.Show("Item Deleted Successfully  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Select an Item ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            da = new SqlDataAdapter("select ItemName,Price from  Items where status=1", str);
            da.SelectCommand.CommandType = CommandType.Text;
            ds = new DataSet();
            da.Fill(ds, "Items");
            da.FillSchema(ds, SchemaType.Source, "Items");
            cmb = new SqlCommandBuilder(da);
            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = ds.Tables["Items"];
            GenerateColumns();
        }
        private void GenerateColumns()
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

        private void dgvItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = e.RowIndex;
            txtItem.Text = dgvItem.Rows[row].Cells[0].Value.ToString();
            txtPrice.Text = dgvItem.Rows[row].Cells[1].Value.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
