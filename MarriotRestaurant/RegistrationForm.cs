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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["Sqlcon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand($"insert into Users(Username,password,FirstName,LastName,HintQuestion,HintAnswer) values('{txtUname.Text}','{txtPwd.Text}','{txtFName.Text}','{txtLName.Text}','{cmbHintQ.SelectedItem}','{txtHA.Text}')", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            int confirm = cmd.ExecuteNonQuery();
            if (confirm > 0)
            {
                MessageBox.Show("You have registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUname.Text = txtPwd.Text = txtFName.Text = txtLName.Text = txtCPwd.Text = txtHA.Text = "";
                cmbHintQ.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Sorry registration cannot be done", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            txtUname.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUname.Text = txtPwd.Text = txtCPwd.Text = txtFName.Text = txtLName.Text = txtHA.Text = "";
            cmbHintQ.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
