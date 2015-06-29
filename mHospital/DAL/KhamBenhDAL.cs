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
    public class KhamBenhDAL
    {
        ConnectionDB ConnectionDB = new ConnectionDB();

        public DataTable BNDangKhamSelect()
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BNDangKhamSelect", conn);
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

        public DataTable BenhNhanSearch2(string temp)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanSearch2", conn);
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

        public bool KhamBenhInsert(KhamBenhEntity obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("KhamBenhInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MaKhamBenh", obj.MaKhamBenh));
                cmd.Parameters.Add(new SqlParameter("TenBacSi", obj.TenBacSi));
                cmd.Parameters.Add(new SqlParameter("MaBenhNhan", obj.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("TenNguoiNhapLieu", obj.TenNguoiNhapLieu));
                cmd.Parameters.Add(new SqlParameter("ThoiGianKham", obj.ThoiGianKham));
                cmd.Parameters.Add(new SqlParameter("ChuanDoan", obj.ChuanDoan));
                cmd.Parameters.Add(new SqlParameter("TrieuChung", obj.TrieuChung));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool KhamBenhUpDate(KhamBenhEntity obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanUpDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("MaKhamBenh", obj.MaKhamBenh));
                cmd.Parameters.Add(new SqlParameter("TenBacSi", obj.TenBacSi));
                cmd.Parameters.Add(new SqlParameter("MaBenhNhan", obj.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("TenNguoiNhapLieu", obj.TenNguoiNhapLieu));
                cmd.Parameters.Add(new SqlParameter("ThoiGianKham", obj.ThoiGianKham));
                cmd.Parameters.Add(new SqlParameter("ChuanDoan", obj.ChuanDoan));
                cmd.Parameters.Add(new SqlParameter("TrieuChung", obj.TrieuChung));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool KT_MaKhamBenh(string MaKhamBenh)
        {
            bool temp = false;
            SqlConnection conn = ConnectionDB.GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("KhamBenhSelectByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKhamBenh", MaKhamBenh));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (MaKhamBenh == reader.GetString(0))
                {
                    temp = true;
                    break;
                }
            }
            conn.Close();
            return temp;
        }

        public bool KT_MaBenhNhan(string MaBN, string MaKhamBenh)
        {
            bool temp = false;
            SqlConnection conn = ConnectionDB.GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("KhamBenhSelectByIdBN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", MaBN));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (MaKhamBenh == reader.GetString(0) && MaBN == reader.GetString(1))
                {
                    temp = true;
                    break;
                }
            }
            conn.Close();
            return temp;
        }

        public DataTable KhamBenhSelectByIdBN(string temp)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("KhamBenhSelectByIdBN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", temp));
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
