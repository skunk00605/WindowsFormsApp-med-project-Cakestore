namespace WindowsFormsApp5_期中專案
{
    partial class 訂單管理_店長
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgn會員資料列表 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt手機帳號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgn會員資料列表)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox4.Controls.Add(this.dgn會員資料列表);
            this.groupBox4.Location = new System.Drawing.Point(451, 69);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(1049, 707);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "訂單資料列表";
            // 
            // dgn會員資料列表
            // 
            this.dgn會員資料列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgn會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgn會員資料列表.Location = new System.Drawing.Point(12, 35);
            this.dgn會員資料列表.Margin = new System.Windows.Forms.Padding(6);
            this.dgn會員資料列表.Name = "dgn會員資料列表";
            this.dgn會員資料列表.RowHeadersWidth = 82;
            this.dgn會員資料列表.RowTemplate.Height = 24;
            this.dgn會員資料列表.Size = new System.Drawing.Size(1031, 666);
            this.dgn會員資料列表.TabIndex = 0;
            this.dgn會員資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgn會員資料列表_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.txt手機帳號);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Location = new System.Drawing.Point(66, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(373, 346);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
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
            // 訂單管理_店長
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 1143);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "訂單管理_店長";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.訂單管理_店長_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgn會員資料列表)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgn會員資料列表;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt手機帳號;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn資料搜尋;
    }
}