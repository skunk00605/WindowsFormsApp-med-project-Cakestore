using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_期中專案
{
    public partial class 訂單管理_店長 : Form
    {
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 定義一個空字串參數strDBConnectString，供後面使用。
        List<int> SearchIDs = new List<int>(); // 設定以id 為進階搜尋結果。

        public 訂單管理_店長()
        {
            InitializeComponent();
        }

        private void 訂單管理_店長_Load(object sender, EventArgs e)
        {
            // 設定連線到資料庫。
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件scsb，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();       // 
            產生會員資料列表();  // 要導入資料庫資料使用。
        }

        void 產生會員資料列表()  // 資料庫的導入規定
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from Cakestore_orderlist";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) 
            {
                DataTable dt = new DataTable();  // 弄一個暫存的dt，給DataTable()丟資料。
                dt.Load(reader);                 // 用reader，把資料Load進去。
                dgn會員資料列表.DataSource = dt; // 再把資料放入 dgn會員資料列表中。
            }
            reader.Close();
            con.Close();
        }


        private void btn資料搜尋_Click(object sender, EventArgs e)
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
                    DataTable dt = new DataTable();                                     // 利用DataTable 語法建立一個dt，將資料丟進去。
                    dt.Load(reader);                                                   // 利用reader讀取器，讀取dt。
                    dgn會員資料列表.DataSource = dt;                                   // 將reader讀取器，讀到的資料轉成字串，給到資料欄位中。


                }
                else
                {
                    MessageBox.Show("查無此人/訂單");
                    
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
    }
}
