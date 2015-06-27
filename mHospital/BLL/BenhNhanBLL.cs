using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BLL
{
    public class BenhNhanBLL
    {
        public static DataTable GetBenhNhanList(string _strConnection)
        {
            var ds = new DataTable();
            var helper = new BenhNhanDAL();
            ds = helper.fnGetBenhNhanList(_strConnection);
            return ds;
        }

        public static bool InsertNewBenhNhan(string myConnectionString, BenhNhan obj)
        {
            var myDal = new BenhNhanDAL();
            var number = myDal.fnDoInsertBenhNhan(myConnectionString, obj);
            if (number == 1)
                return true;
            else
                return false;
        }
    }
}
