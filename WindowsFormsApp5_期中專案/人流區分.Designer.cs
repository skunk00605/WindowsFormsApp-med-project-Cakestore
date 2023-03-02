namespace WindowsFormsApp5_期中專案
{
    partial class 人流區分
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(人流區分));
            this.label1 = new System.Windows.Forms.Label();
            this.btn顧客 = new System.Windows.Forms.Button();
            this.btn員工 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(107, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 61);
            this.label1.TabIndex = 16;
            this.label1.Text = "*臘腸狗* 蛋糕店登入頁面";
            // 
            // btn顧客
            // 
            this.btn顧客.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顧客.Location = new System.Drawing.Point(773, 53);
            this.btn顧客.Margin = new System.Windows.Forms.Padding(5);
            this.btn顧客.Name = "btn顧客";
            this.btn顧客.Size = new System.Drawing.Size(214, 72);
            this.btn顧客.TabIndex = 23;
            this.btn顧客.Text = "顧客";
            this.btn顧客.UseVisualStyleBackColor = true;
            this.btn顧客.Click += new System.EventHandler(this.btn顧客_Click);
            // 
            // btn員工
            // 
            this.btn員工.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工.Location = new System.Drawing.Point(773, 157);
            this.btn員工.Margin = new System.Windows.Forms.Padding(5);
            this.btn員工.Name = "btn員工";
            this.btn員工.Size = new System.Drawing.Size(214, 76);
            this.btn員工.TabIndex = 24;
            this.btn員工.Text = "員工";
            this.btn員工.UseVisualStyleBackColor = true;
            this.btn員工.Click += new System.EventHandler(this.btn員工_Click);
            // 
            // 人流區分
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 1053);
            this.Controls.Add(this.btn員工);
            this.Controls.Add(this.btn顧客);
            this.Controls.Add(this.label1);
            this.Name = "人流區分";
            this.Text = "人流區分";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.人流區分_FormClosed);
            this.Load += new System.EventHandler(this.人流區分_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn顧客;
        private System.Windows.Forms.Button btn員工;
    }
}