namespace mHospital
{
    partial class frmDonThuoc
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
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgvChiTietDT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaDonThuoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblTenBN = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lblDiaChi = new DevComponents.DotNetBar.LabelX();
            this.lblNgaySinh = new DevComponents.DotNetBar.LabelX();
            this.lblGioiTinh = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lblMaBN = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtBacSi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.txtLieuDung = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.dtNgayThang = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.txtTenThuoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clmMaChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLieuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(444, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 46);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm thuốc";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvChiTietDT
            // 
            this.dgvChiTietDT.AllowUserToAddRows = false;
            this.dgvChiTietDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaChiTiet,
            this.clmTenThuoc,
            this.clmLieuDung,
            this.soLuong});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietDT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChiTietDT.Location = new System.Drawing.Point(324, 192);
            this.dgvChiTietDT.Name = "dgvChiTietDT";
            this.dgvChiTietDT.RowHeadersVisible = false;
            this.dgvChiTietDT.Size = new System.Drawing.Size(498, 150);
            this.dgvChiTietDT.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(339, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(145, 49);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "ĐƠN THUỐC";
            // 
            // txtMaDonThuoc
            // 
            // 
            // 
            // 
            this.txtMaDonThuoc.Border.Class = "TextBoxBorder";
            this.txtMaDonThuoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaDonThuoc.Location = new System.Drawing.Point(106, 22);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(145, 20);
            this.txtMaDonThuoc.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(42, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Họ và tên:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(591, 56);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Giới tính:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(386, 94);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Địa chỉ:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(384, 56);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Ngày sinh:";
            // 
            // lblTenBN
            // 
            // 
            // 
            // 
            this.lblTenBN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBN.ForeColor = System.Drawing.Color.Black;
            this.lblTenBN.Location = new System.Drawing.Point(123, 56);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(242, 23);
            this.lblTenBN.TabIndex = 2;
            this.lblTenBN.Text = "lblTenBN";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(13, 19);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(91, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Mã đơn thuốc:";
            // 
            // lblDiaChi
            // 
            // 
            // 
            // 
            this.lblDiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(464, 94);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(242, 23);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "lblDiaChi";
            // 
            // lblNgaySinh
            // 
            // 
            // 
            // 
            this.lblNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(476, 56);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(109, 23);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "lblTuoi";
            // 
            // lblGioiTinh
            // 
            // 
            // 
            // 
            this.lblGioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(670, 56);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(109, 23);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "lblGioiTinh";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(42, 94);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(112, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Mã bệnh nhân:";
            // 
            // lblMaBN
            // 
            // 
            // 
            // 
            this.lblMaBN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBN.ForeColor = System.Drawing.Color.Black;
            this.lblMaBN.Location = new System.Drawing.Point(160, 94);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(181, 23);
            this.lblMaBN.TabIndex = 2;
            this.lblMaBN.Text = "Mã BN";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(13, 48);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(91, 23);
            this.labelX8.TabIndex = 2;
            this.labelX8.Text = "Bác sĩ kê đơn:";
            // 
            // txtBacSi
            // 
            // 
            // 
            // 
            this.txtBacSi.Border.Class = "TextBoxBorder";
            this.txtBacSi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBacSi.Location = new System.Drawing.Point(106, 51);
            this.txtBacSi.Name = "txtBacSi";
            this.txtBacSi.Size = new System.Drawing.Size(145, 20);
            this.txtBacSi.TabIndex = 3;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(13, 77);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(91, 23);
            this.labelX9.TabIndex = 2;
            this.labelX9.Text = "Ngày kê đơn:";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(13, 116);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(121, 23);
            this.labelX10.TabIndex = 2;
            this.labelX10.Text = "Nội dung đơn thuốc:";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(13, 217);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(58, 23);
            this.labelX11.TabIndex = 2;
            this.labelX11.Text = "Ghi chú:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(13, 135);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(238, 62);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.Text = "";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(13, 236);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(238, 62);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.Text = "";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(488, 167);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(183, 23);
            this.labelX12.TabIndex = 2;
            this.labelX12.Text = "CHI TIẾT ĐƠN THUỐC";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(324, 359);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(67, 23);
            this.labelX13.TabIndex = 2;
            this.labelX13.Text = "Tên thuốc:";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(324, 400);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(62, 23);
            this.labelX14.TabIndex = 2;
            this.labelX14.Text = "Liều dùng:";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(397, 402);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(332, 41);
            this.txtLieuDung.TabIndex = 4;
            this.txtLieuDung.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(94, 304);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 46);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayThang);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.txtNoiDung);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX11);
            this.groupBox1.Controls.Add(this.txtBacSi);
            this.groupBox1.Controls.Add(this.txtMaDonThuoc);
            this.groupBox1.Location = new System.Drawing.Point(13, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuong.Location = new System.Drawing.Point(735, 362);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(97, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(638, 359);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(91, 23);
            this.labelX15.TabIndex = 2;
            this.labelX15.Text = "Số lượng thuốc:";
            // 
            // dtNgayThang
            // 
            // 
            // 
            // 
            this.dtNgayThang.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayThang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThang.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayThang.ButtonDropDown.Visible = true;
            this.dtNgayThang.IsPopupCalendarOpen = false;
            this.dtNgayThang.Location = new System.Drawing.Point(106, 79);
            // 
            // 
            // 
            this.dtNgayThang.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayThang.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThang.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgayThang.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayThang.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThang.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtNgayThang.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayThang.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayThang.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayThang.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayThang.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayThang.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThang.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayThang.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayThang.Name = "dtNgayThang";
            this.dtNgayThang.Size = new System.Drawing.Size(145, 20);
            this.dtNgayThang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgayThang.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(581, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 46);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa thuốc";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtTenThuoc.Border.Class = "TextBoxBorder";
            this.txtTenThuoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenThuoc.Location = new System.Drawing.Point(397, 362);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(222, 20);
            this.txtTenThuoc.TabIndex = 3;
            // 
            // clmMaChiTiet
            // 
            this.clmMaChiTiet.DataPropertyName = "MaChiTietDonThuoc";
            this.clmMaChiTiet.HeaderText = "Mã";
            this.clmMaChiTiet.Name = "clmMaChiTiet";
            this.clmMaChiTiet.Width = 50;
            // 
            // clmTenThuoc
            // 
            this.clmTenThuoc.DataPropertyName = "TenThuoc";
            this.clmTenThuoc.HeaderText = "Tên Thuốc";
            this.clmTenThuoc.Name = "clmTenThuoc";
            this.clmTenThuoc.Width = 150;
            // 
            // clmLieuDung
            // 
            this.clmLieuDung.DataPropertyName = "LieuDung";
            this.clmLieuDung.HeaderText = "Liều Dùng";
            this.clmLieuDung.Name = "clmLieuDung";
            this.clmLieuDung.Width = 200;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "SoLuongThuoc";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            // 
            // frmDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 527);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLieuDung);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblMaBN);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblTenBN);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvChiTietDT);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.Name = "frmDonThuoc";
            this.Text = "Đơn thuốc";
            this.Load += new System.EventHandler(this.frmDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChiTietDT;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaDonThuoc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblTenBN;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX lblDiaChi;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX lblNgaySinh;
        private DevComponents.DotNetBar.LabelX lblGioiTinh;
        private DevComponents.DotNetBar.LabelX lblMaBN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBacSi;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private System.Windows.Forms.RichTextBox txtLieuDung;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayThang;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLieuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
    }
}