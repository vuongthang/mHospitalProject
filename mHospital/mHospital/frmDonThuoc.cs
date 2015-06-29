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
    public partial class frmDonThuoc : DevComponents.DotNetBar.Office2007Form
    {
        string maBN;
        DonThuocBLL dt = new DonThuocBLL();
        ThuocBLL t = new ThuocBLL();
        ChiTietDonThuocBLL ct = new ChiTietDonThuocBLL();

        public frmDonThuoc(string maBN)
        {
            InitializeComponent();
            this.maBN = maBN;
        }

        private void frmDonThuoc_Load(object sender, EventArgs e)
        {
            if (dt.KT_DonThuocBenhNhan(this.maBN))
            {
                LoadLabel();
                LoadTextBox();
                AutoCompleteText();
                LoadGrid();
            }
            else
            {
                LoadLabel();
                AutoCompleteText();
                LoadGrid();
            }
        }

        void LoadLabel()
        {
            BenhNhanBLL bn = new BenhNhanBLL();
            lblMaBN.Text = this.maBN;
            lblTenBN.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["TenBenhNhan"].ToString();
            lblDiaChi.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["DiaChi"].ToString();
            lblNgaySinh.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["NgaySinh"].ToString();
            lblGioiTinh.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["GioiTinh"].ToString();
        }

        void LoadTextBox()
        {
            txtMaDonThuoc.Text = dt.DonThuocSelectByMaBN(this.maBN).Rows[0]["MaDonThuoc"].ToString();
            txtBacSi.Text = dt.DonThuocSelectByMaBN(this.maBN).Rows[0]["TenBacSiKeDon"].ToString();
            dtNgayThang.Value = DateTime.Parse(dt.DonThuocSelectByMaBN(this.maBN).Rows[0]["NgayLapDonThuoc"].ToString());
            txtNoiDung.Text = dt.DonThuocSelectByMaBN(this.maBN).Rows[0]["NoiDungDonThuoc"].ToString();
            txtGhiChu.Text = dt.DonThuocSelectByMaBN(this.maBN).Rows[0]["GhiChu"].ToString();
        }

        DonThuocEntites NewDonThuoc()
        {
            DonThuocEntites obj = new DonThuocEntites();
            obj.MaDonThuoc = txtMaDonThuoc.Text;
            obj.MaBenhNhan = lblMaBN.Text;
            obj.TenBacSiKeDon = txtBacSi.Text;
            obj.NgayLapDonThuoc = dtNgayThang.Value;
            obj.NoiDungDonThuoc = txtNoiDung.Text;
            obj.GhiChu = txtGhiChu.Text;
            return obj;
        }

        ChiTietDonThuocEntites NewChiTiet()
        {
            ChiTietDonThuocEntites obj = new ChiTietDonThuocEntites();
            obj.SoLuongThuoc = txtSoLuong.Text;
            obj.LieuDung = txtLieuDung.Text;
            obj.MaThuoc = t.ThuocSelectMaThuoc(txtTenThuoc.Text).Rows[0]["MaThuoc"].ToString();
            obj.MaDonThuoc = txtMaDonThuoc.Text;
            return obj;
        }

        void AutoCompleteText()
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            for (int i = 0; i < t.ThuocSelectTop5(txtTenThuoc.Text).Rows.Count; i++)
            {
                col.Add(t.ThuocSelectTop5(txtTenThuoc.Text).Rows[i]["TenThuoc"].ToString());
            }
            txtTenThuoc.AutoCompleteCustomSource = col;

        }

        void LoadGrid()
        {
            dgvChiTietDT.DataSource = ct.ChiTietDonThuocSelectBN(maBN);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string temp = txtMaDonThuoc.Text;
            if (dt.KT_MaDonThuoc(temp))
            {
                if (dt.DonThuocUpDate(NewDonThuoc()))
                {
                    MessageBox.Show("Lưu thành công!");
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi không thể lưu thông tin!");
                }
            }
            else
            {
                if (dt.DonThuocInsert(NewDonThuoc()))
                {
                    MessageBox.Show("Lưu thành công!");
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi không thể lưu thông tin!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ct.ChiTietDonThuocInsert(NewChiTiet()))
            {
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi không thể lưu thông tin!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvChiTietDT.SelectedRows[0].Index;
            string MaChiTiet = dgvChiTietDT.Rows[index].Cells["clmMaChiTiet"].Value.ToString();
            if (ct.ChiTietDonThuocDelete(MaChiTiet))
            {
                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi không thể lưu thông tin!");
            }
        }
    }
}
