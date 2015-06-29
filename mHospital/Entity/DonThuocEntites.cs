using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DonThuocEntites
    {
        private string _MaDonThuoc;
        private string _TenBacSiKeDon;
        private string _MaBenhNhan;
        private DateTime _NgayLapDonThuoc;
        private string _NoiDungDonThuoc;
        private string _GhiChu;
        public string MaDonThuoc
        {
            get { return _MaDonThuoc; }
            set { _MaDonThuoc = value; }
        }

        public string TenBacSiKeDon
        {
            get { return _TenBacSiKeDon; }
            set { _TenBacSiKeDon = value; }
        }

        public string MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }

        public DateTime NgayLapDonThuoc
        {
            get { return _NgayLapDonThuoc; }
            set { _NgayLapDonThuoc = value; }
        }

        public string NoiDungDonThuoc
        {
            get { return _NoiDungDonThuoc; }
            set { _NoiDungDonThuoc = value; }
        }

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

    }

}
