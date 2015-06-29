using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PhongKhamEntity
    {
        private string _MaPhongKham;
        private string _TenPhongKham;
        private string _Flag;
        public string MaPhongKham
        {
            get { return _MaPhongKham; }
            set { _MaPhongKham = value; }
        }

        public string TenPhongKham
        {
            get { return _TenPhongKham; }
            set { _TenPhongKham = value; }
        }

        public string Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }
    }
}
