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
    public partial class ViewUser : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        string str;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            da = new SqlDataAdapter("select Username ,Password, FirstName,LastName,HintQuestion, HintAnswer from Users where status = 1 ", str);
            ds = new DataSet();
            da.Fill(ds, "Users");
            da.FillSchema(ds, SchemaType.Source, "Users");


            dgvViewUser.DataSource = ds.Tables["Users"];

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
