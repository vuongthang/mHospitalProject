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
    public class ChiTietCanLamSangDAL
    {
        ConnectionDB ConnectionDB = new ConnectionDB();

        public bool ChiDinhCLSInsert(ChiTietCanLamSangEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiDinhCLSInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaChiTietCanLamSang", obj.MaChiTietCanLamSang));
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", obj.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@MaPhongKham", obj.MaPhongKham));
                cmd.Parameters.Add(new SqlParameter("@TenXetNghiem", obj.TenXetNghiem));
                cmd.Parameters.Add(new SqlParameter("@ThoiGianThucHien", obj.ThoiGianThucHien));
                cmd.Parameters.Add(new SqlParameter("@BacSiChiDinh", obj.BacSiChiDinh));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool ChiDinhCLSUpDate(ChiTietCanLamSangEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiDinhCLSUpDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaChiTietCanLamSang", obj.MaChiTietCanLamSang));
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", obj.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@MaPhongKham", obj.MaPhongKham));
                cmd.Parameters.Add(new SqlParameter("@TenXetNghiem", obj.TenXetNghiem));
                cmd.Parameters.Add(new SqlParameter("@ThoiGianThucHien", obj.ThoiGianThucHien));
                cmd.Parameters.Add(new SqlParameter("@BacSiChiDinh", obj.BacSiChiDinh));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool ChiDinhCLSDelete(string Ma)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiDinhCLSDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaChiTietCanLamSang", Ma));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }
    }
}
