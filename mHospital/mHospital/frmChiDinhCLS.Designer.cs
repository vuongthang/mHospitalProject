namespace mHospital
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
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMaBN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBacSi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEnd = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.maCLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiDinhCLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.grvChiDinhCLS.Location = new System.Drawing.Point(384, 211);
            this.grvChiDinhCLS.Name = "grvChiDinhCLS";
            this.grvChiDinhCLS.RowHeadersVisible = false;
            this.grvChiDinhCLS.Size = new System.Drawing.Size(502, 176);
            this.grvChiDinhCLS.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(20, 204);
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
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(9, 57);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(111, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Họ và tên: ";
            // 
            // txtMaBN
            // 
            // 
            // 
            // 
            this.txtMaBN.Border.Class = "TextBoxBorder";
            this.txtMaBN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaBN.Location = new System.Drawing.Point(129, 26);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(159, 20);
            this.txtMaBN.TabIndex = 9;
            // 
            // txtBacSi
            // 
            // 
            // 
            // 
            this.txtBacSi.Border.Class = "TextBoxBorder";
            this.txtBacSi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBacSi.Location = new System.Drawing.Point(129, 142);
            this.txtBacSi.Name = "txtBacSi";
            this.txtBacSi.Size = new System.Drawing.Size(159, 20);
            this.txtBacSi.TabIndex = 9;
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
            this.dateTimeInput.Location = new System.Drawing.Point(129, 110);
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
            this.btnEdit.Location = new System.Drawing.Point(137, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(254, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            // 
            // btnEnd
            // 
            this.btnEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnd.Location = new System.Drawing.Point(783, 463);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(89, 37);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "Đóng";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(129, 82);
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
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(137, 57);
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
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(6, 23);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(106, 23);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Mã cận lâm sàng:";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(9, 28);
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
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(151, 28);
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
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(385, 171);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(301, 34);
            this.labelX12.TabIndex = 8;
            this.labelX12.Text = "Thông tin cận lâm sàng";
            // 
            // maCLS
            // 
            this.maCLS.HeaderText = "Mã cận lâm sàng";
            this.maCLS.Name = "maCLS";
            // 
            // tenPhongKham
            // 
            this.tenPhongKham.HeaderText = "Tên phòng khám";
            this.tenPhongKham.Name = "tenPhongKham";
            this.tenPhongKham.Width = 150;
            // 
            // tenXN
            // 
            this.tenXN.HeaderText = "Tên xét nghiệm";
            this.tenXN.Name = "tenXN";
            this.tenXN.Width = 150;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX11);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 106);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxEx1);
            this.groupBox2.Controls.Add(this.txtMaBN);
            this.groupBox2.Controls.Add(this.txtBacSi);
            this.groupBox2.Controls.Add(this.dateTimeInput);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.labelX16);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.labelX15);
            this.groupBox2.Controls.Add(this.labelX14);
            this.groupBox2.Controls.Add(this.labelX13);
            this.groupBox2.Controls.Add(this.labelX9);
            this.groupBox2.Controls.Add(this.textBoxX1);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 247);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(6, 52);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(106, 23);
            this.labelX13.TabIndex = 8;
            this.labelX13.Text = "Phòng khám:";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(129, 54);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(159, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 10;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(6, 81);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(106, 23);
            this.labelX14.TabIndex = 8;
            this.labelX14.Text = "Tên xét nghiệm:";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(6, 110);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(114, 23);
            this.labelX15.TabIndex = 8;
            this.labelX15.Text = "Thời gian thực hiện:";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(6, 139);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(114, 23);
            this.labelX16.TabIndex = 8;
            this.labelX16.Text = "Bác sĩ chỉ định:";
            // 
            // frmChiDinhCLS
            // 
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.grvChiDinhCLS);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmChiDinhCLS";
            this.Text = "CHỈ ĐỊNH CẬN LÂM SÀNG";
            this.Load += new System.EventHandler(this.frmChiDinhCLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvChiDinhCLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grvChiDinhCLS;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaBN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBacSi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnEnd;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
    }
}