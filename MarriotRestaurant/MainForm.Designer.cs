namespace MarriotRestaurant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            itemToolStripMenuItem = new ToolStripMenuItem();
            addItemsMenu = new ToolStripMenuItem();
            editItemsMenu = new ToolStripMenuItem();
            deleteItemsMenu = new ToolStripMenuItem();
            exitItemMenu = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            newUserMenu = new ToolStripMenuItem();
            deleteUserMenu = new ToolStripMenuItem();
            changePwdUserMenu = new ToolStripMenuItem();
            viewUserMenu = new ToolStripMenuItem();
            newBillMenu = new ToolStripMenuItem();
            newBillToolStripMenuItem = new ToolStripMenuItem();
            viewBillMenu = new ToolStripMenuItem();
            lblUser = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemToolStripMenuItem, userToolStripMenuItem, newBillMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(936, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemsMenu, editItemsMenu, deleteItemsMenu, exitItemMenu });
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(59, 24);
            itemToolStripMenuItem.Text = "&Items";
            // 
            // addItemsMenu
            // 
            addItemsMenu.Image = Properties.Resources.add;
            addItemsMenu.Name = "addItemsMenu";
            addItemsMenu.Size = new Size(224, 26);
            addItemsMenu.Text = "&Add Items";
            addItemsMenu.Click += addItemsMenu_Click;
            // 
            // editItemsMenu
            // 
            editItemsMenu.Image = Properties.Resources.edit;
            editItemsMenu.Name = "editItemsMenu";
            editItemsMenu.Size = new Size(224, 26);
            editItemsMenu.Text = "&Edit Items";
            editItemsMenu.Click += editItemsMenu_Click;
            // 
            // deleteItemsMenu
            // 
            deleteItemsMenu.Image = Properties.Resources.bin;
            deleteItemsMenu.Name = "deleteItemsMenu";
            deleteItemsMenu.Size = new Size(224, 26);
            deleteItemsMenu.Text = "&Delete items";
            deleteItemsMenu.Click += deleteItemsMenu_Click;
            // 
            // exitItemMenu
            // 
            exitItemMenu.Image = Properties.Resources.exit;
            exitItemMenu.Name = "exitItemMenu";
            exitItemMenu.Size = new Size(224, 26);
            exitItemMenu.Text = "E&xit ";
            exitItemMenu.Click += exitItemMenu_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newUserMenu, deleteUserMenu, changePwdUserMenu, viewUserMenu });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(52, 24);
            userToolStripMenuItem.Text = "&User";
            // 
            // newUserMenu
            // 
            newUserMenu.Image = Properties.Resources.newuser;
            newUserMenu.Name = "newUserMenu";
            newUserMenu.Size = new Size(224, 26);
            newUserMenu.Text = "Create &New User";
            newUserMenu.Click += newUserMenu_Click;
            // 
            // deleteUserMenu
            // 
            deleteUserMenu.Image = Properties.Resources.deleteuser;
            deleteUserMenu.Name = "deleteUserMenu";
            deleteUserMenu.Size = new Size(224, 26);
            deleteUserMenu.Text = "&Delete User";
            deleteUserMenu.Click += deleteUserMenu_Click;
            // 
            // changePwdUserMenu
            // 
            changePwdUserMenu.Image = Properties.Resources.reset_password;
            changePwdUserMenu.Name = "changePwdUserMenu";
            changePwdUserMenu.Size = new Size(224, 26);
            changePwdUserMenu.Text = "Change Pass&word";
            changePwdUserMenu.Click += changePwdUserMenu_Click;
            // 
            // viewUserMenu
            // 
            viewUserMenu.Image = Properties.Resources.View_user;
            viewUserMenu.Name = "viewUserMenu";
            viewUserMenu.Size = new Size(224, 26);
            viewUserMenu.Text = "&View Users";
            viewUserMenu.Click += viewUserMenu_Click;
            // 
            // newBillMenu
            // 
            newBillMenu.DropDownItems.AddRange(new ToolStripItem[] { newBillToolStripMenuItem, viewBillMenu });
            newBillMenu.Name = "newBillMenu";
            newBillMenu.Size = new Size(44, 24);
            newBillMenu.Text = "&Bill";
            // 
            // newBillToolStripMenuItem
            // 
            newBillToolStripMenuItem.Image = Properties.Resources.bill;
            newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
            newBillToolStripMenuItem.Size = new Size(224, 26);
            newBillToolStripMenuItem.Text = "&New Bill";
            newBillToolStripMenuItem.Click += newBillToolStripMenuItem_Click;
            // 
            // viewBillMenu
            // 
            viewBillMenu.Image = Properties.Resources.view_bill;
            viewBillMenu.Name = "viewBillMenu";
            viewBillMenu.Size = new Size(224, 26);
            viewBillMenu.Text = "V&iew Bill";
            viewBillMenu.Click += viewBillMenu_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.MediumAquamarine;
            lblUser.Location = new Point(231, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 562);
            Controls.Add(lblUser);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "Marriot Restraunt";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem addItemsToolStripMenuItem;
        private ToolStripMenuItem editItemsToolStripMenuItem;
        private ToolStripMenuItem deleteItemsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem createNewUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem viewUsersToolStripMenuItem;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem newBillToolStripMenuItem;
        private ToolStripMenuItem viewBillToolStripMenuItem;
        private Label lblUser;
        private ToolStripMenuItem addItemsTom;
        private ToolStripMenuItem addItemsMenu;
        private ToolStripMenuItem editItemsMenu;
        private ToolStripMenuItem deleteItemsMenu;
        private ToolStripMenuItem exitItemMenu;
        private ToolStripMenuItem newUserMenu;
        private ToolStripMenuItem deleteUserMenu;
        private ToolStripMenuItem changePwdUserMenu;
        private ToolStripMenuItem viewUserMenu;
        private ToolStripMenuItem newBillMenu;
        private ToolStripMenuItem viewBillMenu;
    }
}