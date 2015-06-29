﻿using System;
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
    }
}
