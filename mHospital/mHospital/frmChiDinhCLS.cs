using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL;
using Entity;

namespace mHospital
{
    public partial class frmChiDinhCLS : DevComponents.DotNetBar.Office2007Form
    {
        string maBN;
        ChiTietCanLamSangBLL cls = new ChiTietCanLamSangBLL();
        PhongKhamBLL pk = new PhongKhamBLL();
        public frmChiDinhCLS(string maBN)
        {
            InitializeComponent();
            this.maBN = maBN;
        }

        private void frmChiDinhCLS_Load(object sender, EventArgs e)
        {
            LoadLabel();
            LoadCbbPhongKham();
            LoadGridCLS();
        }

        void LoadCbbPhongKham()
        {
            for (int i = 0; i < pk.PhongKhamSelect().Rows.Count; i++)
            {
                PhongKhamEntity obj = new PhongKhamEntity();
                obj.MaPhongKham = pk.PhongKhamSelect().Rows[i]["MaPhongKham"].ToString();
                obj.TenPhongKham = pk.PhongKhamSelect().Rows[i]["TenPhongKham"].ToString();
                cbbPhongKham.Items.Add(obj);
            }
            cbbPhongKham.DisplayMember = "TenPhongKham";
            cbbPhongKham.SelectedIndex = 0;
        }

        void LoadLabel()
        {
            BenhNhanBLL bn = new BenhNhanBLL();
            lblMaBN.Text = this.maBN;
            lblTenBN.Text = bn.BenhNhanSelectByID(maBN).Rows[0]["TenBenhNhan"].ToString();
        }

        void LoadGridCLS()
        {
            grvChiDinhCLS.DataSource = cls.ChiDinhCLSSelectByMaBN(this.maBN);
        }

        ChiTietCanLamSangEntites NewChiDinh()
        {
            ChiTietCanLamSangEntites obj = new ChiTietCanLamSangEntites();
            obj.MaBenhNhan = lblMaBN.Text;
            obj.MaChiTietCanLamSang = txtMaCLS.Text;
            obj.MaPhongKham = ((PhongKhamEntity)cbbPhongKham.SelectedItem).MaPhongKham;
            obj.ThoiGianThucHien = dtNgay.Value;
            obj.TenXetNghiem = txtTenXN.Text;
            obj.BacSiChiDinh = txtBacSi.Text;
            return obj;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cls.ChiDinhCLSInsert(NewChiDinh()))
            {
                MessageBox.Show("Thêm thành công!");
                LoadGridCLS();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm bệnh nhân!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cls.ChiDinhCLSUpDate(NewChiDinh()))
            {
                MessageBox.Show("Thêm thành công!");
                LoadGridCLS();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm bệnh nhân!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = grvChiDinhCLS.SelectedRows[0].Index;
            string maCLS = grvChiDinhCLS.Rows[index].Cells["maCLS"].Value.ToString();
            if (cls.ChiDinhCLSDelete(maCLS))
            {
                MessageBox.Show("Thêm thành công!");
                LoadGridCLS();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm bệnh nhân!");
            }
        }
    }
}