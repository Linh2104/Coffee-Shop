using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componet_For_Coffee_Shop
{
    public static class Function
    {
        public static string connectionString = "Data Source=DESKTOP-R5038PT\\SQLEXPRESS01;Initial Catalog=CoffeeShopDB;Integrated Security=True";
        public static string mess = string.Empty;

        public static string TestConnect()
        {
            mess = string.Empty;
            SqlConnection sqlcon = new SqlConnection(connectionString);

            try
            {
                sqlcon?.Open();
                return "";
            }
            catch (Exception ex)
            {
                sqlcon?.Close();
                mess = ex.Message;
                return mess;
            }
            finally
            {
                sqlcon?.Close();
            }
        }

        public static DataTable GetDataTable(string sqlcmd)
        {
            mess = string.Empty;
            SqlConnection sqlcon = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                sqlcon?.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd, sqlcon);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    mess = "UserIDまたはPasswordが間違っています。もう一度確認してください。";
                }
                else if (dt.Rows.Count == 0)
                {
                    mess = "UserIDが重複しています。管理者に連絡してください。";
                }
                return dt;
            }
            catch (Exception ex)
            {
                sqlcon?.Close();
                mess = ex.Message;
                return null;
            }
            finally
            {
                sqlcon?.Close();
            }
        }

        public static AutoCompleteStringCollection AutoCompleteString()
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            string sqlcmd = "SELECT 職員コード FROM CS_ログインユーザー";
            try
            {
                sqlcon?.Open();
                SqlDataReader sdr = new SqlCommand(sqlcmd, sqlcon).ExecuteReader();
                AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();
                while (sdr.Read())
                {
                    autoText.Add(((int)sdr.GetValue(0)).ToString());
                }
                
                return autoText;
            }
            catch (Exception ex)
            {
                sqlcon?.Close();
                mess = ex.Message;
                return null;
            }
            finally
            {
                sqlcon?.Close();
            }
        }
    }
}
