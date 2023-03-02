using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // 連接資料庫要加入。

namespace WindowsFormsApp5_期中專案
{
    public partial class 商品管理_店長 : Form
    {
        string strMyDBConnectionString = "";         // 資料庫連線字串
        List<string> listPname = new List<string>(); // 產品名稱List，要跟資料庫互動，要用List。
        List<int> listPrice = new List<int>();       // 產品價格List
        List<int> listPID = new List<int>();         // 產品PID List

        public 商品管理_店長()
        {
            InitializeComponent();
        }

        private void 商品資料維護_店長_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); // 連接資料庫
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";    // 資料庫名稱
            scsb.IntegratedSecurity = true;  // 驗證
            strMyDBConnectionString = scsb.ToString();  // 取得資料庫連線字串。

            讀取資料庫();
            展示listView商品圖片模式();
        }

        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString); // 
            con.Open();
            string strSQL = "select * from Cakestore_products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";  // 指定圖檔目錄，要把圖片貼到此專案資料夾 >> bin >> Debug >> imeges 資料夾內。
            string image_name = "";         // 圖檔名稱
            int i = 0;

            while (reader.Read())
            {
                // 從資料庫中取得欄位內資料。
                listPID.Add((int)reader["pid"]);
                listPname.Add(reader["pname"].ToString());
                listPrice.Add((int)reader["price"]);
                image_name = reader["pimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name); // 要使用圖檔完整路徑，為(圖檔目錄+圖檔名稱)。
                imageList產品圖檔.Images.Add(myProductImage);
                i += 1;
            }
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            展示listView商品圖片模式();
        }

        void 展示listView商品圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon; // 決定商品展示單元，要用什麼型態展示(大圖模式)。(LargeIcon, SmallIcon, List, Tile)
            imageList產品圖檔.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageList產品圖檔; // LargeIcon, Tile
            listView商品展示.SmallImageList = imageList產品圖檔; // 小圖模式 SmallIcon, List

            for (int i = 0; i < imageList產品圖檔.Images.Count; i += 1) // 看有幾個商品圖檔，就要做幾個單元。
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular); // 設定字體
                item.Text = listPname[i] + "" + listPrice[i] + "元";
                item.Tag = listPID[i];                                     // 利用Tag 藏資訊使用。
                listView商品展示.Items.Add(item);
            }

        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {
            展示listView商品列表模式();
        }
        void 展示listView商品列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("PID", 100);       // 在列表模式中，增加"PID" 列。
            listView商品展示.Columns.Add("商品名稱", 120);  // 在列表模式中，增加"商品名稱" 列。
            listView商品展示.Columns.Add("商品價格", 80);   // 在列表模式中，增加"商品價格" 列。
            listView商品展示.FullRowSelect = true;
            listView商品展示.GridLines = true;

            for (int i = 0; i < listPID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                listView商品展示.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPID[i].ToString();
                item.Tag = listPID[i];                      // 將資料加入第1個欄位(PID)
                item.SubItems.Add(listPname[i]);            // 將資料加入第2個欄位(商品名稱)
                item.SubItems.Add(listPrice[i].ToString()); // 將資料加入第3個欄位(商品價格)
                item.Tag = listPID[i];

                listView商品展示.Items.Add(item);
            }

        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            產品詳細資訊 myFormDetail = new 產品詳細資訊(); // 連接產品詳細資訊頁面。
            // myFormDetail.Show(); 用show會一直按一直跳出頁面。
            myFormDetail.ShowDialog(); // 用ShowDialog()，會獨佔開啟，沒關掉不能再開。
        }

        private void btn重新載入_Click(object sender, EventArgs e)
        {
            // 清除欄位。
            listPID.Clear();
            listPname.Clear();
            listPrice.Clear();
            imageList產品圖檔.Images.Clear();
            讀取資料庫();

            if (listView商品展示.View == View.Details)
            {
                展示listView商品圖片模式();
            }
            else
            {
                展示listView商品圖片模式();
            }
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e) // listView 要導入工具箱裡面的ImegeList 功能。
        {
            產品詳細資訊 myFormDetail = new 產品詳細資訊();
            myFormDetail.PID = (int)listView商品展示.SelectedItems[0].Tag;
            myFormDetail.ShowDialog();
        }

        private void 商品管理_店長_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
