using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // 新增語法，連接資料庫都要用到這個語法。

namespace WindowsFormsApp5_期中專案
{
    public partial class 會員資料維護_店長 : Form
    {
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 定義一個字串參數strDBConnectString，供後面使用。
        List<int> SearchIDs = new List<int>(); // 進階搜尋結果
        

        public 會員資料維護_店長()
        {
            InitializeComponent();
        }

        private void 會員資料維護_店長_Load(object sender, EventArgs e)
        {
            // 設定資料庫連線。
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();       // 

            產生會員資料表(); // 
        }

        void 產生會員資料表()
        {
            // 連線到sql 四個語法。
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select id as 會員編號, 姓名, 電話, email as 電子郵件 from persons"; // 從persons資料庫中，選取欄位
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)                        // ??
            {
                DataTable dt = new DataTable();        // ??
                dt.Load(reader);
                dgn會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            // 利用程式話語法，建立資料庫連線五步驟。
            SqlConnection con = new SqlConnection(strDBConnectString);  // 建立資料庫連線物件，命名為con，內參數為strDBConnectString 資料庫連線字串。
            con.Open();                                                 // 開啟資料庫連線。
            string strSQL = "select * from persons";                    // 建立strSQL 查詢字串。
            SqlCommand cmd = new SqlCommand(strSQL, con);               // 建立Sql 命令物件，內有兩個參數(SQL語法，SQL連線物件)。
            SqlDataReader reader = cmd.ExecuteReader();                 // 建立SqlDataReader 資料庫讀取器。
                                                                         
            string strMsg = "";
            int count = 0;

            // 測試利用程序化語法，在資料筆數按鈕上，拉取資料庫資料有沒有成功。
            // 利用while 迴圈將結果讀出來。
            while (reader.Read() == true)                                // 用SqlDataReader 將資料讀出。
            {
                string id = reader["id"].ToString();                     // 從資料庫中把id 欄位讀出來，並轉成字串，賦予給新字串id 中。
                string 姓名 = reader["姓名"].ToString();
                string 電話 = reader["電話"].ToString();
                string email = reader["email"].ToString();

                strMsg += $"{id} {姓名} {電話} {email} \n";              // 將資料拉出資料庫，再用$ 字符號串起來換行，放到strMsg 裡面。
                count += 1;                                              // 計算數目並加1。
            }

            strMsg += "資料筆數:" + count;                               // 計算筆數。
            reader.Close();                                              // SqlDataReader 資料庫讀取器關閉。
            con.Close();                                                 // 資料庫連線物件關閉。
            MessageBox.Show(strMsg);
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                // 建立資料庫連線六步驟。(+ 注入參數值)
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from persons where 姓名 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");   // 注入@SearchName 參數值。
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)                                             // 利用資料庫讀取器讀資料。
                {
                    lbl.Text = reader["id"].ToString();                                // 將讀取器，讀到的資料轉成字串，給到資料欄位中。
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txt信箱.Text = reader["email"].ToString();
                   
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();                                                        // 使用下方清空欄位方法，當查無此人時，按下按鈕就會清空欄位。
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋關鍵字");
            }
        }

        void 清空欄位()
        {
            lbl.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt信箱.Clear();
            txt地址.Clear();
            txt會員點數.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }

        // 當查無此人時，可以建立一個清空欄位的方法，當查無此人時，按下按鈕就會清空欄位。


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

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "")) // 檢查欄位，姓名不能為空值，電話不能為空值)，才做下方函數。
            {
                // 連線到sql 四個語法。
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();   // 開啟資料庫連線。
                string strSQL = "insert into persons values (@Newname, @NewPhone, @NewAddress, @NewEmail, @NewBirth, @NewMarriage, @NewPoints);";
                // 先將SQL 資料庫資料與新物件進行連結。一般化: 把式子做成所有情況都可以用，此段程式能用來修改上述任意欄位(7個欄位)，新會員沒有id，先去除。

                SqlCommand cmd = new SqlCommand(strSQL, con);
                // 對新物件，注入參數
                cmd.Parameters.AddWithValue("@Newname", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt信箱.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int intPoints = 0;                                    // 先宣告intPoints 為0。
                Int32.TryParse(txt會員點數.Text, out intPoints);      // 將輸入的會員點數文字，轉成整數。
                cmd.Parameters.AddWithValue("@NewPoints", intPoints); // 將整數導入給新物件，連動至資料庫中。


                // select有回傳查詢資料，update沒有回傳查詢資料
                int rows = cmd.ExecuteNonQuery();     // ExecuteNonQuery()，只執行不查詢，會回傳影響的資料筆數。
                con.Close();
                MessageBox.Show($"({rows}個資料受到影響)"); // 建立提示。


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

        private void dgn會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e) // 點擊會員資料表，連接資料欄位。
        {
            if (e.RowIndex >= 0)   // e.RowIndex 取得物件e裡面的值，如果大於或等於0，做下面函式。
            {
                string strSelectedID = dgn會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString(); // 取得會員資料欄位的列(row)數值，再取得儲存格Cell[0]第一個值(id)，轉字串。
                // 點選DataGridView欄位取得欄位值語法，(string value = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();)
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID); // 再用TryParse把字串轉int整數。

                if (isID == true) // 如果轉換成功
                {
                    // 連接資料庫
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from persons where id = @SearchID;"; // 連接到SQL資料庫，撈取資料。
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    // 注入@SearchName 參數值。
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)                                 // 利用資料庫讀取器讀資料。
                    {
                        lbl.Text = reader["id"].ToString();                    // 將讀取器，讀到的資料轉成字串，給到資料欄位中。
                        txt姓名.Text = reader["姓名"].ToString();
                        txt電話.Text = reader["電話"].ToString();
                        txt地址.Text = reader["地址"].ToString();
                        txt信箱.Text = reader["email"].ToString();
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
            }
        }

        private void btn進入商品管理頁面_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            商品管理_店長 myform = new 商品管理_店長();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void 會員資料維護_店長_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面，不隱藏視窗會一直疊加。
            訂單管理_店長 myform = new 訂單管理_店長();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }
    }
}

//if (e.RowIndex >= 0)   // e.RowIndex 取得物件e裡面的值，如果大於或等於0，做下面函式。
//{
//    string strSelectedID = dgn會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString(); // 取得會員資料欄位的列(row)數值，再取得儲存格Cell[0]第一個值(id)，轉字串。
//                                                                                 // 點選DataGridView欄位取得欄位值語法，(string value = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();)
//    int intSelectedID = 0;
//    bool isID = Int32.TryParse(strSelectedID, out intSelectedID); // 再用TryParse把字串轉int整數。

//    if (isID == true) // 如果轉換成功
//    {
//        // 連接資料庫
//        SqlConnection con = new SqlConnection(strDBConnectString);
//        con.Open();
//        string strSQL = "select * from persons where id = @SearchID;"; // 連接到SQL資料庫，撈取資料。
//        SqlCommand cmd = new SqlCommand(strSQL, con);

//        // 注入@SearchName 參數值。
//        cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
//        SqlDataReader reader = cmd.ExecuteReader();

//        if (reader.Read() == true)                                 // 利用資料庫讀取器讀資料。
//        {
//            lbl.Text = reader["id"].ToString();                    // 將讀取器，讀到的資料轉成字串，給到資料欄位中。
//            txt姓名.Text = reader["姓名"].ToString();
//            txt電話.Text = reader["電話"].ToString();
//            txt地址.Text = reader["地址"].ToString();
//            txt信箱.Text = reader["email"].ToString();
//            dtp生日.Value = Convert.ToDateTime(reader["生日"]);
//            chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
//        }
//        else
//        {
//            MessageBox.Show("查無此人");
//            清空欄位();          // 使用下方清空欄位方法，當查無此人時，按下按鈕就會清空欄位。
//        }
//        reader.Close();
//        con.Close();
//    }
