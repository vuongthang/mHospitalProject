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
    public class DonThuocBLL
    {
        public bool DonThuocInsert(DonThuocEntites obj)
        {
            var dt = new DonThuocDAL();
            if (dt.DonThuocInsert(obj))
                return true;
            return false;
        }

        public bool DonThuocUpDate(DonThuocEntites obj)
        {
            var dt = new DonThuocDAL();
            if (dt.DonThuocUpDate(obj))
                return true;
            return false;
        }

        public bool KT_DonThuocBenhNhan(string MaBN)
        {
            var dt = new DonThuocDAL();
            if (dt.KT_DonThuocBenhNhan(MaBN))
                return true;
            return false;
        }

        public bool KT_MaDonThuoc(string Ma)
        {
            var dt = new DonThuocDAL();
            if (dt.KT_MaDonThuoc(Ma))
                return true;
            return false;
        }

        public DataTable DonThuocSelectAll()
        {
            var vardt = new DonThuocDAL();
            var dt = new DataTable();
            dt = vardt.DonThuocSelectAll();
            return dt;
        }

        public DataTable DonThuocSelectByMaBN(string MaBN)
        {
            var vardt = new DonThuocDAL();
            var dt = new DataTable();
            dt = vardt.DonThuocSelectByMaBN(MaBN);
            return dt;
        }
    }
}
