using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace mHospital
{
    public partial class frmChiTietKetQuaCLS : DevComponents.DotNetBar.Office2007Form
    {
        string maCLS;
        ChiTietCanLamSangBLL bll = new ChiTietCanLamSangBLL();
        public frmChiTietKetQuaCLS(string id)
        {
            InitializeComponent();
            this.maCLS = id;
        }

        private void frmChiTietKetQuaCLS_Load(object sender, EventArgs e)
        {
            LoadLabel();
        }

        void LoadLabel()
        {
            lblMaCLS.Text = this.maCLS;
            lblMaBN.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["MaBenhNhan"].ToString();
            lblTenBN.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["TenBenhNhan"].ToString();
            lblTenPhong.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["TenPhongKham"].ToString();
            lblBacSiChiDinh.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["BacSiChiDinh"].ToString();
            lblTenXN.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["TenXetNghiem"].ToString();
            lblNgayThucHien.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["NgayThucHien"].ToString();
            lblBSThucHien.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["BacSiThucHien"].ToString();
            lblNgayLayMau.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["NgayLayMau"].ToString();
            lblNgayTraKQ.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["NgayTraKQ"].ToString();
            lblNguoiNhap.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["NhanVienNhapLieu"].ToString();
            txtKq.Text = bll.KetQuaCLSSelectByID(maCLS).Rows[0]["KetQuaCLS"].ToString();
        }
    }
}
