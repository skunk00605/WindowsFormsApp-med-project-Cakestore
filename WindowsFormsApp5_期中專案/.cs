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
    public partial class 蛋糕店訂購單Menu : Form
    {
        SqlConnectionStringBuilder scsb;       // 資料庫連線字串建立器，建立新物件scsb。
        string strDBConnectString = "";        // 設定新字串，名strDBConnectString 為空值。

        // 定義所有變數欄位
        List<int> listPID = new List<int>();                 // 產品PID List
        List<string> list蛋糕品項名稱 = new List<string>();  // UI 要跟List<> 互動。
        List<int> list蛋糕價格 = new List<int>();
        List<string> list所選口味 = new List<string>();
        List<string> list所選口味1 = new List<string>();

        int 所選個數 = 0;
        int 所選蛋糕單價 = 0;
        int 所選蛋糕品項總價 = 0;
        string 所選蛋糕品項 = "";
        
        bool is外帶 = false;
        bool is買購物袋 = false;
        string 訂購人 = "";


        public 蛋糕店訂購單Menu()
        {
            InitializeComponent();
            

        }

        public 蛋糕店訂購單Menu(string strPhone) // 接收資料的區塊。
        {
            InitializeComponent();
            txt訂購人.Text = strPhone;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定資料庫連線。
            scsb = new SqlConnectionStringBuilder();    // 產生一個新物件，並將"資料庫連線字串建立器" 賦予給它。
            scsb.DataSource = @".";                     // DataSource 是伺服器名稱。@: 忽略特殊符號，".": .是本機。
            scsb.InitialCatalog = "mydb";               // InitialCatalog 是資料庫名稱。
            scsb.IntegratedSecurity = true;             // IntegratedSecurity 是windows 驗證。
            strDBConnectString = scsb.ToString();

            list蛋糕品項名稱.Add("切片系列");
            list蛋糕品項名稱.Add("長條系列");
            list蛋糕品項名稱.Add("整模系列");

            list蛋糕價格.Add(45);
            list蛋糕價格.Add(150);
            list蛋糕價格.Add(450);

            for (int i = 0; i < list蛋糕品項名稱.Count; i += 1)
            {
                listBox蛋糕品項.Items.Add(list蛋糕品項名稱[i]);
            }
            // 設定變數 "預設值"。
            txt個數.Text = "1";
            所選個數 = 1;
            radio內用.Checked = true;
            is外帶 = false;
            chk買購物袋.Checked = false;
            is買購物袋 = false;

            讀取資料庫();
            展示listView商品圖片模式();
        }

        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectString); // 
            con.Open();
            string strSQL = "select * from Cakestore_products;"; // 連線到想
            SqlCommand cmd = new SqlCommand(strSQL, con); 
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";  // 指定圖檔目錄，要把圖片貼到此專案資料夾 >> bin >> Debug >> imeges 資料夾內。
            string image_name = "";         // 圖檔名稱
            int i = 0;

            while (reader.Read())
            {
                // 從資料庫中取得欄位內資料。
                listPID.Add((int)reader["pid"]);
                list蛋糕品項名稱.Add(reader["pname"].ToString());
                list蛋糕價格.Add((int)reader["price"]);
                image_name = reader["pimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name); // 要使用圖檔完整路徑，為(圖檔目錄+圖檔名稱)。
                imageList產品圖檔.Images.Add(myProductImage); // 要從旁邊將imagelist拉出來，到設計頁面下方。
                i += 1;
            } 
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
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
                item.Text = list蛋糕品項名稱[i] + "" + list蛋糕價格[i] + "元";
                item.Tag = listPID[i];                                     // 利用Tag 藏資訊使用。
                listView商品展示.Items.Add(item);
            }

        }


        void 計算品項總價()
        {
            if (所選個數 > 0)
            {
              所選蛋糕品項總價 = 所選蛋糕單價 * 所選個數;
                    
                if (list所選口味.Count > 0 || list所選口味1.Count > 0)
                {
                    所選蛋糕品項總價 = 所選蛋糕品項總價 + list所選口味.Count * 10 + list所選口味1.Count * 20;
                }

                if (is買購物袋 == true)
                {
                    所選蛋糕品項總價 += 2;
                }

                    lbl品項總價.Text = $"{所選蛋糕品項總價}";
                }
            }
        
        private void listBox蛋糕品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox蛋糕品項.SelectedIndex >= 0)
            {
                所選蛋糕品項 = list蛋糕品項名稱[listBox蛋糕品項.SelectedIndex];
                所選蛋糕單價 = list蛋糕價格[listBox蛋糕品項.SelectedIndex];

                lbl單價.Text = $"{所選蛋糕單價}";
                計算品項總價();
            }
        }

        private void txt個數_TextChanged(object sender, EventArgs e)
        {
            if (txt個數.Text.Length > 0)
            {
                bool is數字 = Int32.TryParse(txt個數.Text, out 所選個數);
                if (is數字)
                {
                    計算品項總價();
                }
                else
                {
                    MessageBox.Show("個數輸入錯誤");
                }
            }
        }

        private void chk起司_CheckedChanged(object sender, EventArgs e)
        {
            if (chk起司.Checked == true)
            {
                list所選口味.Add("起司");
            }
            else
            {
                list所選口味.Remove("起司");
            }

            計算品項總價();
        }

        private void chk巧克力_CheckedChanged(object sender, EventArgs e)
        {
            if (chk巧克力.Checked == true)
            {
                list所選口味1.Add("巧克力");
            }
            else
            {
                list所選口味1.Remove("巧克力");
            }

            計算品項總價();
        }

        private void chk草莓_CheckedChanged(object sender, EventArgs e)
        {
            if (chk草莓.Checked == true)
            {
                list所選口味1.Add("草莓");
            }
            else
            {
                list所選口味1.Remove("草莓");
            }

            計算品項總價();
        }

        private void chk水果_CheckedChanged(object sender, EventArgs e)
        {
            if (chk水果.Checked == true)
            {
                list所選口味1.Add("水果");
            }
            else
            {
                list所選口味1.Remove("水果");
            }

            計算品項總價();
        }

        private void chk藍莓_CheckedChanged(object sender, EventArgs e)
        {
            if (chk藍莓.Checked == true)
            {
                list所選口味1.Add("藍莓");
            }
            else
            {
                list所選口味1.Remove("藍莓");
            }

            計算品項總價();
        }

        private void chk買購物袋_CheckedChanged(object sender, EventArgs e)
        {
            is買購物袋 = chk買購物袋.Checked;

            計算品項總價();
        }

        private void radio內用_CheckedChanged(object sender, EventArgs e)
        {
            is外帶 = false;
        }

        private void radio外帶_CheckedChanged(object sender, EventArgs e)
        {
            is外帶 = true;
        }

        private void btn訂購_Click(object sender, EventArgs e)
        {
            if ((txt訂購人.Text != "") && (所選個數 > 0)) // 一定要有訂購人，杯數不能為零。
            {
                訂購人 = txt訂購人.Text;

                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into Cakestore_orderlist values" + "(@NewProductName, @NewPrice, @NewTotalPrice, @NewNumbers, @NewCustomerName, @NewToGo, @NewBuyBag, @NewTaste, @NewTaste1)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewProductName", 所選蛋糕品項);
                cmd.Parameters.AddWithValue("@NewPrice", 所選蛋糕單價);
                cmd.Parameters.AddWithValue("@NewTotalPrice", 所選蛋糕品項總價);
                cmd.Parameters.AddWithValue("@NewNumbers", 所選個數);
                cmd.Parameters.AddWithValue("@NewCustomerName", 訂購人);
                cmd.Parameters.AddWithValue("@NewToGo", is外帶);
                cmd.Parameters.AddWithValue("@NewBuyBag", is買購物袋);
                string str口味集合 = "";
                foreach (string item in list所選口味)
                {
                    str口味集合 = str口味集合 + "," + item;
                }
                cmd.Parameters.AddWithValue("@NewTaste", str口味集合);

                string str口味集合1 = "";
                foreach (string item in list所選口味)
                {
                    str口味集合1 = str口味集合1 + "," + item;
                }
                cmd.Parameters.AddWithValue("@NewTaste1", str口味集合);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"訂購成功, 共{rows}筆");
            }
            else
            {
                MessageBox.Show("訂購人必填，至少購買一個");
            }
        }

        private void 蛋糕店訂購單Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
