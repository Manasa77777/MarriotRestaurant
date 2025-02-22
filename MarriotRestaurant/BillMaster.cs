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
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        public static int BillNo;
        SqlConnection con;
        SqlCommand cmd;
        string str;
        double Discount;
        double TotalAmt;

        public BillMaster()
        {
            InitializeComponent();
        }

        private void BillMaster_Load(object sender, EventArgs e)
        {
            NewBillNo();
        }
        private void NewBillNo()
        {
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            con = new SqlConnection(str);
            cmd = new SqlCommand("Select  IsNull(Max(BillNumber), 100) + 1 From BillMaster;", con);
            if(con.State!=ConnectionState.Open)
            {
                con.Open();
            }
            
            txtBillNum.Text = cmd.ExecuteScalar().ToString();
            con.Close();
            BillNo = Convert.ToInt32(txtBillNum.Text);

        }
        private void btnAddItm_Click(object sender, EventArgs e)
        {
            BillTrans billitems = new BillTrans();
            billitems.ShowDialog();


            txtBillDate.Text = CommonData.BillingOrderDateTime.ToShortDateString();
            txtBillAmount.Text = CommonData.totalItemPrice.ToString();
            txtSgst.Text = CommonData.SGSTPrice.ToString();
            txtCgst.Text = CommonData.CGSTPrice.ToString();



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = $"Insert into BillMaster (BillNumber,BillDate,BillAmount,CGST,SGST,Discount,TotalBill,Username) values({txtBillNum.Text},{txtBillDate.Text},{txtBillAmount.Text},{txtSgst.Text},{txtCgst.Text},{txtDiscount.Text},{txtTBillAmt.Text},'{LoginForm._Uname}')";
                con.Open();
                da = new SqlDataAdapter("Select * from BillTrans", con);
                cmb = new SqlCommandBuilder(da);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    if (CommonData.commonDS.HasChanges())
                    {
                        da.Update(CommonData.commonDS, "ItemBilling");
                        MessageBox.Show("Item Ordered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    txtBillAmount.Text = txtBillDate.Text = txtBillNum.Text = txtCgst.Text = txtSgst.Text = txtDiscount.Text = txtTBillAmt.Text= "";
                    NewBillNo();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBillAmount.Text = txtBillDate.Text = txtBillNum.Text = txtCgst.Text = txtSgst.Text = txtTBillAmt.Text = txtDiscount.Text = "";
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
                 Discount = (Convert.ToDouble(txtDiscount.Text) / 100) * AmtBeforeDis;
                 TotalAmt = AmtBeforeDis - Discount;
                txtTBillAmt.Text = TotalAmt.ToString();

            }

        }
    }
}
