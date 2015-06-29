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
    public class ChiTietCanLamSangBLL
    {
        public bool ChiDinhCLSInsert(ChiTietCanLamSangEntites obj)
        {
            var dal = new ChiTietCanLamSangDAL();
            if (dal.ChiDinhCLSInsert(obj))
                return true;
            return false;
        }

        public bool ChiDinhCLSUpDate(ChiTietCanLamSangEntites obj)
        {
            var dal = new ChiTietCanLamSangDAL();
            if (dal.ChiDinhCLSUpDate(obj))
                return true;
            return false;
        }

        public bool ChiDinhCLSDelete(string Ma)
        {
            var dal = new ChiTietCanLamSangDAL();
            if (dal.ChiDinhCLSDelete(Ma))
                return true;
            return false;
        }

        public DataTable ChiDinhCLSSelectByMaBN(string maBN)
        {
            var dal = new ChiTietCanLamSangDAL();
            var dt = new DataTable();
            dt = dal.ChiDinhCLSSelectByMaBN(maBN);
            return dt;
        }

        public DataTable ChiTietCanLamSangSelectAll()
        {
            var dal = new ChiTietCanLamSangDAL();
            var dt = new DataTable();
            dt = dal.ChiTietCanLamSangSelectAll();
            return dt;
        }

        public DataTable CanLamSangSelectByFlag(string flag)
        {
            var dal = new ChiTietCanLamSangDAL();
            var dt = new DataTable();
            dt = dal.CanLamSangSelectByFlag(flag);
            return dt;
        }

        public DataTable CanLamSangSearch(string temp)
        {
            var dal = new ChiTietCanLamSangDAL();
            var dt = new DataTable();
            dt = dal.CanLamSangSearch(temp);
            return dt;
        }

        public DataTable CanLamSangCheckSearch(string temp, string stt)
        {
            var dal = new ChiTietCanLamSangDAL();
            var dt = new DataTable();
            dt = dal.CanLamSangCheckSearch(temp, stt);
            return dt;
        }
    }
}
