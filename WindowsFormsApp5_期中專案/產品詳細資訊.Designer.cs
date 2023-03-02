namespace WindowsFormsApp5_期中專案
{
    partial class 產品詳細資訊
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(產品詳細資訊));
            this.groupBox新增 = new System.Windows.Forms.GroupBox();
            this.btn儲存商品 = new System.Windows.Forms.Button();
            this.btn選取商品圖片2 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.groupBox修改 = new System.Windows.Forms.GroupBox();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn選取商品圖片 = new System.Windows.Forms.Button();
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.mydbDataSet = new WindowsFormsApp5_期中專案.mydbDataSet();
            this.cakestore_orderlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakestore_orderlistTableAdapter = new WindowsFormsApp5_期中專案.mydbDataSetTableAdapters.Cakestore_orderlistTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp5_期中專案.mydbDataSetTableAdapters.TableAdapterManager();
            this.cakestore_orderlistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cakestore_orderlistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakestore_orderlistDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox新增.SuspendLayout();
            this.groupBox修改.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakestore_orderlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakestore_orderlistBindingNavigator)).BeginInit();
            this.cakestore_orderlistBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cakestore_orderlistDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox新增
            // 
            this.groupBox新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox新增.Controls.Add(this.btn儲存商品);
            this.groupBox新增.Controls.Add(this.btn選取商品圖片2);
            this.groupBox新增.Controls.Add(this.btn清空欄位);
            this.groupBox新增.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox新增.Location = new System.Drawing.Point(460, 842);
            this.groupBox新增.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox新增.Name = "groupBox新增";
            this.groupBox新增.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox新增.Size = new System.Drawing.Size(414, 228);
            this.groupBox新增.TabIndex = 25;
            this.groupBox新增.TabStop = false;
            this.groupBox新增.Text = "新增商品資訊";
            // 
            // btn儲存商品
            // 
            this.btn儲存商品.Location = new System.Drawing.Point(82, 162);
            this.btn儲存商品.Margin = new System.Windows.Forms.Padding(6);
            this.btn儲存商品.Name = "btn儲存商品";
            this.btn儲存商品.Size = new System.Drawing.Size(254, 46);
            this.btn儲存商品.TabIndex = 3;
            this.btn儲存商品.Text = "儲存商品";
            this.btn儲存商品.UseVisualStyleBackColor = true;
            this.btn儲存商品.Click += new System.EventHandler(this.btn儲存商品_Click);
            // 
            // btn選取商品圖片2
            // 
            this.btn選取商品圖片2.Location = new System.Drawing.Point(80, 102);
            this.btn選取商品圖片2.Margin = new System.Windows.Forms.Padding(6);
            this.btn選取商品圖片2.Name = "btn選取商品圖片2";
            this.btn選取商品圖片2.Size = new System.Drawing.Size(254, 46);
            this.btn選取商品圖片2.TabIndex = 2;
            this.btn選取商品圖片2.Text = "選取商品圖片";
            this.btn選取商品圖片2.UseVisualStyleBackColor = true;
            this.btn選取商品圖片2.Click += new System.EventHandler(this.btn選取商品圖片2_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(80, 46);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(6);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(254, 46);
            this.btn清空欄位.TabIndex = 1;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // groupBox修改
            // 
            this.groupBox修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox修改.Controls.Add(this.btn儲存修改);
            this.groupBox修改.Controls.Add(this.btn選取商品圖片);
            this.groupBox修改.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox修改.Location = new System.Drawing.Point(15, 838);
            this.groupBox修改.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox修改.Name = "groupBox修改";
            this.groupBox修改.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox修改.Size = new System.Drawing.Size(414, 232);
            this.groupBox修改.TabIndex = 24;
            this.groupBox修改.TabStop = false;
            this.groupBox修改.Text = "修改商品資訊";
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Location = new System.Drawing.Point(65, 142);
            this.btn儲存修改.Margin = new System.Windows.Forms.Padding(6);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(254, 46);
            this.btn儲存修改.TabIndex = 1;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取商品圖片
            // 
            this.btn選取商品圖片.Location = new System.Drawing.Point(65, 56);
            this.btn選取商品圖片.Margin = new System.Windows.Forms.Padding(6);
            this.btn選取商品圖片.Name = "btn選取商品圖片";
            this.btn選取商品圖片.Size = new System.Drawing.Size(254, 46);
            this.btn選取商品圖片.TabIndex = 0;
            this.btn選取商品圖片.Text = "選取商品圖片";
            this.btn選取商品圖片.UseVisualStyleBackColor = true;
            this.btn選取商品圖片.Click += new System.EventHandler(this.btn選取商品圖片_Click);
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(712, 236);
            this.pictureBox商品圖檔.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(585, 574);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 23;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // txt商品描述
            // 
            this.txt商品描述.Location = new System.Drawing.Point(302, 498);
            this.txt商品描述.Margin = new System.Windows.Forms.Padding(6);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(331, 326);
            this.txt商品描述.TabIndex = 22;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Location = new System.Drawing.Point(302, 394);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(6);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(264, 36);
            this.txt商品價格.TabIndex = 21;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Location = new System.Drawing.Point(302, 282);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(6);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(264, 36);
            this.txt商品名稱.TabIndex = 20;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(302, 198);
            this.lblPID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(107, 38);
            this.lblPID.TabIndex = 19;
            this.lblPID.Text = "00000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(463, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 64);
            this.label6.TabIndex = 18;
            this.label6.Text = "產品詳細資訊";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(722, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "商品圖檔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(109, 506);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "商品描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(109, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "商品價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(109, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(109, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "pid";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.btn刪除);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(899, 842);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(414, 232);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "刪除商品資訊";
            // 
            // btn刪除
            // 
            this.btn刪除.Location = new System.Drawing.Point(62, 82);
            this.btn刪除.Margin = new System.Windows.Forms.Padding(6);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(254, 46);
            this.btn刪除.TabIndex = 1;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cakestore_orderlistBindingSource
            // 
            this.cakestore_orderlistBindingSource.DataMember = "Cakestore_orderlist";
            this.cakestore_orderlistBindingSource.DataSource = this.mydbDataSet;
            // 
            // cakestore_orderlistTableAdapter
            // 
            this.cakestore_orderlistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cakestore_orderlistTableAdapter = this.cakestore_orderlistTableAdapter;
            this.tableAdapterManager.Cakestore_productsTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp5_期中專案.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cakestore_orderlistBindingNavigator
            // 
            this.cakestore_orderlistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cakestore_orderlistBindingNavigator.BindingSource = this.cakestore_orderlistBindingSource;
            this.cakestore_orderlistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cakestore_orderlistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cakestore_orderlistBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cakestore_orderlistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cakestore_orderlistBindingNavigatorSaveItem});
            this.cakestore_orderlistBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cakestore_orderlistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cakestore_orderlistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cakestore_orderlistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cakestore_orderlistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cakestore_orderlistBindingNavigator.Name = "cakestore_orderlistBindingNavigator";
            this.cakestore_orderlistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cakestore_orderlistBindingNavigator.Size = new System.Drawing.Size(2004, 42);
            this.cakestore_orderlistBindingNavigator.TabIndex = 26;
            this.cakestore_orderlistBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 36);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // cakestore_orderlistBindingNavigatorSaveItem
            // 
            this.cakestore_orderlistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cakestore_orderlistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cakestore_orderlistBindingNavigatorSaveItem.Image")));
            this.cakestore_orderlistBindingNavigatorSaveItem.Name = "cakestore_orderlistBindingNavigatorSaveItem";
            this.cakestore_orderlistBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.cakestore_orderlistBindingNavigatorSaveItem.Text = "儲存資料";
            this.cakestore_orderlistBindingNavigatorSaveItem.Click += new System.EventHandler(this.cakestore_orderlistBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "口味";
            this.dataGridViewTextBoxColumn7.HeaderText = "口味";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "買購物袋";
            this.dataGridViewCheckBoxColumn2.HeaderText = "買購物袋";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 10;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "外帶";
            this.dataGridViewCheckBoxColumn1.HeaderText = "外帶";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 10;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "訂購人";
            this.dataGridViewTextBoxColumn6.HeaderText = "訂購人";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "個數";
            this.dataGridViewTextBoxColumn5.HeaderText = "個數";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "品項總價";
            this.dataGridViewTextBoxColumn4.HeaderText = "品項總價";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "單價";
            this.dataGridViewTextBoxColumn3.HeaderText = "單價";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "品項名稱";
            this.dataGridViewTextBoxColumn2.HeaderText = "品項名稱";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // cakestore_orderlistDataGridView
            // 
            this.cakestore_orderlistDataGridView.AutoGenerateColumns = false;
            this.cakestore_orderlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cakestore_orderlistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.cakestore_orderlistDataGridView.DataSource = this.cakestore_orderlistBindingSource;
            this.cakestore_orderlistDataGridView.Location = new System.Drawing.Point(12, 1083);
            this.cakestore_orderlistDataGridView.Name = "cakestore_orderlistDataGridView";
            this.cakestore_orderlistDataGridView.RowHeadersWidth = 82;
            this.cakestore_orderlistDataGridView.RowTemplate.Height = 38;
            this.cakestore_orderlistDataGridView.Size = new System.Drawing.Size(1926, 220);
            this.cakestore_orderlistDataGridView.TabIndex = 26;
            // 
            // 產品詳細資訊
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2004, 1364);
            this.Controls.Add(this.cakestore_orderlistDataGridView);
            this.Controls.Add(this.cakestore_orderlistBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox新增);
            this.Controls.Add(this.groupBox修改);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "產品詳細資訊";
            this.Text = "產品詳細資訊";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.產品詳細資訊_FormClosed);
            this.Load += new System.EventHandler(this.產品詳細資訊_Load);
            this.groupBox新增.ResumeLayout(false);
            this.groupBox修改.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakestore_orderlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakestore_orderlistBindingNavigator)).EndInit();
            this.cakestore_orderlistBindingNavigator.ResumeLayout(false);
            this.cakestore_orderlistBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cakestore_orderlistDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox新增;
        private System.Windows.Forms.Button btn儲存商品;
        private System.Windows.Forms.Button btn選取商品圖片2;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.GroupBox groupBox修改;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取商品圖片;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn刪除;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource cakestore_orderlistBindingSource;
        private mydbDataSetTableAdapters.Cakestore_orderlistTableAdapter cakestore_orderlistTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cakestore_orderlistBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cakestore_orderlistBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView cakestore_orderlistDataGridView;
    }
}