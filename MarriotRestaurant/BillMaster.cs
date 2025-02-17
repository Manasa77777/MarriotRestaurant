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
    public partial class BillMaster : Form
    {
        public static int BillNo;
        SqlConnection con;
        SqlCommand cmd;
        string str;

        public BillMaster()
        {
            InitializeComponent();
        }

        private void BillMaster_Load(object sender, EventArgs e)
        {
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            con = new SqlConnection(str);
            cmd = new SqlCommand("Select  IsNull(Max(BillNumber), 100) + 1 From BillMaster;", con);
            con.Open();
            txtBillNum.Text = cmd.ExecuteScalar().ToString();
            con.Close();
            BillNo = Convert.ToInt32(txtBillNum.Text);


        }

        private void btnAddItm_Click(object sender, EventArgs e)
        {
            BillTrans billitems = new BillTrans();
            billitems.ShowDialog();


            txtBillDate.Text = CommonData.BillingOrderDateTime.ToString();
            txtBillAmount.Text = CommonData.totalItemPrice.ToString();
            txtSgst.Text = CommonData.SGSTPrice.ToString();
            txtCgst.Text = CommonData.CGSTPrice.ToString();



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtDiscount.Text!="")
            {
                double AmtBeforeDis= Convert.ToDouble(txtBillAmount.Text)+Convert.ToDouble(txtSgst.Text) +Convert.ToDouble( txtCgst.Text);
                double Discount = (Convert.ToDouble(txtDiscount.Text) / 100) * AmtBeforeDis;
                double TotalAmt = AmtBeforeDis - Discount;
                txtTBillAmt.Text = TotalAmt.ToString();

            }

        }
    }
}
