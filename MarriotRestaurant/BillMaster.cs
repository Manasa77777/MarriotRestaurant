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
        public static  int BillNo; 
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
            txtBillNum.Text=cmd.ExecuteScalar().ToString();
            con.Close();
            BillNo = Convert.ToInt32(txtBillNum.Text);

            
        }

        private void btnAddItm_Click(object sender, EventArgs e)
        {
            BillTrans billitems = new BillTrans();
            billitems.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
