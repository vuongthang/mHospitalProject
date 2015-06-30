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
    public class ThuocBLL
    {
        public DataTable ThuocSelectTop5(string temp)
        {
            var t = new ThuocDAL();
            var dt = new DataTable();
            dt = t.ThuocSelectTop5(temp);
            return dt;
        }

        public DataTable ThuocSelectMaThuoc(string temp)
        {
            var t = new ThuocDAL();
            var dt = new DataTable();
            dt = t.ThuocSelectMaThuoc(temp);
            return dt;
        }

        public DataTable ThuocSelectAll()
        {
            var dal = new ThuocDAL();
            var dt = new DataTable();
            dt = dal.ThuocSelectAll();
            return dt;
        }

        public DataTable ThuocSearch(string t)
        {
            var dal = new ThuocDAL();
            var dt = new DataTable();
            dt = dal.ThuocSearch(t);
            return dt;
        }

        public bool ThuocInsert(ThuocEntites obj)
        {
            var dal = new ThuocDAL();
            if (dal.ThuocInsert(obj))
                return true;
            return false;
        }

        public bool ThuocUpdate(ThuocEntites obj)
        {
            var dal = new ThuocDAL();
            if (dal.ThuocUpDate(obj))
                return true;
            return false;
        }
    }
}
