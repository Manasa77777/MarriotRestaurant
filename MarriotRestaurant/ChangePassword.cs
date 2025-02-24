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
    public partial class ChangePassword : Form
    {
        SqlCommand cmd2;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtNewPwd.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Trim().Length > 0 && txtConPwd.Text.Trim().Length > 0)
            {
                string str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand($"Update Users set Password='{txtNewPwd.Text}' where Username='{ForgetPassword.Uname}' and HintQuestion='{ForgetPassword.HintQ}' and HintAnswer='{ForgetPassword.HintA}'", con);
                 cmd2 =new SqlCommand($"Select Password from Users where HintQuestion='{ForgetPassword.HintQ}' and HintAnswer='{ForgetPassword.HintA}'", con);
                con.Open();
                string OldPwd= cmd2.ExecuteScalar().ToString();
                con.Close();
                if(OldPwd!=txtNewPwd.Text)
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry Password is not Changed ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPwd.Text = txtConPwd.Text = "";
                        txtNewPwd.Focus();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("New Password should not be match with old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtConPwd_Validating(object sender, CancelEventArgs e)
        {
            if(txtNewPwd.Text != txtConPwd.Text)
            {
                MessageBox.Show("Confirm Password does not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPwd.Text = txtConPwd.Text = "";
            }
            
        }
    }
}
