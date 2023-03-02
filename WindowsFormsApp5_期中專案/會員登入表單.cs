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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5_期中專案
{
    public partial class 會員登入表單 : Form
    {
        // 要連接資料庫，要打下列語法
        bool is認證成功 = false;
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 設定新字串，名strDBConnectString 為空值。

        List<int> listPID = new List<int>();   // 定義PID變數欄位。

        public 會員登入表單()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();

        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != ""))
            {

                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string str帳號 = txt帳號.Text;
                string str密碼 = txt密碼.Text;
                string strSQL = "select * from persons where 電話 = @SearchPhone and 密碼 = @SearchPassword ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchPhone", "" + txt帳號.Text + "");    // 拿出SQL 資料庫與txtbox的資料。
                cmd.Parameters.AddWithValue("@SearchPassword", "" + txt密碼.Text + ""); // 不能使用% 符號，因為上面是使用(電話 =, 密碼 =，要完全相同，%符號則是相似即可，故不能使用。
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    txt帳號.Text = reader["電話"].ToString();
                    txt密碼.Text = reader["密碼"].ToString();

                    is認證成功 = true;
                    MessageBox.Show("登入成功");
                    this.Visible = false;         // 隱藏原本頁面
                    修改會員資料 myform = new 修改會員資料(txt帳號.Text);  // 將Form1() 導入新物件myform。
                    myform.ShowDialog();         // 將form1() 叫出來。
                }

                else
                {
                    MessageBox.Show("登入失敗");
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }
        }

        private void btn新增會員_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            新增會員 myform = new 新增會員();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }


        private void btn蛋糕店訂購單_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            蛋糕店訂購單Menu myform = new 蛋糕店訂購單Menu();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void 會員登入表單_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
