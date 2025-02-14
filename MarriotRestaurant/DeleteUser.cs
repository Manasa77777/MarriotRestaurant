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
    public partial class DeleteUser : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;
        string str,Uname,Pwd;
        int row;
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            da = new SqlDataAdapter("select Username ,Password, FirstName,LastName,HintQuestion, HintAnswer from Users where status = 1 ", str);
            ds = new DataSet();
            da.Fill(ds, "Users");
            da.FillSchema(ds, SchemaType.Source, "Users");
            cmb = new SqlCommandBuilder(da);

            dgvDeleteUser.DataSource = ds.Tables["Users"];



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(LoginForm._Uname!=Uname&& LoginForm._Pwd!=Pwd)
            {
                ds.Tables["Users"].Rows[row].Delete();
                da.Update(ds, "Users");
                MessageBox.Show("User has been deleted Successfully from the DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry you cant delete logged User Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDeleteUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            row = e.RowIndex;
            Uname = ds.Tables["Users"].Rows[row]["Username"].ToString();
            Pwd = ds.Tables["Users"].Rows[row]["Password"].ToString();
        }
    }
}
