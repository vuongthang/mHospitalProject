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
    public partial class frmKetQuaCLS : DevComponents.DotNetBar.Office2007Form
    {
        string ma;
        ChiTietCanLamSangBLL bll = new ChiTietCanLamSangBLL();
        public frmKetQuaCLS(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }

        private void frmKetQuaCLS_Load(object sender, EventArgs e)
        {
            LoadLabel();
            LoadGridKqCLS();
        }
        void LoadLabel()
        {
            lblMaCLS.Text = this.ma;
            lblMaBN.Text = bll.KetQuaCLSSelectByID(ma).Rows[0]["MaBenhNhan"].ToString();
            lblTenBN.Text = bll.KetQuaCLSSelectByID(ma).Rows[0]["TenBenhNhan"].ToString();
            lblTenPhong.Text = bll.KetQuaCLSSelectByID(ma).Rows[0]["TenPhongKham"].ToString();
            lblBacSiChiDinh.Text = bll.KetQuaCLSSelectByID(ma).Rows[0]["BacSiChiDinh"].ToString();
            lblTenXN.Text = bll.KetQuaCLSSelectByID(ma).Rows[0]["TenXetNghiem"].ToString();
            lblNgayThucHien.Text = bll.KetQuaCLSSelectByID(ma).Rows[0]["NgayThucHien"].ToString();
        }

        void LoadGridKqCLS()
        {
            dgvKQ_CLS.DataSource = bll.KetQuaCLSSelectAll();
        }

        ChiTietCanLamSangEntites NewCLS()
        {
            ChiTietCanLamSangEntites obj = new ChiTietCanLamSangEntites();
            obj.MaChiTietCanLamSang = lblMaCLS.Text;
            obj.BacSiThucHien = txtBacSiThucHien.Text;
            obj.NhanVienNhapLieu = txtNguoiNhap.Text;
            obj.ThoiGianLayMau = dtNgayLayMau.Value;
            obj.ThoiGianTraKQ = dtNgayKQ.Value;
            obj.KetQuaCLS = txtKetQua.Text;
            return obj;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string txtMaCLS = lblMaCLS.Text;
            if (bll.ChiTietCanLamSangUpDate(NewCLS()))
            {
                MessageBox.Show("Lưu thành công!");
                LoadGridKqCLS();
            }
            else
            {
                MessageBox.Show("Lỗi không thể lưu thông tin!");
            }
        }

        private void dgvKQ_CLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex != -1)
            {
                lblMaCLS.Text = dgvKQ_CLS.Rows[RowIndex].Cells["maCLS"].Value.ToString();
                lblMaBN.Text = dgvKQ_CLS.Rows[RowIndex].Cells["maBN"].Value.ToString();
                lblTenBN.Text = dgvKQ_CLS.Rows[RowIndex].Cells["hoten"].Value.ToString();
                lblTenPhong.Text = dgvKQ_CLS.Rows[RowIndex].Cells["phong"].Value.ToString();
                lblTenXN.Text = dgvKQ_CLS.Rows[RowIndex].Cells["tenXN"].Value.ToString();
                lblNgayThucHien.Text = dgvKQ_CLS.Rows[RowIndex].Cells["ngayTH"].Value.ToString();
                lblBacSiChiDinh.Text = dgvKQ_CLS.Rows[RowIndex].Cells["bscd"].Value.ToString();
                txtBacSiThucHien.Text = dgvKQ_CLS.Rows[RowIndex].Cells["bsth"].Value.ToString();
                txtKetQua.Text = dgvKQ_CLS.Rows[RowIndex].Cells["kq"].Value.ToString();
                txtNguoiNhap.Text = dgvKQ_CLS.Rows[RowIndex].Cells["ngNhap"].Value.ToString();
                dtNgayKQ.Value = DateTime.Parse(dgvKQ_CLS.Rows[RowIndex].Cells["ngayKQ"].Value.ToString());
                dtNgayLayMau.Value = DateTime.Parse(dgvKQ_CLS.Rows[RowIndex].Cells["ngayLM"].Value.ToString());
            }
        }

        private void btnChiTietKQ_Click(object sender, EventArgs e)
        {
            int index = dgvKQ_CLS.SelectedRows[0].Index;
            string maCLS = dgvKQ_CLS.Rows[index].Cells["maCLS"].Value.ToString();
            frmChiTietKetQuaCLS frm = new frmChiTietKetQuaCLS(maCLS);
            frm.ShowDialog();
        }

    }
}
