using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace mHospital
{
    public partial class frmMHospital : DevComponents.DotNetBar.Office2007Form
    {
        PhongKhamBLL pk = new PhongKhamBLL();



        #region Tiep don benh nhan

        BenhNhanBLL bn = new BenhNhanBLL();
        BenhNhanEntity TaoBN()
        {
            BenhNhanEntity obj = new BenhNhanEntity();
            obj.MaBenhNhan = txtMaBN.Text;
            obj.TenBenhNhan = txtTenBN.Text;
            obj.CMND = txtCMND.Text;
            obj.NgaySinh = dtNgaySinh.Value;
            obj.DiaChi = txtDiaChi.Text;
            obj.SDT = txtSDT.Text;
            obj.GioiTinh = txtGioiTinh.Text;
            obj.MaPhongKham = ((PhongKhamEntity)cbbPhongKham.SelectedItem).MaPhongKham;
            return obj;
        }

        void LoadGridTiepNhanBN()
        {
            dgvBenhNhan.DataSource = bn.BenhNhanSelectAll();
        }

        private void btnTiepNhanBN_Click(object sender, EventArgs e)
        {
            if (bn.BenhNhanInsert(TaoBN()))
            {
                MessageBox.Show("Thêm thành công bệnh nhân: " + txtTenBN.Text);
                LoadGridTiepNhanBN();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm bệnh nhân!");
            }
        }

        private void txtSearchBN_TextChanged(object sender, EventArgs e)
        {
            BenhNhanEntity obj = new BenhNhanEntity();
            //obj.MaBenhNhan = txtSearchBN.Text;
            obj.TenBenhNhan = txtSearchBN.Text;
            dgvBenhNhan.DataSource = bn.BenhNhanSearch(obj);
        }

        #endregion

        #region Khám Bệnh

        KhamBenhBLL kb = new KhamBenhBLL();
        void LoadGridChuaKham()
        {
            dgvBNChuaKham.DataSource = bn.BenhNhanSelectByFlag();
        }

        void LoadGridBNDangKham()
        {
            dgvBNDangKham.DataSource = kb.BNDangKhamSelect();
        }

        private void txtSearchBN1_TextChanged(object sender, EventArgs e)
        {
            BenhNhanEntity obj = new BenhNhanEntity();
            obj.TenBenhNhan = txtSearchBN1.Text;
            dgvBNChuaKham.DataSource = bn.BenhNhanSearch1(obj);
        }

        private void txtSearchBN2_TextChanged(object sender, EventArgs e)
        {
            string temp;
            temp = txtSearchBN2.Text;
            dgvBNDangKham.DataSource = kb.KhamBenhSearch(temp);
        }

        private void btnKhamBenh1_Click(object sender, EventArgs e)
        {
            int index = dgvBNChuaKham.SelectedRows[0].Index;
            string MaBN = dgvBNChuaKham.Rows[index].Cells["clmMaBN1"].Value.ToString();
            frmKhamBenh frmKhamBenh = new frmKhamBenh(MaBN);
            frmKhamBenh.ShowDialog();
        }

        private void btnCapNhatKQ_Click(object sender, EventArgs e)
        {
            int flag = 1;
            int index = dgvBNDangKham.SelectedRows[0].Index;
            string MaBN = dgvBNDangKham.Rows[index].Cells["clmMaBN2"].Value.ToString();
            frmKhamBenh frmKhamBenh = new frmKhamBenh(MaBN, flag);
            frmKhamBenh.ShowDialog();
        }

        #endregion

        #region Form Events

        public frmMHospital()
        {
            InitializeComponent();
        }
        private void frmMHospital_Load(object sender, EventArgs e)
        {
            tabControl.Tabs.Clear();
            //tabControl.Tabs.Add(tabTiepNhanBN);
            //dgvBenhNhan.DataSource = bn.BenhNhanSelectAll();
        }
        
        // Method close
        void flogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // User manual
        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("helpMHospital.chm");
        }

        // About for software
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.ShowDialog();
        }

        #endregion

        #region Xu ly tab

        //kiem tra tab
        private bool KiemTraTenTabConTrol(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Name == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void btTiepNhanBN_Click(object sender, EventArgs e)
        {
            LoadGridTiepNhanBN();
            LoadCbbPhongKham();
            if (KiemTraTenTabConTrol("tabTiepNhanBN") == false)
            {
                tabControl.Tabs.Add(tabTiepNhanBN);
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            LoadGridChuaKham();
            LoadGridBNDangKham();
            if (KiemTraTenTabConTrol("tabKhamBenh") == false)
            {
                tabControl.Tabs.Add(tabKhamBenh);
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
        }

        private void btnCLS_Click(object sender, EventArgs e)
        {
            //Todo - Load du lieu vao gridview
            if (KiemTraTenTabConTrol("tabCLS") == false)
            {
                tabControl.Tabs.Add(tabCLS);
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
        }

        private void btnQLThuoc_Click(object sender, EventArgs e)
        {
            //Todo - Load du lieu vao gridview
            if (KiemTraTenTabConTrol("tabThuoc") == false)
            {
                tabControl.Tabs.Add(tabThuoc);
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
        }

        private void btnVienPhi_Click(object sender, EventArgs e)
        {
            //Todo - Load du lieu vao gridview
            if (KiemTraTenTabConTrol("tabVienPhi") == false)
            {
                tabControl.Tabs.Add(tabVienPhi);
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
        }

        private void tabControl_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            //if (MessageBox.Show("Bạn có chắc chắn muốn đóng form?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            // return;
            // else
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }

        #endregion

        #region Xu ly Combobox

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

        #endregion








    }
}
