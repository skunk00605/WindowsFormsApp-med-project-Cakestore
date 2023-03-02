using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // 新增語法，寫資料庫都要用到這個語法。
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_期中專案
{
    public partial class 訂單資料列表_顧客 : Form
    {
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 定義一個空字串參數strDBConnectString，供後面使用。
        List<int> SearchIDs = new List<int>(); // 設定以id 為進階搜尋結果。


        public 訂單資料列表_顧客()
        {
            InitializeComponent();
        }

        public 訂單資料列表_顧客(string strPhone)
        {
            InitializeComponent();
            txt手機帳號.Text = strPhone;
        }

        private void 訂單資料列表_顧客_Load(object sender, EventArgs e)
        {
            // 設定連線到資料庫。
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件scsb，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();       // 
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)  // 在這段程式中，將txt 與 button 進行連接，再連接資料庫，篩選想抓的資料。
        {
            if (txt手機帳號.Text != "")
            {
                // 建立資料庫連線六步驟。(+ 注入參數值)
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Cakestore_orderlist where 訂購人 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);                             // cmd 由上面建立的strSQL和con 組成。
                cmd.Parameters.AddWithValue("@SearchName", "" + txt手機帳號.Text + "");   // 將label txt手機帳號中，所輸入注入的資料，加入@SearchName 參數值中。
                SqlDataReader reader = cmd.ExecuteReader();                               // 將cmd 利用ExecuteReader讀取出來，放入reader中。

                if (reader.Read() == true)                                             // 如果資料庫讀取器，讀到的資料是對的。
                {                                                                      // 參考老師上課app2中，產生會員資料列表寫法。
                    DataTable dt =new DataTable();                                     // 利用DataTable 語法建立一個dt，將資料丟進去。
                    dt.Load(reader);                                                   // 利用reader讀取器，讀取dt。
                    dgn會員資料列表.DataSource = dt;                                   // 將reader讀取器，讀到的資料轉成字串，給到資料欄位中。
                   

                }
                else
                {
                    MessageBox.Show("查無此人/訂單");
                    清空欄位();
                }
                reader.Close();     // reader關閉。
                con.Close();        // 資料庫關閉。
            }
            else
            {
                MessageBox.Show("請輸入手機/帳號"); // txt手機帳號為空值時顯示。
            }

           
        }

        private void dgn會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void 清空欄位()
        {

            txt手機帳號.Clear();
            dgn會員資料列表.DataSource=null;

        }

        private void btn前往購物_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            蛋糕店訂購單Menu myform = new 蛋糕店訂購單Menu();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        
    }
}
