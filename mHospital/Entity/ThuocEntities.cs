using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ThuocEntites
    {
        private string _MaThuoc;
        private string _TenThuoc;
        private string _SoLuong;
        private string _HanSuDung;
        private string _CachSuDung;
        private int _GiaThuoc;
        public string MaThuoc
        {
            get { return _MaThuoc; }
            set { _MaThuoc = value; }
        }

        public string TenThuoc
        {
            get { return _TenThuoc; }
            set { _TenThuoc = value; }
        }

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public string HanSuDung
        {
            get { return _HanSuDung; }
            set { _HanSuDung = value; }
        }

        public string CachSuDung
        {
            get { return _CachSuDung; }
            set { _CachSuDung = value; }
        }

        public int GiaThuoc
        {
            get { return _GiaThuoc; }
            set { _GiaThuoc = value; }
        }

    }

}
