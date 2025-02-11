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
    public partial class AddItem : Form
    {
        
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlCommandBuilder cmb;

        string str;
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItem.Text.Trim().Length > 0 && txtPrice.Text.Trim().Length > 0)
            {
                dr = ds.Tables["Items"].NewRow();
                dr[0] = txtItem.Text;
                dr[1] = txtPrice.Text;
                ds.Tables["Items"].Rows.Add(dr);
                txtItem.Text = txtPrice.Text = "";
                MessageBox.Show("Item added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter Item Name and Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ds.HasChanges())
            {
                da.Update(ds, "Items");
                MessageBox.Show("Data saved Successfully in DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Items To Save in DataBase", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
