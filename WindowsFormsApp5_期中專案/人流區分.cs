using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_期中專案
{
    public partial class 人流區分 : Form
    {
        public 人流區分()
        {
            InitializeComponent();
        }

        private void 人流區分_Load(object sender, EventArgs e)
        {

        }

        private void btn顧客_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            會員登入表單 myform = new 會員登入表單();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void btn員工_Click(object sender, EventArgs e)
        {
            this.Visible = false;         // 隱藏原本頁面
            員工登入卡控 myform = new 員工登入卡控();  // 將Form1() 導入新物件myform。
            myform.ShowDialog();         // 將form1() 叫出來。
        }

        private void 人流區分_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
