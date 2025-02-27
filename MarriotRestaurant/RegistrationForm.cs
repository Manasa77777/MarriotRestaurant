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
            if (txtUname.Text.Trim().Length > 0 && txtPwd.Text.Trim().Length > 0 && txtFName.Text.Trim().Length > 0 && txtLName.Text.Trim().Length > 0 && cmbHintQ.SelectedItem != "" && txtHA.Text.Trim().Length > 0)
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
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtCPwd_Validating(object sender, CancelEventArgs e)
        {
            if (txtPwd.Text != txtCPwd.Text)
            {
                MessageBox.Show("Password and Confirm Password should be same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPwd.Text = txtPwd.Text = "";
                txtPwd.Focus();
            }

        }

        private void cmbHintQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbHintQ.SelectedIndex==0)
            {
                MessageBox.Show("Please Choose Security question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHintQ.SelectedIndex = -1;
            }
        }
    }
}
