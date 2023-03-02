using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // 新增語法，寫資料庫都要用到這個語法。
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp5_期中專案
{
    public partial class 修改會員資料 : Form
    {
        // 開啟資料庫連接都要寫
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 定義一個字串參數strDBConnectString，供後面使用。

        // 利用id 當PKey，要寫。
        List<int> SearchIDs = new List<int>(); // 進階搜尋結果
        int int搜尋婚姻狀態 = 0;

        public 修改會員資料() // 接收資料的區塊
        {
            InitializeComponent();
            
        }

        public 修改會員資料(string strPhone) // 接收資料的區塊
        {
            InitializeComponent();
            txt電話.Text = strPhone;
        }
        

        void 清空欄位()
        {
            lbl.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt信箱.Clear();
            txt地址.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;                       // 用ID為依據，因為使用其他欄位，可能會有資料重複問題產生。
            Int32.TryParse(lbl.Text, out intID); // 利用TryParse 語法，把標籤欄位(字串)轉成32位元的整數(intID)。

            if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != "")) // 檢查欄位(ID大於0，姓名不能為空值，電話不能為空值)，才做下方函數。
            {
                // 連線到sql 四個語法。
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update persons set 姓名=@Newname, 電話=@NewPhone, 地址=@NewAddress, email=@NewEmail, 生日=@NewBirth, 婚姻狀態=@NewMarriage where id = @SearchID;";
                // 先將SQL 資料庫資料與新物件進行連結。一般化: 把式子做成所有情況都可以用，此段程式能用來修改上述任意欄位(7個欄位)，id用search，因為我們不改動id。

                SqlCommand cmd = new SqlCommand(strSQL, con);
                // 對新物件，注入參數
                cmd.Parameters.AddWithValue("@Newname", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt信箱.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                // select有回傳查詢資料，update沒有回傳查詢資料
                int rows = cmd.ExecuteNonQuery();     // ExecuteNonQuery()，只執行不查詢，會回傳影響的資料筆數。
                con.Close();
                MessageBox.Show($"({rows}個資料受到影響)");


            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;                       // 用ID為依據，因為使用其他欄位，可能會有資料重複問題產生。
            Int32.TryParse(lbl.Text, out intID); // 利用TryParse 語法，把標籤欄位(字串)轉成32位元的整數(intID)。

            if (intID > 0) // 檢查欄位ID 是否有數值，有才做下方函數。
            {
                // 連線到sql 四個語法。
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from persons where id = @DeleteID;";
                // 先將SQL 資料庫資料與新物件進行連結。一般化: 把式子做成所有情況都可以用，此段程式能用來刪除ID欄位。

                SqlCommand cmd = new SqlCommand(strSQL, con);
                // 對新物件，注入參數
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                // select有回傳查詢資料，update沒有回傳查詢資料
                int rows = cmd.ExecuteNonQuery();     // ExecuteNonQuery()，只執行不查詢，會回傳影響的資料筆數。
                con.Close();
                清空欄位();
                MessageBox.Show($"({rows}個資料受到影響)");


            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn前往購物_Click(object sender, EventArgs e)
        {
            this.Visible= false;         // 隱藏原本頁面
            蛋糕店訂購單Menu myform = new 蛋糕店訂購單Menu(txt電話.Text);  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void btn資料搜尋_Click_1(object sender, EventArgs e)
        {
            if (txt電話.Text != "")
            {
                // 建立資料庫連線六步驟。(+ 注入參數值)
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from persons where 電話 like @SearchPhone;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchPhone", "" + txt電話.Text + "");   // 注入@SearchName 參數值。
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)                                             // 利用資料庫讀取器讀資料。
                {
                    lbl.Text = reader["id"].ToString();                                // 將讀取器，讀到的資料轉成字串，給到資料欄位中。
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txt信箱.Text = reader["email"].ToString();
                    txt密碼.Text = reader["密碼"].ToString();
                    
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();          // 使用下方清空欄位方法，當查無此人時，按下按鈕就會清空欄位。
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入電話號碼");
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();
        }

        private void 修改會員資料_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btn會員訂單狀況_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            訂單資料列表_顧客 myform = new 訂單資料列表_顧客(txt電話.Text);  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void chk顯示密碼_CheckedChanged(object sender, EventArgs e)
        {
            if (chk顯示密碼.Checked == true)
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
