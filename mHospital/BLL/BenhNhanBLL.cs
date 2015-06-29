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
    public class BenhNhanBLL
    {
        public DataTable BenhNhanSelectAll()
        {
            var bnDAL = new BenhNhanDAL();
            var dt = new DataTable();
            dt = bnDAL.BenhNhanSelectAll();
            return dt;
        }

        public DataTable BenhNhanSelectByFlag()
        {
            var bnDAL = new BenhNhanDAL();
            var dt = new DataTable();
            dt = bnDAL.BenhNhanSelectByFlag();
            return dt;
        }

        public bool BenhNhanInsert(BenhNhanEntity bn)
        {
            var bnDAL = new BenhNhanDAL();
            var i = bnDAL.BenhNhanInsert(bn);
            if (i == 1)
                return true;
            else
                return false;
        }

        public bool BenhNhanUpDate(BenhNhanEntity bn)
        {
            var bnDAL = new BenhNhanDAL();
            var i = bnDAL.BenhNhanUpDate(bn);
            if (i == 1)
                return true;
            else
                return false;
        }

        public DataTable BenhNhanSelectByID(string id)
        {
            var bnDAL = new BenhNhanDAL();
            var dt = new DataTable();
            dt = bnDAL.BenhNhanSelectByID(id);
            return dt;
        }

        public DataTable BenhNhanSearch(BenhNhanEntity bn)
        {
            var bnDAL = new BenhNhanDAL();
            var dt = new DataTable();
            dt = bnDAL.BenhNhanSearch(bn);
            return dt;
        }

        public DataTable BenhNhanSearch1(BenhNhanEntity bn)
        {
            var bnDAL = new BenhNhanDAL();
            var dt = new DataTable();
            dt = bnDAL.BenhNhanSearch1(bn);
            return dt;
        }
    }
}
