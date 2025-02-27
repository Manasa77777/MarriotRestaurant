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
using System.Data.Common;

namespace MarriotRestaurant
{
    public partial class BillTrans : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string str;
        int row;
        public BillTrans()
        {
            InitializeComponent();
        }

        private void BillTrans_Load(object sender, EventArgs e)
        {
            cmbSelItm.Items.Add("--Select item--");
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            da = new SqlDataAdapter("select ItemName from items order by ItemName asc", str);
            ds = new DataSet();
            da.Fill(ds, "Items");
            for (int i = 0; i < ds.Tables["Items"].Rows.Count; i++)
            {
                cmbSelItm.Items.Add(ds.Tables["Items"].Rows[i][0]);

            }

            dt = new DataTable("ItemBilling");//creating Table on the click of additem
            dt.Columns.Add("BillNumber", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Quantity", typeof(Int32));
            dt.Columns.Add("TotalPrice", typeof(double));
            ds.Tables.Add(dt);


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ds.Tables["ItemBilling"].Rows[row].Delete();

        }

        private void cmbSelItm_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            if (cmbSelItm.SelectedItem != "--Select item--")
            {
                cmd = new SqlCommand($"select Price from items where itemName = '{cmbSelItm.SelectedItem}'", con);
                con.Open();
                txtPrice.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            else
            {
                txtPrice.Text = txtQuantity.Text = txtTotPrice.Text = "";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int Qty = 0;
            if (txtQuantity.Text != "")
            {
                Qty = Convert.ToInt32(txtQuantity.Text);
                double Total = Convert.ToDouble(txtPrice.Text) * Qty;
                txtTotPrice.Text = Total.ToString();
            }
            else
            {
                txtTotPrice.Text = "";
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cmbSelItm.SelectedIndex > 0 && txtPrice.Text.Trim().Length > 0 && txtQuantity.Text.Trim().Length > 0 && txtTotPrice.Text.Trim().Length > 0)
            {
                dr = dt.NewRow();
                dr["BillNumber"] = BillMaster.BillNo;
                dr["ItemName"] = cmbSelItm.SelectedItem;
                dr["Price"] = txtPrice.Text;
                dr["Quantity"] = txtQuantity.Text;
                dr["TotalPrice"] = txtTotPrice.Text;
                dt.Rows.Add(dr);
                dgvItems.DataSource = ds.Tables["ItemBilling"];
                CommonData.commonDS = ds.Copy();
                txtQuantity.Text = txtTotPrice.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter all Required Fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(dgvItems.Rows.Count!=0)
            {
                double totalItemAmount = 0;
                for (int i = 0; i < ds.Tables["ItemBilling"].Rows.Count; i++)
                {
                    totalItemAmount = totalItemAmount + Convert.ToDouble(ds.Tables["ItemBilling"].Rows[i]["Price"]);
                }
                CommonData.totalItemPrice = totalItemAmount;

                CommonData.BillingOrderDateTime = DateTime.Now;

                con = new SqlConnection(str);
                cmd = new SqlCommand("select SGST from Tax ", con);
                con.Open();
                double SGST = Convert.ToDouble(cmd.ExecuteScalar());
                CommonData.SGSTPrice = (SGST / 100) * totalItemAmount;
                CommonData.CGSTPrice = CommonData.SGSTPrice;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please add items to the bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             row = e.RowIndex;
           
        }
    }
}
