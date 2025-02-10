using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarriotRestaurant
{
    public partial class MainForm : Form
    {
        AddItem additemform;
        EditItem edititemform;
        DeleteItem deleteItemform;
        RegistrationForm regform;
        DeleteUser delUserform;
        ChangePassword changepwd;
        ViewUser viewuser;
        BillMaster newBill;
        ViewBill viewBill;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Welcome, {LoginForm._Fname} {LoginForm._Lname} to Marriot Restrurant ";
        }


        private void addItemsMenu_Click(object sender, EventArgs e)
        {
            if (additemform == null)
            {
                additemform = new AddItem();

            }

            additemform.MdiParent = this;
            additemform.Show();
        }

        private void editItemsMenu_Click(object sender, EventArgs e)
        {
            if (edititemform == null)
            {
                edititemform = new EditItem();
            }

            edititemform.MdiParent = this;
            edititemform.Show();
        }

        private void deleteItemsMenu_Click(object sender, EventArgs e)
        {
            if (deleteItemform == null)
            {
                deleteItemform = new DeleteItem();
            }

            deleteItemform.MdiParent = this;
            deleteItemform.Show();
        }

        private void exitItemMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newUserMenu_Click(object sender, EventArgs e)
        {
            if(regform==null)
            {
                regform = new RegistrationForm();
            }
            regform.MdiParent = this;
            regform.Show();

        }

        private void deleteUserMenu_Click(object sender, EventArgs e)
        {
            if (delUserform == null)
            {
                delUserform = new DeleteUser();

            }
            delUserform.MdiParent = this;
            delUserform.Show();

        }

        private void changePwdUserMenu_Click(object sender, EventArgs e)
        {
            if (changepwd == null)
            {
                changepwd = new ChangePassword();

            }
            changepwd.MdiParent = this;
            changepwd.Show();
        }

        private void viewUserMenu_Click(object sender, EventArgs e)
        {
            if (viewuser == null)
            {
                viewuser = new ViewUser();

            }
            viewuser.MdiParent = this;
            viewuser.Show();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newBill == null)
            {
                newBill = new BillMaster();

            }
            newBill.MdiParent = this;
            newBill.Show();
        }

        private void viewBillMenu_Click(object sender, EventArgs e)
        {
            if (viewBill == null)
            {
                viewBill = new ViewBill();

            }
            viewBill.MdiParent = this;
            viewBill.Show();
        }
    }
}
