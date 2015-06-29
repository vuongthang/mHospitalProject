using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entity;

namespace mHospital
{
    public partial class frmKhamBenh : DevComponents.DotNetBar.Office2007Form
    {
        string maBN;
        int flag;
        KhamBenhBLL kb = new KhamBenhBLL();

        public frmKhamBenh(string maBN)
        {
            InitializeComponent();
            this.maBN = maBN;
        }

        public frmKhamBenh(string maBN, int flag)
        {
            InitializeComponent();
            this.maBN = maBN;
            this.flag = flag;
            LoadTextBox();
        }

        private void frmKhamBenh_Load(object sender, EventArgs e)
        {
            LoadLabel();
            LoadGridCLS();
        }

        void LoadLabel()
        {
            BenhNhanBLL bn = new BenhNhanBLL();
            lblMaBN.Text = this.maBN;
            lblTenBN.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["TenBenhNhan"].ToString();
            lblDiaChi.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["DiaChi"].ToString();
            lblNgaySinh.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["NgaySinh"].ToString();
            lblCMND.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["CMND"].ToString();
            lblGioiTinh.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["GioiTinh"].ToString();
            lblSDT.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["SDT"].ToString();
            lblPhongKham.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["TenPhongKham"].ToString();
        }

        void LoadTextBox()
        {
            txtMaKhamBenh.Text = kb.KhamBenhSelectByIdBN(maBN).Rows[0]["MaKhamBenh"].ToString();
            txtBacSiKham.Text = kb.KhamBenhSelectByIdBN(maBN).Rows[0]["TenBacSi"].ToString();
            txtTrieuChung.Text = kb.KhamBenhSelectByIdBN(maBN).Rows[0]["TrieuChung"].ToString();
            txtChuanDoan.Text = kb.KhamBenhSelectByIdBN(maBN).Rows[0]["ChuanDoan"].ToString();
            txtNguoiNhap.Text = kb.KhamBenhSelectByIdBN(maBN).Rows[0]["TenNguoiNhapLieu"].ToString();
            dtNgayKham.Value = DateTime.Parse(kb.KhamBenhSelectByIdBN(maBN).Rows[0]["NgayKham"].ToString());
        }

        void LoadGridCLS()
        {
            ChiTietCanLamSangBLL bll = new ChiTietCanLamSangBLL();
            dgvDvCLS.DataSource = bll.LoadCLS(maBN);
        }

        KhamBenhEntity NewKhamBenh()
        {
            KhamBenhEntity obj = new KhamBenhEntity();
            obj.MaKhamBenh = txtMaKhamBenh.Text;
            obj.MaBenhNhan = lblMaBN.Text;
            obj.TenBacSi = txtBacSiKham.Text;
            obj.ThoiGianKham = dtNgayKham.Value;
            obj.TrieuChung = txtTrieuChung.Text;
            obj.ChuanDoan = txtChuanDoan.Text;
            obj.TenNguoiNhapLieu = txtNguoiNhap.Text;
            return obj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bn = lblMaBN.Text;
            string maKH = txtMaKhamBenh.Text;
            if (kb.KT_MaBenhNhan(bn, maKH))
            {
                if (kb.KhamBenhUpDate(NewKhamBenh()))
                {
                    MessageBox.Show("Lưu thành công bệnh nhân: " + lblTenBN.Text);
                }
                else
                {
                    MessageBox.Show("Lỗi không thể lưu thông tin!");
                }
            }
            else
            {
                if (kb.KhamBenhInsert(NewKhamBenh()))
                {
                    MessageBox.Show("Lưu thành công bệnh nhân: " + lblTenBN.Text);
                }
                else
                {
                    MessageBox.Show("Lỗi không thể lưu thông tin!");
                }
            }
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            string MaBN = lblMaBN.Text;
            frmDonThuoc frm = new frmDonThuoc(MaBN);
            frm.ShowDialog();
        }

        private void btnChiDinhCLS_Click(object sender, EventArgs e)
        {
            string MaBN = lblMaBN.Text;
            frmChiDinhCLS frm = new frmChiDinhCLS(MaBN);
            frm.ShowDialog();
        }

        private void dgvDvCLS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dgvDvCLS.SelectedRows[0].Index;
            string maCLS = dgvDvCLS.Rows[index].Cells["clmMaCLS"].Value.ToString();
            frmChiTietKetQuaCLS frm = new frmChiTietKetQuaCLS(maCLS);
            frm.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGridCLS();
        }
    }
}
