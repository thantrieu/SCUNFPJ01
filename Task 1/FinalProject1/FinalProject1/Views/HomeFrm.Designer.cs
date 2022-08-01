namespace Views
{
    partial class HomeFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelItemTo = new System.Windows.Forms.Label();
            this.labelItemFrom = new System.Windows.Forms.Label();
            this.labelItemKey = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortItemByName = new System.Windows.Forms.RadioButton();
            this.btnSortItemByDate = new System.Windows.Forms.RadioButton();
            this.btnSortItemByQuantity = new System.Windows.Forms.RadioButton();
            this.btnSortItemByPriceDESC = new System.Windows.Forms.RadioButton();
            this.btnSortItemByPrice = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.numericFrom = new System.Windows.Forms.NumericUpDown();
            this.numericTo = new System.Windows.Forms.NumericUpDown();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewItems);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1091, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QL MẶT HÀNG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.quantity,
            this.brand,
            this.day,
            this.price,
            this.edit,
            this.remove});
            this.dataGridViewItems.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(1077, 438);
            this.dataGridViewItems.TabIndex = 3;
            this.dataGridViewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericTo);
            this.groupBox3.Controls.Add(this.numericFrom);
            this.groupBox3.Controls.Add(this.labelItemTo);
            this.groupBox3.Controls.Add(this.labelItemFrom);
            this.groupBox3.Controls.Add(this.labelItemKey);
            this.groupBox3.Controls.Add(this.comboSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnSearchItem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(729, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // labelItemTo
            // 
            this.labelItemTo.AutoSize = true;
            this.labelItemTo.Location = new System.Drawing.Point(178, 111);
            this.labelItemTo.Name = "labelItemTo";
            this.labelItemTo.Size = new System.Drawing.Size(38, 17);
            this.labelItemTo.TabIndex = 6;
            this.labelItemTo.Text = "Đến:";
            // 
            // labelItemFrom
            // 
            this.labelItemFrom.AutoSize = true;
            this.labelItemFrom.Location = new System.Drawing.Point(39, 109);
            this.labelItemFrom.Name = "labelItemFrom";
            this.labelItemFrom.Size = new System.Drawing.Size(29, 17);
            this.labelItemFrom.TabIndex = 5;
            this.labelItemFrom.Text = "Từ:";
            // 
            // labelItemKey
            // 
            this.labelItemKey.AutoSize = true;
            this.labelItemKey.Location = new System.Drawing.Point(39, 68);
            this.labelItemKey.Name = "labelItemKey";
            this.labelItemKey.Size = new System.Drawing.Size(69, 17);
            this.labelItemKey.TabIndex = 4;
            this.labelItemKey.Text = "Nội dung:";
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "Tìm theo tên mặt hàng",
            "Tìm theo khoảng giá",
            "Tìm theo loại mặt hàng",
            "Tìm theo hãng sản xuất",
            "Tìm theo số lượng"});
            this.comboSearch.Location = new System.Drawing.Point(122, 22);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(194, 24);
            this.comboSearch.TabIndex = 0;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.SearchItemSelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(122, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu chí:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortItemByName);
            this.groupBox2.Controls.Add(this.btnSortItemByDate);
            this.groupBox2.Controls.Add(this.btnSortItemByQuantity);
            this.groupBox2.Controls.Add(this.btnSortItemByPriceDESC);
            this.groupBox2.Controls.Add(this.btnSortItemByPrice);
            this.groupBox2.Location = new System.Drawing.Point(337, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp theo";
            // 
            // btnSortItemByName
            // 
            this.btnSortItemByName.AutoSize = true;
            this.btnSortItemByName.Location = new System.Drawing.Point(11, 133);
            this.btnSortItemByName.Name = "btnSortItemByName";
            this.btnSortItemByName.Size = new System.Drawing.Size(138, 21);
            this.btnSortItemByName.TabIndex = 2;
            this.btnSortItemByName.Text = "Tên mặt hàng a-z";
            this.btnSortItemByName.UseVisualStyleBackColor = true;
            this.btnSortItemByName.CheckedChanged += new System.EventHandler(this.RadioSortItemCheckedChange);
            // 
            // btnSortItemByDate
            // 
            this.btnSortItemByDate.AutoSize = true;
            this.btnSortItemByDate.Location = new System.Drawing.Point(200, 86);
            this.btnSortItemByDate.Name = "btnSortItemByDate";
            this.btnSortItemByDate.Size = new System.Drawing.Size(176, 21);
            this.btnSortItemByDate.TabIndex = 4;
            this.btnSortItemByDate.Text = "Ngày sản xuất tăng dần";
            this.btnSortItemByDate.UseVisualStyleBackColor = true;
            this.btnSortItemByDate.CheckedChanged += new System.EventHandler(this.RadioSortItemCheckedChange);
            // 
            // btnSortItemByQuantity
            // 
            this.btnSortItemByQuantity.AutoSize = true;
            this.btnSortItemByQuantity.Location = new System.Drawing.Point(200, 40);
            this.btnSortItemByQuantity.Name = "btnSortItemByQuantity";
            this.btnSortItemByQuantity.Size = new System.Drawing.Size(144, 21);
            this.btnSortItemByQuantity.TabIndex = 3;
            this.btnSortItemByQuantity.Text = "Số lượng giảm dần";
            this.btnSortItemByQuantity.UseVisualStyleBackColor = true;
            this.btnSortItemByQuantity.CheckedChanged += new System.EventHandler(this.RadioSortItemCheckedChange);
            // 
            // btnSortItemByPriceDESC
            // 
            this.btnSortItemByPriceDESC.AutoSize = true;
            this.btnSortItemByPriceDESC.Location = new System.Drawing.Point(11, 86);
            this.btnSortItemByPriceDESC.Name = "btnSortItemByPriceDESC";
            this.btnSortItemByPriceDESC.Size = new System.Drawing.Size(167, 21);
            this.btnSortItemByPriceDESC.TabIndex = 1;
            this.btnSortItemByPriceDESC.Text = "Giá niêm yết giảm dần";
            this.btnSortItemByPriceDESC.UseVisualStyleBackColor = true;
            this.btnSortItemByPriceDESC.CheckedChanged += new System.EventHandler(this.RadioSortItemCheckedChange);
            // 
            // btnSortItemByPrice
            // 
            this.btnSortItemByPrice.AutoSize = true;
            this.btnSortItemByPrice.Location = new System.Drawing.Point(11, 40);
            this.btnSortItemByPrice.Name = "btnSortItemByPrice";
            this.btnSortItemByPrice.Size = new System.Drawing.Size(165, 21);
            this.btnSortItemByPrice.TabIndex = 0;
            this.btnSortItemByPrice.Text = "Giá niêm yết tăng dần";
            this.btnSortItemByPrice.UseVisualStyleBackColor = true;
            this.btnSortItemByPrice.CheckedChanged += new System.EventHandler(this.RadioSortItemCheckedChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAddNewItem);
            this.groupBox1.Location = new System.Drawing.Point(7, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1091, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QL KHÁCH HÀNG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1091, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QL KHUYẾN MÃI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1091, 646);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "QL HÓA ĐƠN";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1091, 646);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "THỐNG KÊ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // numericFrom
            // 
            this.numericFrom.Location = new System.Drawing.Point(74, 107);
            this.numericFrom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericFrom.Name = "numericFrom";
            this.numericFrom.Size = new System.Drawing.Size(98, 23);
            this.numericFrom.TabIndex = 7;
            // 
            // numericTo
            // 
            this.numericTo.Location = new System.Drawing.Point(222, 107);
            this.numericTo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericTo.Name = "numericTo";
            this.numericTo.Size = new System.Drawing.Size(94, 23);
            this.numericTo.TabIndex = 8;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Image = global::Views.Properties.Resources.search_24;
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchItem.Location = new System.Drawing.Point(114, 150);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(126, 33);
            this.btnSearchItem.TabIndex = 4;
            this.btnSearchItem.Text = "Tìm kiếm";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchItemClick);
            // 
            // button1
            // 
            this.button1.Image = global::Views.Properties.Resources.refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(172, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Image = global::Views.Properties.Resources.add;
            this.btnAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItem.Location = new System.Drawing.Point(23, 76);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(130, 37);
            this.btnAddNewItem.TabIndex = 0;
            this.btnAddNewItem.Text = "Thêm mới";
            this.btnAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "Mã MH";
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.HeaderText = "Tên MH";
            this.name.Name = "name";
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // type
            // 
            this.type.HeaderText = "Loại MH";
            this.type.Name = "type";
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brand
            // 
            this.brand.HeaderText = "Hãng SX";
            this.brand.Name = "brand";
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // day
            // 
            this.day.HeaderText = "Ngày SX";
            this.day.Name = "day";
            this.day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle4;
            this.price.HeaderText = "Giá bán";
            this.price.Name = "price";
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edit
            // 
            this.edit.HeaderText = "Sửa";
            this.edit.Name = "edit";
            this.edit.Text = "Sửa";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // remove
            // 
            this.remove.HeaderText = "Xóa";
            this.remove.Name = "remove";
            this.remove.Text = "Xóa";
            this.remove.UseColumnTextForButtonValue = true;
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 696);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeFrm";
            this.Text = "DỰ ÁN TỐT NGHIỆP CUỐI KHÓA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelItemKey;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnSortItemByName;
        private System.Windows.Forms.RadioButton btnSortItemByDate;
        private System.Windows.Forms.RadioButton btnSortItemByQuantity;
        private System.Windows.Forms.RadioButton btnSortItemByPriceDESC;
        private System.Windows.Forms.RadioButton btnSortItemByPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Label labelItemTo;
        private System.Windows.Forms.Label labelItemFrom;
        private System.Windows.Forms.NumericUpDown numericTo;
        private System.Windows.Forms.NumericUpDown numericFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}

