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

        public DataTable ChiDinhCLSSelectByMaBN(string MaBN)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiDinhCLSSelectByMaBN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", MaBN));
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

        public DataTable ChiTietCanLamSangSelectAll()
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiTietCanLamSangSelectAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable CanLamSangSelectByFlag(string flag)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CanLamSangSelectByFlag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TrangThai", flag));
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

        public DataTable CanLamSangSearch(string temp)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CanLamSangSearch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@temp", temp));
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

        public DataTable CanLamSangCheckSearch(string temp, string stt)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CanLamSangCheckSearch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@temp", temp));
                cmd.Parameters.Add(new SqlParameter("@stt", stt));
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
