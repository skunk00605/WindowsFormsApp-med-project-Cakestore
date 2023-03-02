namespace WindowsFormsApp5_期中專案
{
    partial class 蛋糕店訂購單Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(蛋糕店訂購單Menu));
            this.btn訂購 = new System.Windows.Forms.Button();
            this.chk買購物袋 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio外帶 = new System.Windows.Forms.RadioButton();
            this.radio內用 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk草莓 = new System.Windows.Forms.CheckBox();
            this.chk藍莓 = new System.Windows.Forms.CheckBox();
            this.chk巧克力 = new System.Windows.Forms.CheckBox();
            this.chk水果 = new System.Windows.Forms.CheckBox();
            this.chk起司 = new System.Windows.Forms.CheckBox();
            this.listBox蛋糕品項 = new System.Windows.Forms.ListBox();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt個數 = new System.Windows.Forms.TextBox();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn訂購
            // 
            this.btn訂購.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn訂購.Location = new System.Drawing.Point(1311, 932);
            this.btn訂購.Margin = new System.Windows.Forms.Padding(6);
            this.btn訂購.Name = "btn訂購";
            this.btn訂購.Size = new System.Drawing.Size(228, 78);
            this.btn訂購.TabIndex = 40;
            this.btn訂購.Text = "訂購";
            this.btn訂購.UseVisualStyleBackColor = true;
            this.btn訂購.Click += new System.EventHandler(this.btn訂購_Click);
            // 
            // chk買購物袋
            // 
            this.chk買購物袋.AutoSize = true;
            this.chk買購物袋.Location = new System.Drawing.Point(1261, 316);
            this.chk買購物袋.Margin = new System.Windows.Forms.Padding(6);
            this.chk買購物袋.Name = "chk買購物袋";
            this.chk買購物袋.Size = new System.Drawing.Size(138, 28);
            this.chk買購物袋.TabIndex = 25;
            this.chk買購物袋.Text = "買購物袋";
            this.chk買購物袋.UseVisualStyleBackColor = true;
            this.chk買購物袋.CheckedChanged += new System.EventHandler(this.chk買購物袋_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.radio外帶);
            this.groupBox2.Controls.Add(this.radio內用);
            this.groupBox2.Location = new System.Drawing.Point(1261, 385);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(292, 100);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // radio外帶
            // 
            this.radio外帶.AutoSize = true;
            this.radio外帶.Location = new System.Drawing.Point(167, 38);
            this.radio外帶.Margin = new System.Windows.Forms.Padding(6);
            this.radio外帶.Name = "radio外帶";
            this.radio外帶.Size = new System.Drawing.Size(89, 28);
            this.radio外帶.TabIndex = 1;
            this.radio外帶.TabStop = true;
            this.radio外帶.Text = "外帶";
            this.radio外帶.UseVisualStyleBackColor = true;
            this.radio外帶.CheckedChanged += new System.EventHandler(this.radio外帶_CheckedChanged);
            // 
            // radio內用
            // 
            this.radio內用.AutoSize = true;
            this.radio內用.Location = new System.Drawing.Point(32, 38);
            this.radio內用.Margin = new System.Windows.Forms.Padding(6);
            this.radio內用.Name = "radio內用";
            this.radio內用.Size = new System.Drawing.Size(89, 28);
            this.radio內用.TabIndex = 0;
            this.radio內用.TabStop = true;
            this.radio內用.Text = "內用";
            this.radio內用.UseVisualStyleBackColor = true;
            this.radio內用.CheckedChanged += new System.EventHandler(this.radio內用_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.chk草莓);
            this.groupBox1.Controls.Add(this.chk藍莓);
            this.groupBox1.Controls.Add(this.chk巧克力);
            this.groupBox1.Controls.Add(this.chk水果);
            this.groupBox1.Controls.Add(this.chk起司);
            this.groupBox1.Location = new System.Drawing.Point(1258, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(388, 169);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // chk草莓
            // 
            this.chk草莓.AutoSize = true;
            this.chk草莓.Location = new System.Drawing.Point(61, 132);
            this.chk草莓.Margin = new System.Windows.Forms.Padding(6);
            this.chk草莓.Name = "chk草莓";
            this.chk草莓.Size = new System.Drawing.Size(147, 28);
            this.chk草莓.TabIndex = 4;
            this.chk草莓.Text = "草莓_20元";
            this.chk草莓.UseVisualStyleBackColor = true;
            this.chk草莓.CheckedChanged += new System.EventHandler(this.chk草莓_CheckedChanged);
            // 
            // chk藍莓
            // 
            this.chk藍莓.AutoSize = true;
            this.chk藍莓.Location = new System.Drawing.Point(241, 88);
            this.chk藍莓.Margin = new System.Windows.Forms.Padding(6);
            this.chk藍莓.Name = "chk藍莓";
            this.chk藍莓.Size = new System.Drawing.Size(147, 28);
            this.chk藍莓.TabIndex = 3;
            this.chk藍莓.Text = "藍莓_20元";
            this.chk藍莓.UseVisualStyleBackColor = true;
            this.chk藍莓.CheckedChanged += new System.EventHandler(this.chk藍莓_CheckedChanged);
            // 
            // chk巧克力
            // 
            this.chk巧克力.AutoSize = true;
            this.chk巧克力.Location = new System.Drawing.Point(61, 88);
            this.chk巧克力.Margin = new System.Windows.Forms.Padding(6);
            this.chk巧克力.Name = "chk巧克力";
            this.chk巧克力.Size = new System.Drawing.Size(171, 28);
            this.chk巧克力.TabIndex = 2;
            this.chk巧克力.Text = "巧克力_20元";
            this.chk巧克力.UseVisualStyleBackColor = true;
            this.chk巧克力.CheckedChanged += new System.EventHandler(this.chk巧克力_CheckedChanged);
            // 
            // chk水果
            // 
            this.chk水果.AutoSize = true;
            this.chk水果.Location = new System.Drawing.Point(241, 44);
            this.chk水果.Margin = new System.Windows.Forms.Padding(6);
            this.chk水果.Name = "chk水果";
            this.chk水果.Size = new System.Drawing.Size(147, 28);
            this.chk水果.TabIndex = 1;
            this.chk水果.Text = "水果_20元";
            this.chk水果.UseVisualStyleBackColor = true;
            this.chk水果.CheckedChanged += new System.EventHandler(this.chk水果_CheckedChanged);
            // 
            // chk起司
            // 
            this.chk起司.AutoSize = true;
            this.chk起司.Location = new System.Drawing.Point(61, 44);
            this.chk起司.Margin = new System.Windows.Forms.Padding(6);
            this.chk起司.Name = "chk起司";
            this.chk起司.Size = new System.Drawing.Size(147, 28);
            this.chk起司.TabIndex = 0;
            this.chk起司.Text = "起司_10元";
            this.chk起司.UseVisualStyleBackColor = true;
            this.chk起司.CheckedChanged += new System.EventHandler(this.chk起司_CheckedChanged);
            // 
            // listBox蛋糕品項
            // 
            this.listBox蛋糕品項.FormattingEnabled = true;
            this.listBox蛋糕品項.ItemHeight = 24;
            this.listBox蛋糕品項.Location = new System.Drawing.Point(24, 344);
            this.listBox蛋糕品項.Margin = new System.Windows.Forms.Padding(6);
            this.listBox蛋糕品項.Name = "listBox蛋糕品項";
            this.listBox蛋糕品項.Size = new System.Drawing.Size(328, 604);
            this.listBox蛋糕品項.TabIndex = 35;
            this.listBox蛋糕品項.SelectedIndexChanged += new System.EventHandler(this.listBox蛋糕品項_SelectedIndexChanged);
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl品項總價.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(1342, 853);
            this.lbl品項總價.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(136, 32);
            this.lbl品項總價.TabIndex = 34;
            this.lbl品項總價.Text = "000000元";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl單價.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(1367, 725);
            this.lbl單價.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(106, 32);
            this.lbl單價.TabIndex = 33;
            this.lbl單價.Text = "0000元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(1523, 611);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 32);
            this.label10.TabIndex = 32;
            this.label10.Text = "個";
            // 
            // txt個數
            // 
            this.txt個數.Location = new System.Drawing.Point(1294, 605);
            this.txt個數.Margin = new System.Windows.Forms.Padding(6);
            this.txt個數.Name = "txt個數";
            this.txt個數.Size = new System.Drawing.Size(212, 36);
            this.txt個數.TabIndex = 31;
            this.txt個數.TextChanged += new System.EventHandler(this.txt個數_TextChanged);
            // 
            // txt訂購人
            // 
            this.txt訂購人.Location = new System.Drawing.Point(24, 222);
            this.txt訂購人.Margin = new System.Windows.Forms.Padding(6);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(273, 36);
            this.txt訂購人.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(1241, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "口味";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(1342, 793);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "品項總價";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1367, 665);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1367, 545);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "蛋糕品項";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(10, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "訂購人(電話)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 54);
            this.label1.TabIndex = 20;
            this.label1.Text = "蛋糕店訂購單Menu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(701, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 38);
            this.label7.TabIndex = 41;
            this.label7.Text = "商品圖檔";
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(478, 110);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(6);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(667, 434);
            this.listView商品展示.TabIndex = 42;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 蛋糕店訂購單Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1678, 1241);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn訂購);
            this.Controls.Add(this.chk買購物袋);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox蛋糕品項);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt個數);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "蛋糕店訂購單Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蛋糕店訂購單";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.蛋糕店訂購單Menu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn訂購;
        private System.Windows.Forms.CheckBox chk買購物袋;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio外帶;
        private System.Windows.Forms.RadioButton radio內用;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk草莓;
        private System.Windows.Forms.CheckBox chk藍莓;
        private System.Windows.Forms.CheckBox chk巧克力;
        private System.Windows.Forms.CheckBox chk水果;
        private System.Windows.Forms.CheckBox chk起司;
        private System.Windows.Forms.ListBox listBox蛋糕品項;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt個數;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList產品圖檔;
    }
}

