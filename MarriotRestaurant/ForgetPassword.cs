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
    public partial class ForgetPassword : Form
    {
        public static string Uname, HintQ, HintA;


        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            cmbHintQ.Focus();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(cmbHintQ.SelectedIndex!= 0 && txtHA.Text.Trim().Length>0)
            {
                SqlDataReader dr;
                string str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand($"Select Username ,HintQuestion,HintAnswer from Users where HintQuestion ='{cmbHintQ.SelectedItem}' and HintAnswer='{txtHA.Text}'", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Uname = dr["Username"].ToString();
                    HintQ = dr["HintQuestion"].ToString();
                    HintA = dr["HintAnswer"].ToString();
                    ChangePassword cp = new ChangePassword();
                    cp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Hint Question or Answer", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbHintQ.SelectedIndex = -1;
                    txtHA.Clear();
                    cmbHintQ.Focus();
                }

                con.Close();
            }
            else
            {
                MessageBox.Show( "Please Fill all Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
