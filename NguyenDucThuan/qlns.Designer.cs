﻿namespace NguyenDucThuan
{
    partial class frmQuanlynv
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
            this.mnQLNS = new System.Windows.Forms.MenuStrip();
            this.mnHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.cbxGioitinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvDsnv = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.wF_QL_nhanvienDataSet = new NguyenDucThuan.WF_QL_nhanvienDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new NguyenDucThuan.WF_QL_nhanvienDataSetTableAdapters.nhanvienTableAdapter();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotennvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnQLNS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wF_QL_nhanvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mnQLNS
            // 
            this.mnQLNS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnQLNS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHethong,
            this.mnQuanly,
            this.mnThongke,
            this.mnTrogiup});
            this.mnQLNS.Location = new System.Drawing.Point(0, 0);
            this.mnQLNS.Name = "mnQLNS";
            this.mnQLNS.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnQLNS.Size = new System.Drawing.Size(1200, 30);
            this.mnQLNS.TabIndex = 0;
            this.mnQLNS.Text = "MenuQLNS";
            // 
            // mnHethong
            // 
            this.mnHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mnHethong.Name = "mnHethong";
            this.mnHethong.Size = new System.Drawing.Size(85, 24);
            this.mnHethong.Text = "Hệ thống";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // mnQuanly
            // 
            this.mnQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânSựToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.mnQuanly.Name = "mnQuanly";
            this.mnQuanly.Size = new System.Drawing.Size(73, 24);
            this.mnQuanly.Text = "Quản lý";
            // 
            // nhânSựToolStripMenuItem
            // 
            this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            this.nhânSựToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.nhânSựToolStripMenuItem.Text = "Nhân sự";
            this.nhânSựToolStripMenuItem.Click += new System.EventHandler(this.nhânSựToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // mnThongke
            // 
            this.mnThongke.Name = "mnThongke";
            this.mnThongke.Size = new System.Drawing.Size(84, 24);
            this.mnThongke.Text = "Thống kê";
            // 
            // mnTrogiup
            // 
            this.mnTrogiup.Name = "mnTrogiup";
            this.mnTrogiup.Size = new System.Drawing.Size(78, 24);
            this.mnTrogiup.Text = "Trợ giúp";
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(18, 58);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(138, 58);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(258, 58);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.cbxGioitinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNgaysinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1164, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Tìm Kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Enabled = false;
            this.btnTimkiem.Location = new System.Drawing.Point(1020, 105);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(112, 34);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã NV";
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(666, 110);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(298, 30);
            this.txtManv.TabIndex = 6;
            // 
            // cbxGioitinh
            // 
            this.cbxGioitinh.Enabled = false;
            this.cbxGioitinh.FormattingEnabled = true;
            this.cbxGioitinh.Location = new System.Drawing.Point(666, 50);
            this.cbxGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGioitinh.Name = "cbxGioitinh";
            this.cbxGioitinh.Size = new System.Drawing.Size(298, 30);
            this.cbxGioitinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Enabled = false;
            this.dtpNgaysinh.Location = new System.Drawing.Point(156, 111);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(298, 30);
            this.dtpNgaysinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(156, 50);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(298, 30);
            this.txtHoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dtgvDsnv
            // 
            this.dtgvDsnv.AutoGenerateColumns = false;
            this.dtgvDsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manvDataGridViewTextBoxColumn,
            this.hotennvDataGridViewTextBoxColumn,
            this.phongbanDataGridViewTextBoxColumn,
            this.hesoluongDataGridViewTextBoxColumn,
            this.chucvuDataGridViewTextBoxColumn});
            this.dtgvDsnv.DataSource = this.nhanvienBindingSource;
            this.dtgvDsnv.Location = new System.Drawing.Point(18, 398);
            this.dtgvDsnv.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDsnv.Name = "dtgvDsnv";
            this.dtgvDsnv.RowHeadersWidth = 51;
            this.dtgvDsnv.Size = new System.Drawing.Size(1164, 371);
            this.dtgvDsnv.TabIndex = 9;
            this.dtgvDsnv.Visible = false;
            this.dtgvDsnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsnv_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(378, 58);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // wF_QL_nhanvienDataSet
            // 
            this.wF_QL_nhanvienDataSet.DataSetName = "WF_QL_nhanvienDataSet";
            this.wF_QL_nhanvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.wF_QL_nhanvienDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "manv";
            this.manvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            this.manvDataGridViewTextBoxColumn.Width = 125;
            // 
            // hotennvDataGridViewTextBoxColumn
            // 
            this.hotennvDataGridViewTextBoxColumn.DataPropertyName = "hotennv";
            this.hotennvDataGridViewTextBoxColumn.HeaderText = "hotennv";
            this.hotennvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotennvDataGridViewTextBoxColumn.Name = "hotennvDataGridViewTextBoxColumn";
            this.hotennvDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongbanDataGridViewTextBoxColumn
            // 
            this.phongbanDataGridViewTextBoxColumn.DataPropertyName = "phongban";
            this.phongbanDataGridViewTextBoxColumn.HeaderText = "phongban";
            this.phongbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongbanDataGridViewTextBoxColumn.Name = "phongbanDataGridViewTextBoxColumn";
            this.phongbanDataGridViewTextBoxColumn.Width = 125;
            // 
            // hesoluongDataGridViewTextBoxColumn
            // 
            this.hesoluongDataGridViewTextBoxColumn.DataPropertyName = "hesoluong";
            this.hesoluongDataGridViewTextBoxColumn.HeaderText = "hesoluong";
            this.hesoluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hesoluongDataGridViewTextBoxColumn.Name = "hesoluongDataGridViewTextBoxColumn";
            this.hesoluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // chucvuDataGridViewTextBoxColumn
            // 
            this.chucvuDataGridViewTextBoxColumn.DataPropertyName = "chucvu";
            this.chucvuDataGridViewTextBoxColumn.HeaderText = "chucvu";
            this.chucvuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucvuDataGridViewTextBoxColumn.Name = "chucvuDataGridViewTextBoxColumn";
            this.chucvuDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmQuanlynv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dtgvDsnv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.mnQLNS);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnQLNS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanlynv";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanlynv_Load);
            this.mnQLNS.ResumeLayout(false);
            this.mnQLNS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wF_QL_nhanvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnQLNS;
        private System.Windows.Forms.ToolStripMenuItem mnHethong;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnQuanly;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnThongke;
        private System.Windows.Forms.ToolStripMenuItem mnTrogiup;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.ComboBox cbxGioitinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvDsnv;
        private System.Windows.Forms.Button btnHuy;
        private WF_QL_nhanvienDataSet wF_QL_nhanvienDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private WF_QL_nhanvienDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvuDataGridViewTextBoxColumn;
    }
}