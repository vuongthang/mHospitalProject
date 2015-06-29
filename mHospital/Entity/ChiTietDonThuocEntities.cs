using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ChiTietDonThuocEntites
    {
        private int _MaChiTietDonThuoc;
        private string _MaDonThuoc;
        private string _MaThuoc;
        private string _LieuDung;
        private string _SoLuongThuoc;
        public int MaChiTietDonThuoc
        {
            get { return _MaChiTietDonThuoc; }
            set { _MaChiTietDonThuoc = value; }
        }

        public string MaDonThuoc
        {
            get { return _MaDonThuoc; }
            set { _MaDonThuoc = value; }
        }

        public string MaThuoc
        {
            get { return _MaThuoc; }
            set { _MaThuoc = value; }
        }

        public string LieuDung
        {
            get { return _LieuDung; }
            set { _LieuDung = value; }
        }

        public string SoLuongThuoc
        {
            get { return _SoLuongThuoc; }
            set { _SoLuongThuoc = value; }
        }

    }

}
