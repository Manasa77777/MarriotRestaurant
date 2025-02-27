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
    public partial class PasswordForm : Form
    {
        string str;
        SqlConnection con;

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

            str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            con = new SqlConnection(str);

        }

        private void rbOldPwd_CheckedChanged(object sender, EventArgs e)
        {
            cmbHQ.Visible = false;
            lblSelectHQ.Visible = false;
            txtHAns.Visible = false;
            lblHAns.Visible = false;
            lblOPwd.Visible = true;
            txtOldPwd.Visible = true;
            txtNPwd.Text = txtRNPwd.Text = "";
            txtNPwd.Enabled = false;
            txtRNPwd.Enabled = false;
        }

        private void rbHintQue_CheckedChanged(object sender, EventArgs e)
        {
            cmbHQ.Visible = true;
            lblSelectHQ.Visible = true;
            txtHAns.Visible = true;
            lblHAns.Visible = true;
            lblOPwd.Visible = false;
            txtOldPwd.Visible = false;
            txtNPwd.Text = txtRNPwd.Text = "";
            txtNPwd.Enabled = false;
            txtRNPwd.Enabled = false;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbOldPwd.Checked && txtOldPwd.Text.Trim().Length > 0 && txtNPwd.Text.Trim().Length > 0 && txtRNPwd.Text.Trim().Length > 0 || rbHintQue.Checked && cmbHQ.SelectedIndex > 0 && txtHAns.Text.Trim().Length > 0 && txtNPwd.Text.Trim().Length > 0 && txtRNPwd.Text.Trim().Length > 0)
            {

                SqlCommand cmd = new SqlCommand($"update Users set Password='{txtNPwd.Text}' where Username='{LoginForm._Uname}'", con);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Password changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHAns.Text = txtNPwd.Text = txtRNPwd.Text = txtOldPwd.Text = "";
                    cmbHQ.SelectedIndex = 0;
                    txtNPwd.Enabled = false;
                    txtRNPwd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Password not successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOldPwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim().Length != 0)
            {

                SqlCommand cmd = new SqlCommand($"Select FirstName from Users where Username='{LoginForm._Uname}' and Password='{txtOldPwd.Text}'", con);
                con.Open();
                object Name = cmd.ExecuteScalar();

                if (Name != null)
                {
                    txtNPwd.Enabled = true;
                    txtRNPwd.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Invalid Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void txtHAns_MouseLeave(object sender, EventArgs e)
        {
            if (cmbHQ.SelectedIndex > -1 && txtHAns.Text.Trim().Length > 0)
            {

                SqlCommand cmd = new SqlCommand($"Select FirstName from Users where Username='{LoginForm._Uname}' and HintQuestion='{cmbHQ.SelectedItem}' and HintAnswer='{txtHAns.Text}' ", con);
                con.Open();
                object Name = cmd.ExecuteScalar();

                if (Name != null)
                {
                    txtNPwd.Enabled = true;
                    txtRNPwd.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Invalid Hint Question and Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void txtRNPwd_Validating(object sender, CancelEventArgs e)
        {
            if(txtNPwd.Text!=txtRNPwd.Text)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNPwd.Text = txtRNPwd.Text = "";
            }
        }
    }
}

