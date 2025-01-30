using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace MarriotRestaurant
{
    public partial class LoginForm : Form
    {
        public string _Fname, _Lname;

      

        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }

        private void linkLabelForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForm Pwd = new PasswordForm();
            Pwd.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
             string str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;//storing credentials in str variable
            SqlConnection con = new SqlConnection(str);//providing credentials to Sql connection class
            SqlCommand cmd = new SqlCommand($"Select * from Users where Username='{txtUname.Text}' and Password='{txtPwd.Text}'",con);//providing query and connection info to sql command class 
            cmd.CommandType = CommandType.Text;//telling to sql command class its a query in text format
            con.Open();
            dr = cmd.ExecuteReader(); //storing data after executing sql query
            if (dr.Read())
            {
                _Fname = dr["FirstName"].ToString();
                _Lname = dr["LastName"].ToString();
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
                
            }
            else 
            {
                MessageBox.Show("Invalid Username or Password","Wrong credentials",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUname.Clear();
                txtPwd.Clear();
            }
            con.Close();
        }
    }
}
