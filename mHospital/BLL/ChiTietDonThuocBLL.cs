using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Entity;

namespace BLL
{
    public class ChiTietDonThuocBLL
    {
        public bool ChiTietDonThuocInsert(ChiTietDonThuocEntites obj)
        {
            var dt = new ChiTietDonThuocDAL();
            if (dt.ChiTietDonThuocInsert(obj))
                return true;
            return false;
        }

        public bool ChiTietDonThuocDelete(string Ma)
        {
            var dt = new ChiTietDonThuocDAL();
            if (dt.ChiTietDonThuocDelete(Ma))
                return true;
            return false;
        }

        public DataTable ChiTietDonThuocSelectBN(string MaBN)
        {
            var ctdt = new ChiTietDonThuocDAL();
            var dt = new DataTable();
            dt = ctdt.ChiTietDonThuocSelectBN(MaBN);
            return dt;
        }
    }
}
