namespace WindowsFormsApp5_期中專案
{
    partial class 會員登入表單
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
            this.btn新增會員 = new System.Windows.Forms.Button();
            this.btn蛋糕店訂購單 = new System.Windows.Forms.Button();
            this.btn登入 = new System.Windows.Forms.Button();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn新增會員
            // 
            this.btn新增會員.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增會員.Location = new System.Drawing.Point(843, 393);
            this.btn新增會員.Margin = new System.Windows.Forms.Padding(5);
            this.btn新增會員.Name = "btn新增會員";
            this.btn新增會員.Size = new System.Drawing.Size(300, 89);
            this.btn新增會員.TabIndex = 23;
            this.btn新增會員.Text = "新增會員";
            this.btn新增會員.UseVisualStyleBackColor = true;
            this.btn新增會員.Click += new System.EventHandler(this.btn新增會員_Click);
            // 
            // btn蛋糕店訂購單
            // 
            this.btn蛋糕店訂購單.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn蛋糕店訂購單.Location = new System.Drawing.Point(305, 521);
            this.btn蛋糕店訂購單.Margin = new System.Windows.Forms.Padding(5);
            this.btn蛋糕店訂購單.Name = "btn蛋糕店訂購單";
            this.btn蛋糕店訂購單.Size = new System.Drawing.Size(546, 189);
            this.btn蛋糕店訂購單.TabIndex = 22;
            this.btn蛋糕店訂購單.Text = "蛋糕店訂購單";
            this.btn蛋糕店訂購單.UseVisualStyleBackColor = true;
            this.btn蛋糕店訂購單.Click += new System.EventHandler(this.btn蛋糕店訂購單_Click);
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(843, 285);
            this.btn登入.Margin = new System.Windows.Forms.Padding(5);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(164, 83);
            this.btn登入.TabIndex = 20;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(369, 388);
            this.txt密碼.Margin = new System.Windows.Forms.Padding(5);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(420, 71);
            this.txt密碼.TabIndex = 19;
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(369, 291);
            this.txt帳號.Margin = new System.Windows.Forms.Padding(5);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(420, 71);
            this.txt帳號.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(220, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 61);
            this.label3.TabIndex = 17;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(116, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 61);
            this.label2.TabIndex = 16;
            this.label2.Text = "帳號/手機";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(519, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 15;
            this.label1.Text = "會員登入";
            // 
            // 會員登入表單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 840);
            this.Controls.Add(this.btn新增會員);
            this.Controls.Add(this.btn蛋糕店訂購單);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "會員登入表單";
            this.Text = "會員登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.會員登入表單_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn新增會員;
        private System.Windows.Forms.Button btn蛋糕店訂購單;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}