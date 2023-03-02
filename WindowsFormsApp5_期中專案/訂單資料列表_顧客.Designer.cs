namespace WindowsFormsApp5_期中專案
{
    partial class 訂單資料列表_顧客
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(訂單資料列表_顧客));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn前往購物 = new System.Windows.Forms.Button();
            this.txt手機帳號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.dgn會員資料列表 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgn會員資料列表)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btn前往購物);
            this.groupBox1.Controls.Add(this.txt手機帳號);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Location = new System.Drawing.Point(15, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(373, 346);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // btn前往購物
            // 
            this.btn前往購物.Location = new System.Drawing.Point(170, 201);
            this.btn前往購物.Margin = new System.Windows.Forms.Padding(6);
            this.btn前往購物.Name = "btn前往購物";
            this.btn前往購物.Size = new System.Drawing.Size(162, 46);
            this.btn前往購物.TabIndex = 30;
            this.btn前往購物.Text = "前往購物";
            this.btn前往購物.UseVisualStyleBackColor = true;
            this.btn前往購物.Click += new System.EventHandler(this.btn前往購物_Click);
            // 
            // txt手機帳號
            // 
            this.txt手機帳號.Location = new System.Drawing.Point(146, 77);
            this.txt手機帳號.Margin = new System.Windows.Forms.Padding(6);
            this.txt手機帳號.Name = "txt手機帳號";
            this.txt手機帳號.Size = new System.Drawing.Size(212, 36);
            this.txt手機帳號.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "手機/帳號";
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Location = new System.Drawing.Point(170, 130);
            this.btn資料搜尋.Margin = new System.Windows.Forms.Padding(6);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(162, 46);
            this.btn資料搜尋.TabIndex = 1;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // dgn會員資料列表
            // 
            this.dgn會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgn會員資料列表.Location = new System.Drawing.Point(12, 35);
            this.dgn會員資料列表.Margin = new System.Windows.Forms.Padding(6);
            this.dgn會員資料列表.Name = "dgn會員資料列表";
            this.dgn會員資料列表.RowHeadersWidth = 82;
            this.dgn會員資料列表.RowTemplate.Height = 24;
            this.dgn會員資料列表.Size = new System.Drawing.Size(1139, 649);
            this.dgn會員資料列表.TabIndex = 0;
            this.dgn會員資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgn會員資料列表_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox4.Controls.Add(this.dgn會員資料列表);
            this.groupBox4.Location = new System.Drawing.Point(400, 26);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(1157, 690);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "訂單資料列表";
            // 
            // 訂單資料列表_顧客
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1602, 819);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "訂單資料列表_顧客";
            this.Text = "訂單資料列表_顧客";
            this.Load += new System.EventHandler(this.訂單資料列表_顧客_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgn會員資料列表)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.TextBox txt手機帳號;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgn會員資料列表;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn前往購物;
    }
}