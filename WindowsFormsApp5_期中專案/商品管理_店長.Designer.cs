﻿namespace WindowsFormsApp5_期中專案
{
    partial class 商品管理_店長
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
            this.components = new System.ComponentModel.Container();
            this.btn重新載入 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn重新載入
            // 
            this.btn重新載入.Location = new System.Drawing.Point(1139, 842);
            this.btn重新載入.Margin = new System.Windows.Forms.Padding(6);
            this.btn重新載入.Name = "btn重新載入";
            this.btn重新載入.Size = new System.Drawing.Size(258, 100);
            this.btn重新載入.TabIndex = 11;
            this.btn重新載入.Text = "重新載入";
            this.btn重新載入.UseVisualStyleBackColor = true;
            this.btn重新載入.Click += new System.EventHandler(this.btn重新載入_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.Location = new System.Drawing.Point(1139, 730);
            this.btn新增商品.Margin = new System.Windows.Forms.Padding(6);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(258, 100);
            this.btn新增商品.TabIndex = 10;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = true;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.Location = new System.Drawing.Point(1139, 618);
            this.btn列表模式.Margin = new System.Windows.Forms.Padding(6);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(258, 100);
            this.btn列表模式.TabIndex = 9;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = true;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.Location = new System.Drawing.Point(1139, 506);
            this.btn圖片模式.Margin = new System.Windows.Forms.Padding(6);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(258, 100);
            this.btn圖片模式.TabIndex = 8;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = true;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(27, 182);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(6);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(1018, 764);
            this.listView商品展示.TabIndex = 7;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(638, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品管理";
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 商品管理_店長
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 981);
            this.Controls.Add(this.btn重新載入);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.label1);
            this.Name = "商品管理_店長";
            this.Text = "商品管理_店長";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.商品管理_店長_FormClosed);
            this.Load += new System.EventHandler(this.商品資料維護_店長_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn重新載入;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList產品圖檔;
    }
}