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
using System.Security.Cryptography;

namespace WindowsFormsApp5_期中專案
{
    public partial class 產品詳細資訊 : Form
    {
        // form 裡面的變數要先宣告初始值。
        public int PID = 0;
        string strMyDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖鑑 = false;

        public 產品詳細資訊()
        {
            InitializeComponent();
        }

        private void 產品詳細資訊_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet.Cakestore_orderlist' 資料表。您可以視需要進行移動或移除。
            this.cakestore_orderlistTableAdapter.Fill(this.mydbDataSet.Cakestore_orderlist);
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); // 連接資料庫
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";               // 資料庫名稱
            scsb.IntegratedSecurity = true;             // 驗證
            strMyDBConnectionString = scsb.ToString();  // 取得資料庫連線字串。
            顯示商品詳細資訊();
        }

        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from Cakestore_products where pid = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@searchID", PID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                // 讀取資料庫欄位資料
                lblPID.Text = reader["pid"].ToString();
                txt商品名稱.Text = reader["pname"].ToString();
                txt商品價格.Text = reader["price"].ToString();
                txt商品描述.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢{i}筆資料.");


        }


        private void btn選取商品圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog(); // 檔案開啟對話框
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png"; // 使用過濾器，設定支援兩種格式三種附檔名。 |: or。 (過濾器描述) | (過濾語法 ",*.副檔名")
            DialogResult R = f.ShowDialog(); // 傳回回傳值，獨佔開啟。

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖鑑 == true)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖鑑 = false;
                }

                // 請insert進資料庫。
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "update Cakestore_products set pname=@NewPname, price=@NewPrice, pdesc=@NewPDesc, pimage=@NewPimage where pid=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", PID);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");

                a();

            }
            else
            {
                MessageBox.Show("所有欄位必填!!");
            }
        }

        void a() 
        {
            lblPID.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            a();
        }

        private void btn選取商品圖片2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog(); // 檔案開啟對話框
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png"; // 使用過濾器，設定支援兩種格式三種附檔名。 |: or。 (過濾器描述) | (過濾語法 ",*.副檔名")
            DialogResult R = f.ShowDialog(); // 傳回回傳值，獨佔開啟。

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExtension = System.IO.Path.GetExtension(f.SafeFileName); // 取得附檔名，不包含目錄
                Random myRandom = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRandom.Next(1000, 10000).ToString() + fileExtension; // 產生系統化圖檔名稱
                is已修改圖鑑 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖鑑 == true)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖鑑 = false;
                }

                // 請insert進products
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "Insert into Cakestore_products values(@NewPname, @NewPrice, @NewPDesc, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");

            }
            else
            {
                MessageBox.Show("所有欄位必填!!");
            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;                       // 用ID為依據，因為使用其他欄位，可能會有資料重複問題產生。
            Int32.TryParse(lblPID.Text, out intID); // 利用TryParse 語法，把標籤欄位(字串)轉成32位元的整數(intID)。

            if (intID > 0) // 檢查欄位ID 是否有數值，有才做下方函數。
            {
                // 連線到sql 四個語法。
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "delete from Cakestore_products where pid = @DeleteID;";
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

        void 清空欄位()
        {
            lblPID.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            
        }

        private void cakestore_orderlistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cakestore_orderlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void 產品詳細資訊_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
