using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace MarriotRestaurant
{
    public partial class ViewBill : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        string str;
        public ViewBill()
        {
            InitializeComponent();
        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            da = new SqlDataAdapter("select BillNumber from BillMaster ", str);
            ds = new DataSet();
            da.Fill(ds, "BillNumber_Details");
            for (int i = 0; i < ds.Tables["BillNumber_Details"].Rows.Count; i++)
            {
                cmbSBillNum.Items.Add(ds.Tables["BillNumber_Details"].Rows[i][0]);
            }

        }

        private void cmbSBillNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter($"select * from BillMaster where BillNumber ={cmbSBillNum.SelectedItem}", str);
            da.Fill(ds, "BillMaster_Details");
            dgvBillDetails.DataSource = ds.Tables["BillMaster_Details"];

            da = new SqlDataAdapter($"select * from BillTrans where BillNumber ={cmbSBillNum.SelectedItem}", str);
            da.Fill(ds, "Item_Details");
            dgvItemsDetails.DataSource = ds.Tables["Item_Details"];

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
