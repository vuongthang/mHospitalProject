using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class ConnectionDB
    {
       string ChuoiKetNoi = ConfigurationManager.ConnectionStrings["mHospitalConnectionString"].ConnectionString;

        public SqlConnection GetConnect()
        {
            return new SqlConnection(ChuoiKetNoi);
        }
    }
}
