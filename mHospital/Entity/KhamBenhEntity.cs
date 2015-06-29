using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KhamBenhEntity
    {
        private string _MaKhamBenh;
        private string _TenBacSi;
        private string _MaBenhNhan;
        private string _TenNguoiNhapLieu;
        private string _ChiDinhCanLamSang;
        private string _ChiDinhDichVu;
        private string _MaDonThuoc;
        private DateTime _ThoiGianKham;
        private string _MaPhongKham;
        private string _ChuanDoan;
        private string _TrieuChung;
        private string _Flag;
        public string MaKhamBenh
        {
            get { return _MaKhamBenh; }
            set { _MaKhamBenh = value; }
        }

        public string TenBacSi
        {
            get { return _TenBacSi; }
            set { _TenBacSi = value; }
        }

        public string MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }

        public string TenNguoiNhapLieu
        {
            get { return _TenNguoiNhapLieu; }
            set { _TenNguoiNhapLieu = value; }
        }

        public string ChiDinhCanLamSang
        {
            get { return _ChiDinhCanLamSang; }
            set { _ChiDinhCanLamSang = value; }
        }

        public string ChiDinhDichVu
        {
            get { return _ChiDinhDichVu; }
            set { _ChiDinhDichVu = value; }
        }

        public string MaDonThuoc
        {
            get { return _MaDonThuoc; }
            set { _MaDonThuoc = value; }
        }

        public DateTime ThoiGianKham
        {
            get { return _ThoiGianKham; }
            set { _ThoiGianKham = value; }
        }

        public string MaPhongKham
        {
            get { return _MaPhongKham; }
            set { _MaPhongKham = value; }
        }

        public string ChuanDoan
        {
            get { return _ChuanDoan; }
            set { _ChuanDoan = value; }
        }

        public string TrieuChung
        {
            get { return _TrieuChung; }
            set { _TrieuChung = value; }
        }

        public string Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

    }

}
