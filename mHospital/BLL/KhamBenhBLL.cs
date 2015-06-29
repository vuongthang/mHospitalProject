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
    public class KhamBenhBLL
    {
        public DataTable BNDangKhamSelect()
        {
            var khDAL = new KhamBenhDAL();
            var dt = new DataTable();
            dt = khDAL.BNDangKhamSelect();
            return dt;
        }

        public DataTable KhamBenhSearch(string temp)
        {
            var khDAL = new KhamBenhDAL();
            var dt = new DataTable();
            dt = khDAL.BenhNhanSearch2(temp);
            return dt;
        }

        public bool KhamBenhInsert(KhamBenhEntity obj)
        {
            var khDAL = new KhamBenhDAL();
            if (khDAL.KhamBenhInsert(obj))
                return true;
            return false;
        }

        public bool KhamBenhUpDate(KhamBenhEntity obj)
        {
            var khDAL = new KhamBenhDAL();
            if (khDAL.KhamBenhUpDate(obj))
                return true;
            return false;
        }

        public bool KT_MaBenhNhan(string MaBN, string MaKhamBenh)
        {
            var khDAL = new KhamBenhDAL();
            if (khDAL.KT_MaBenhNhan(MaBN, MaKhamBenh))
                return true;
            return false;
        }

        public bool KT_MaKhamBenh(string MaKhamBenh)
        {
            var khDAL = new KhamBenhDAL();
            if (khDAL.KT_MaKhamBenh(MaKhamBenh))
                return true;
            return false;
            
        }

        public DataTable KhamBenhSelectByIdBN(string temp)
        {
            var khDAL = new KhamBenhDAL();
            var dt = new DataTable();
            dt = khDAL.KhamBenhSelectByIdBN(temp);
            return dt;
        }

    }
}
