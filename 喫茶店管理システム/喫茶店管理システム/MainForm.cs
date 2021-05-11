using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 喫茶店管理システム
{
    public partial class MainForm : Form
    {
        public string userName = string.Empty;
        public string userID = string.Empty;
        public string userSex = string.Empty;
        public string userLevel = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void CustomizeDesing()
        {

        }

        private void HideSubMenu()
        {

        }

        private void ShowSubMenu(Guna.UI2.WinForms.Suite.Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = userName;
            txtLevel.Text = userLevel;

            if (userSex == "男性")
            {
                boxMan.Visible = true;
                boxFemale.Visible = false;
            }
            else
            {
                boxMan.Visible = false;
                boxFemale.Visible = true;
            }

            pnlSeki.Visible = true;
            pnlFood.Visible = false;
        }

        private void boxMenu_Click(object sender, EventArgs e)
        {
            if (panelMainMenu.Width == 38)
            {
                panelMainMenu.Width = 187;
                boxLogo.Visible = true;
                lblLogo.Visible = true;
            }
            else
            {
                panelMainMenu.Width = 38;
                boxLogo.Visible = false;
                lblLogo.Visible = false;
            }
        }

        private void boxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSeki_Click(object sender, EventArgs e)
        {
            pnlSeki.Visible = true;
            pnlFood.Visible = false;
            pnlDrink.Visible = false;
            pnlDesert.Visible = false;
        }

        private void btnFoodOlder_Click(object sender, EventArgs e)
        {
            pnlSeki.Visible = false;
            pnlFood.Visible = true;
            pnlDrink.Visible = false;
            pnlDesert.Visible = false;
        }

        private void btnDrinkOder_Click(object sender, EventArgs e)
        {
            pnlSeki.Visible = false;
            pnlFood.Visible = false;
            pnlDrink.Visible = true;
            pnlDesert.Visible = false;
        }

        private void btnDesertOder_Click(object sender, EventArgs e)
        {
            pnlSeki.Visible = false;
            pnlFood.Visible = false;
            pnlDrink.Visible = false;
            pnlDesert.Visible = true;
        }

        private void btnTb6_Click(object sender, EventArgs e)
        {
            pnlBill.Visible = true;
            lbl_TableNo.Text = "Table " + btnTb6.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlBill.Visible = false;
        }

    }
}
