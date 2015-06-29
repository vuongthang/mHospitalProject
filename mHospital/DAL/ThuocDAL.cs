using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class ThuocDAL
    {
        ConnectionDB ConnectionDB = new ConnectionDB();

        public DataTable ThuocSelectTop5(string temp)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThuocSelectTop5", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenThuoc", temp));
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ThuocSelectMaThuoc(string temp)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThuocSelectMaThuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenThuoc", temp));
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
