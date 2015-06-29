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
    }
}
