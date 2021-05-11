using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Componet_For_Coffee_Shop;

namespace 喫茶店管理システム
{
    public partial class LoginForm : Form
    {
        private string userID = string.Empty;
        private string password = string.Empty;
        private string userName = string.Empty;
        private string userSex = string.Empty;
        private string userLevel = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowPass.Checked)
            {
                txtUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserPassword.UseSystemPasswordChar = true;
            }
        }

        private void boxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void boxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userID = txtUserID.Text;
            password = txtUserPassword.Text;

            if (!CheckUser(userID, password))
            {
                return;
            }

            this.Visible = false;

            MainForm mainForm = new MainForm();
            mainForm.userID = userID;
            mainForm.userName = userName;
            mainForm.userSex = userSex;
            mainForm.userLevel = userLevel;
            mainForm.Show();
        }

        private bool CheckUser(string userID, string password)
        {
            string sqlcmd = string.Format(@"SELECT
	                                            *
                                            FROM
	                                            CS_ログインユーザー T1
	                                            INNER JOIN
		                                            CS_職員情報 T2
	                                            ON	T1.職員コード = T2.職員コード
                                            WHERE
	                                            T1.職員コード = '{0}'
                                            AND T1.パスワード = '{1}'
                                            AND	T2.在職 = 'TRUE'", userID, password);

            DataTable dt = Function.GetDataTable(sqlcmd);

            if (dt.Rows.Count != 1 || dt== null)
            {
                MessageBox.Show(Function.mess, "Connected Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            userName = dt.Rows[0]["氏名"].ToString();
            userSex = dt.Rows[0]["性別"].ToString();
            userLevel = dt.Rows[0]["職務"].ToString();
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string testConnect = Function.TestConnect();

            if (!string.IsNullOrWhiteSpace(testConnect))
            {
                return;
            }

            AutoCompleteString();
        }

        private void AutoCompleteString()
        {
            AutoCompleteStringCollection autoText = Function.AutoCompleteString();
            txtUserID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUserID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtUserID.AutoCompleteCustomSource = autoText;
        }
    }
}
