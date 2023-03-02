using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5_期中專案
{
    public partial class 新增員工 : Form
    {
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 定義一個字串參數strDBConnectString，供後面使用。

        void 清空欄位()
        {
            lbl.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt密碼.Clear();
           
        }
        public 新增員工()
        {
            InitializeComponent();
        }

        private void 新增員工_Load(object sender, EventArgs e)
        {
            // 設定資料庫連線。
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();       // 
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "")) // 檢查欄位，姓名不能為空值，電話不能為空值)，才做下方函數。
            {
                // 連線到sql 四個語法。
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();   // 開啟資料庫連線。
                string strSQL = "insert into Employee values (@Newname, @NewPhone, @NewPassword);";
                // 先將SQL 資料庫資料與新物件進行連結。一般化: 把式子做成所有情況都可以用，此段程式能用來修改上述任意欄位(7個欄位)，新會員沒有id，先去除。

                SqlCommand cmd = new SqlCommand(strSQL, con);
                // 對新物件，注入參數
                cmd.Parameters.AddWithValue("@Newname", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);


                // select有回傳查詢資料，update沒有回傳查詢資料
                int rows = cmd.ExecuteNonQuery();     // ExecuteNonQuery()，只執行不查詢，會回傳影響的資料筆數。
                con.Close();
                MessageBox.Show($"({rows}個資料受到影響)"); // 建立提示。


            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void 新增員工_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            人流區分 myform = new 人流區分();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt密碼.PasswordChar = default(char); // default預設初始狀況，char 顯示內容。            
            }

            else
            {
                txt密碼.PasswordChar = '*'; // 不點checkBox，則顯示 * 符號。
            }
        }
    }
}
