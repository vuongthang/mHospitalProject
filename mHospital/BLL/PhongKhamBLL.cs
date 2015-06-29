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
    public class PhongKhamBLL
    {
        public DataTable PhongKhamSelectAll()
        {
            var pkDAL = new PhongKhamDAL();
            var dt = new DataTable();
            dt = pkDAL.PhongKhamSelectAll();
            return dt;
        }

        public DataTable PhongKhamSelect()
        {
            var pkDAL = new PhongKhamDAL();
            var dt = new DataTable();
            dt = pkDAL.PhongKhamSelect();
            return dt;
        }
    }
}
