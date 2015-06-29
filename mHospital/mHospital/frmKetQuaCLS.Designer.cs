namespace mHospital
{
    partial class frmKetQuaCLS
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
            this.dgvKQ_CLS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnChiTietKQ = new DevComponents.DotNetBar.ButtonX();
            this.btnEnd = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtBacSiThucHien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.dtNgayLayMau = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.lblTenXN = new DevComponents.DotNetBar.LabelX();
            this.lblNgayThucHien = new DevComponents.DotNetBar.LabelX();
            this.lblBacSiChiDinh = new DevComponents.DotNetBar.LabelX();
            this.lblTenPhong = new DevComponents.DotNetBar.LabelX();
            this.lblMaCLS = new DevComponents.DotNetBar.LabelX();
            this.lblMaBN = new DevComponents.DotNetBar.LabelX();
            this.lblTenBN = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNguoiNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtNgayKQ = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.maCLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bscd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQ_CLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLayMau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKQ)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKQ_CLS
            // 
            this.dgvKQ_CLS.AllowUserToAddRows = false;
            this.dgvKQ_CLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKQ_CLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCLS,
            this.maBN,
            this.hoten,
            this.tenXN,
            this.kq,
            this.phong,
            this.bscd,
            this.ngayTH,
            this.NgayLM,
            this.ngayKQ,
            this.bsth,
            this.ngNhap,
            this.trangthai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKQ_CLS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKQ_CLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKQ_CLS.Location = new System.Drawing.Point(15, 56);
            this.dgvKQ_CLS.Name = "dgvKQ_CLS";
            this.dgvKQ_CLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKQ_CLS.Size = new System.Drawing.Size(849, 173);
            this.dgvKQ_CLS.TabIndex = 0;
            this.dgvKQ_CLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKQ_CLS_CellClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(256, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(293, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "KẾT QUẢ CẬN LÂM SÀNG";
            // 
            // btnChiTietKQ
            // 
            this.btnChiTietKQ.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChiTietKQ.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChiTietKQ.Location = new System.Drawing.Point(332, 263);
            this.btnChiTietKQ.Name = "btnChiTietKQ";
            this.btnChiTietKQ.Size = new System.Drawing.Size(120, 47);
            this.btnChiTietKQ.TabIndex = 2;
            this.btnChiTietKQ.Text = "Chi tiết kết quả";
            this.btnChiTietKQ.Click += new System.EventHandler(this.btnChiTietKQ_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnd.Location = new System.Drawing.Point(775, 280);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(89, 30);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "Đóng";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(211, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 22);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(293, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.WatermarkText = "Nhập mã hoặc tên bệnh nhân";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(10, 19);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Họ và tên:";
            // 
            // txtBacSiThucHien
            // 
            // 
            // 
            // 
            this.txtBacSiThucHien.Border.Class = "TextBoxBorder";
            this.txtBacSiThucHien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBacSiThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacSiThucHien.Location = new System.Drawing.Point(10, 41);
            this.txtBacSiThucHien.Name = "txtBacSiThucHien";
            this.txtBacSiThucHien.Size = new System.Drawing.Size(159, 22);
            this.txtBacSiThucHien.TabIndex = 9;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(10, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(117, 23);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "Bác sĩ thực hiện:";
            // 
            // dtNgayLayMau
            // 
            // 
            // 
            // 
            this.dtNgayLayMau.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayLayMau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayLayMau.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayLayMau.ButtonDropDown.Visible = true;
            this.dtNgayLayMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLayMau.IsPopupCalendarOpen = false;
            this.dtNgayLayMau.Location = new System.Drawing.Point(232, 41);
            // 
            // 
            // 
            this.dtNgayLayMau.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayLayMau.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayLayMau.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayLayMau.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayLayMau.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayLayMau.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtNgayLayMau.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayLayMau.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayLayMau.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayLayMau.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayLayMau.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayLayMau.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayLayMau.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayLayMau.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayLayMau.Name = "dtNgayLayMau";
            this.dtNgayLayMau.Size = new System.Drawing.Size(162, 22);
            this.dtNgayLayMau.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(333, 184);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 58);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX18);
            this.groupBox1.Controls.Add(this.labelX17);
            this.groupBox1.Controls.Add(this.labelX16);
            this.groupBox1.Controls.Add(this.labelX11);
            this.groupBox1.Controls.Add(this.lblTenXN);
            this.groupBox1.Controls.Add(this.lblNgayThucHien);
            this.groupBox1.Controls.Add(this.lblBacSiChiDinh);
            this.groupBox1.Controls.Add(this.lblTenPhong);
            this.groupBox1.Controls.Add(this.lblMaCLS);
            this.groupBox1.Controls.Add(this.lblMaBN);
            this.groupBox1.Controls.Add(this.lblTenBN);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Location = new System.Drawing.Point(2, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 255);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(10, 188);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(105, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Tên xét nghiệm:";
            // 
            // labelX18
            // 
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX18.Location = new System.Drawing.Point(10, 131);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(105, 23);
            this.labelX18.TabIndex = 10;
            this.labelX18.Text = "Bác sĩ chỉ định:";
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(10, 103);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(105, 23);
            this.labelX17.TabIndex = 10;
            this.labelX17.Text = "Tên phòng:";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(10, 75);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(105, 23);
            this.labelX16.TabIndex = 10;
            this.labelX16.Text = "Mã cận lâm sàng:";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(10, 47);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(89, 23);
            this.labelX11.TabIndex = 10;
            this.labelX11.Text = "Mã bệnh nhân:";
            // 
            // lblTenXN
            // 
            // 
            // 
            // 
            this.lblTenXN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXN.ForeColor = System.Drawing.Color.Black;
            this.lblTenXN.Location = new System.Drawing.Point(121, 188);
            this.lblTenXN.Name = "lblTenXN";
            this.lblTenXN.Size = new System.Drawing.Size(230, 23);
            this.lblTenXN.TabIndex = 10;
            this.lblTenXN.Text = "Họ và tên:";
            // 
            // lblNgayThucHien
            // 
            // 
            // 
            // 
            this.lblNgayThucHien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNgayThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThucHien.ForeColor = System.Drawing.Color.Black;
            this.lblNgayThucHien.Location = new System.Drawing.Point(121, 159);
            this.lblNgayThucHien.Name = "lblNgayThucHien";
            this.lblNgayThucHien.Size = new System.Drawing.Size(230, 23);
            this.lblNgayThucHien.TabIndex = 10;
            this.lblNgayThucHien.Text = "Họ và tên:";
            // 
            // lblBacSiChiDinh
            // 
            // 
            // 
            // 
            this.lblBacSiChiDinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBacSiChiDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacSiChiDinh.ForeColor = System.Drawing.Color.Black;
            this.lblBacSiChiDinh.Location = new System.Drawing.Point(121, 131);
            this.lblBacSiChiDinh.Name = "lblBacSiChiDinh";
            this.lblBacSiChiDinh.Size = new System.Drawing.Size(230, 23);
            this.lblBacSiChiDinh.TabIndex = 10;
            this.lblBacSiChiDinh.Text = "Họ và tên:";
            // 
            // lblTenPhong
            // 
            // 
            // 
            // 
            this.lblTenPhong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.Black;
            this.lblTenPhong.Location = new System.Drawing.Point(121, 103);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(230, 23);
            this.lblTenPhong.TabIndex = 10;
            this.lblTenPhong.Text = "Họ và tên:";
            // 
            // lblMaCLS
            // 
            // 
            // 
            // 
            this.lblMaCLS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaCLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCLS.ForeColor = System.Drawing.Color.Black;
            this.lblMaCLS.Location = new System.Drawing.Point(121, 75);
            this.lblMaCLS.Name = "lblMaCLS";
            this.lblMaCLS.Size = new System.Drawing.Size(230, 23);
            this.lblMaCLS.TabIndex = 10;
            this.lblMaCLS.Text = "Họ và tên:";
            // 
            // lblMaBN
            // 
            // 
            // 
            // 
            this.lblMaBN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBN.ForeColor = System.Drawing.Color.Black;
            this.lblMaBN.Location = new System.Drawing.Point(121, 47);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(230, 23);
            this.lblMaBN.TabIndex = 10;
            this.lblMaBN.Text = "Họ và tên:";
            // 
            // lblTenBN
            // 
            // 
            // 
            // 
            this.lblTenBN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBN.ForeColor = System.Drawing.Color.Black;
            this.lblTenBN.Location = new System.Drawing.Point(121, 19);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(230, 23);
            this.lblTenBN.TabIndex = 10;
            this.lblTenBN.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNguoiNhap);
            this.groupBox2.Controls.Add(this.txtBacSiThucHien);
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Controls.Add(this.labelX7);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.dtNgayKQ);
            this.groupBox2.Controls.Add(this.labelX9);
            this.groupBox2.Controls.Add(this.labelX12);
            this.groupBox2.Controls.Add(this.labelX8);
            this.groupBox2.Controls.Add(this.dtNgayLayMau);
            this.groupBox2.Location = new System.Drawing.Point(368, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 255);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txtNguoiNhap
            // 
            // 
            // 
            // 
            this.txtNguoiNhap.Border.Class = "TextBoxBorder";
            this.txtNguoiNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNguoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhap.Location = new System.Drawing.Point(10, 97);
            this.txtNguoiNhap.Name = "txtNguoiNhap";
            this.txtNguoiNhap.Size = new System.Drawing.Size(159, 22);
            this.txtNguoiNhap.TabIndex = 9;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(10, 164);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(287, 78);
            this.txtKetQua.TabIndex = 11;
            this.txtKetQua.Text = "";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(232, 75);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(117, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Ngày trả kết quả:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(232, 19);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(117, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Ngày lấy mẫu:";
            // 
            // dtNgayKQ
            // 
            // 
            // 
            // 
            this.dtNgayKQ.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayKQ.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKQ.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayKQ.ButtonDropDown.Visible = true;
            this.dtNgayKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKQ.IsPopupCalendarOpen = false;
            this.dtNgayKQ.Location = new System.Drawing.Point(232, 97);
            // 
            // 
            // 
            this.dtNgayKQ.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayKQ.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayKQ.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKQ.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayKQ.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKQ.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtNgayKQ.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayKQ.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayKQ.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayKQ.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayKQ.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayKQ.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayKQ.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayKQ.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayKQ.Name = "dtNgayKQ";
            this.dtNgayKQ.Size = new System.Drawing.Size(162, 22);
            this.dtNgayKQ.TabIndex = 12;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(10, 135);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(117, 23);
            this.labelX9.TabIndex = 10;
            this.labelX9.Text = "Kết quả:";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(10, 75);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(117, 23);
            this.labelX12.TabIndex = 10;
            this.labelX12.Text = "Người nhập liệu:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.labelX2);
            this.groupBox3.Controls.Add(this.dgvKQ_CLS);
            this.groupBox3.Controls.Add(this.btnEnd);
            this.groupBox3.Controls.Add(this.btnChiTietKQ);
            this.groupBox3.Location = new System.Drawing.Point(2, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 317);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH CẬN LÂM SÀNG";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(10, 159);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(105, 23);
            this.labelX10.TabIndex = 10;
            this.labelX10.Text = "Ngày thực hiện:";
            // 
            // maCLS
            // 
            this.maCLS.DataPropertyName = "MaChiTietCanLamSang";
            this.maCLS.HeaderText = "Mã cận lâm sàng";
            this.maCLS.Name = "maCLS";
            // 
            // maBN
            // 
            this.maBN.DataPropertyName = "MaBenhNhan";
            this.maBN.HeaderText = "Mã bệnh nhân";
            this.maBN.Name = "maBN";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "TenBenhNhan";
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.Name = "hoten";
            // 
            // tenXN
            // 
            this.tenXN.DataPropertyName = "TenXetNghiem";
            this.tenXN.HeaderText = "Tên xét nghiệm";
            this.tenXN.Name = "tenXN";
            // 
            // kq
            // 
            this.kq.DataPropertyName = "KetQuaCLS";
            this.kq.HeaderText = "Kết quả";
            this.kq.Name = "kq";
            // 
            // phong
            // 
            this.phong.DataPropertyName = "TenPhongKham";
            this.phong.HeaderText = "Tên Phòng";
            this.phong.Name = "phong";
            // 
            // bscd
            // 
            this.bscd.DataPropertyName = "BacSiChiDinh";
            this.bscd.HeaderText = "Bác sĩ chỉ định";
            this.bscd.Name = "bscd";
            // 
            // ngayTH
            // 
            this.ngayTH.DataPropertyName = "NgayThucHien";
            this.ngayTH.HeaderText = "Ngày thực hiện";
            this.ngayTH.Name = "ngayTH";
            // 
            // NgayLM
            // 
            this.NgayLM.DataPropertyName = "NgayLayMau";
            this.NgayLM.HeaderText = "Ngày lấy mẫu";
            this.NgayLM.Name = "NgayLM";
            // 
            // ngayKQ
            // 
            this.ngayKQ.DataPropertyName = "NgayTraKQ";
            this.ngayKQ.HeaderText = "Ngày trả kết quả";
            this.ngayKQ.Name = "ngayKQ";
            // 
            // bsth
            // 
            this.bsth.DataPropertyName = "BacSiThucHien";
            this.bsth.HeaderText = "Bác sĩ thực hiện";
            this.bsth.Name = "bsth";
            // 
            // ngNhap
            // 
            this.ngNhap.DataPropertyName = "NhanVienNhapLieu";
            this.ngNhap.HeaderText = "Người nhập liệu";
            this.ngNhap.Name = "ngNhap";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // frmKetQuaCLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmKetQuaCLS";
            this.Text = "Kết quả Cận lâm sàng";
            this.Load += new System.EventHandler(this.frmKetQuaCLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQ_CLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLayMau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKQ)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKQ_CLS;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnChiTietKQ;
        private DevComponents.DotNetBar.ButtonX btnEnd;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBacSiThucHien;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayLayMau;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX lblNgayThucHien;
        private DevComponents.DotNetBar.LabelX lblBacSiChiDinh;
        private DevComponents.DotNetBar.LabelX lblTenPhong;
        private DevComponents.DotNetBar.LabelX lblMaCLS;
        private DevComponents.DotNetBar.LabelX lblMaBN;
        private DevComponents.DotNetBar.LabelX lblTenBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lblTenXN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNguoiNhap;
        private System.Windows.Forms.RichTextBox txtKetQua;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayKQ;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn kq;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn bscd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn bsth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}