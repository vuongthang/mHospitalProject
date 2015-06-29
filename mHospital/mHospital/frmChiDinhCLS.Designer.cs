﻿namespace mHospital
{
    partial class frmChiDinhCLS
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.grvChiDinhCLS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maCLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMaBN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtBacSi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtPhongKham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEnd = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiDinhCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(318, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(275, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "CHỈ ĐỊNH CẬN LÂM SÀNG";
            // 
            // grvChiDinhCLS
            // 
            this.grvChiDinhCLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChiDinhCLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCLS,
            this.maBN,
            this.tenBN,
            this.tenPhongKham,
            this.tenXN,
            this.time,
            this.tenBS});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvChiDinhCLS.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvChiDinhCLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grvChiDinhCLS.Location = new System.Drawing.Point(64, 165);
            this.grvChiDinhCLS.Name = "grvChiDinhCLS";
            this.grvChiDinhCLS.Size = new System.Drawing.Size(739, 176);
            this.grvChiDinhCLS.TabIndex = 4;
            // 
            // maCLS
            // 
            this.maCLS.HeaderText = "Mã cận lâm sàng";
            this.maCLS.Name = "maCLS";
            // 
            // maBN
            // 
            this.maBN.HeaderText = "Mã bệnh nhân";
            this.maBN.Name = "maBN";
            // 
            // tenBN
            // 
            this.tenBN.HeaderText = "Họ và tên";
            this.tenBN.Name = "tenBN";
            // 
            // tenPhongKham
            // 
            this.tenPhongKham.HeaderText = "Tên phòng khám";
            this.tenPhongKham.Name = "tenPhongKham";
            // 
            // tenXN
            // 
            this.tenXN.HeaderText = "Tên xét nghiệm";
            this.tenXN.Name = "tenXN";
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian thực hiện";
            this.time.Name = "time";
            // 
            // tenBS
            // 
            this.tenBS.HeaderText = "Bác sĩ chỉ định";
            this.tenBS.Name = "tenBS";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(43, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(64, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(111, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Bệnh Nhân: ";
            // 
            // txtMaBN
            // 
            // 
            // 
            // 
            this.txtMaBN.Border.Class = "TextBoxBorder";
            this.txtMaBN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaBN.Location = new System.Drawing.Point(94, 380);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(159, 20);
            this.txtMaBN.TabIndex = 9;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 418);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoTen.Location = new System.Drawing.Point(93, 421);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(159, 20);
            this.txtHoTen.TabIndex = 9;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(277, 421);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Bác sĩ chỉ định";
            // 
            // txtBacSi
            // 
            // 
            // 
            // 
            this.txtBacSi.Border.Class = "TextBoxBorder";
            this.txtBacSi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBacSi.Location = new System.Drawing.Point(367, 421);
            this.txtBacSi.Name = "txtBacSi";
            this.txtBacSi.Size = new System.Drawing.Size(159, 20);
            this.txtBacSi.TabIndex = 9;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(277, 380);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(88, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "Tên phòng khám";
            // 
            // txtPhongKham
            // 
            // 
            // 
            // 
            this.txtPhongKham.Border.Class = "TextBoxBorder";
            this.txtPhongKham.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhongKham.Location = new System.Drawing.Point(367, 380);
            this.txtPhongKham.Name = "txtPhongKham";
            this.txtPhongKham.Size = new System.Drawing.Size(159, 20);
            this.txtPhongKham.TabIndex = 9;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(557, 418);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(118, 23);
            this.labelX7.TabIndex = 8;
            this.labelX7.Text = "Ngày giờ thực hiện";
            // 
            // dateTimeInput
            // 
            // 
            // 
            // 
            this.dateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput.ButtonDropDown.Visible = true;
            this.dateTimeInput.IsPopupCalendarOpen = false;
            this.dateTimeInput.Location = new System.Drawing.Point(673, 418);
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dateTimeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(158, 20);
            this.dateTimeInput.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(160, 477);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(277, 477);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            // 
            // btnEnd
            // 
            this.btnEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnd.Location = new System.Drawing.Point(611, 477);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "Đóng";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(557, 380);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(88, 23);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "Tên xét nghiệm";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(672, 380);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(159, 20);
            this.textBoxX1.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(181, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(203, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Mã bệnh nhân";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(12, 380);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(76, 23);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Mã bệnh nhân";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(402, 62);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(136, 23);
            this.labelX10.TabIndex = 8;
            this.labelX10.Text = "Mã bệnh nhân:";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(544, 62);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(203, 23);
            this.labelX11.TabIndex = 8;
            this.labelX11.Text = "Mã bệnh nhân";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(64, 125);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(301, 34);
            this.labelX12.TabIndex = 8;
            this.labelX12.Text = "Thông tin cận lâm sàng";
            // 
            // frmChiDinhCLS
            // 
            this.ClientSize = new System.Drawing.Size(868, 512);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.txtBacSi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.txtPhongKham);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grvChiDinhCLS);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmChiDinhCLS";
            this.Text = "CHỈ ĐỊNH CẬN LÂM SÀNG";
            this.Load += new System.EventHandler(this.frmChiDinhCLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvChiDinhCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grvChiDinhCLS;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaBN;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBacSi;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhongKham;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBS;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
    }
}