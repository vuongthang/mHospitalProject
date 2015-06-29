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
    public class BenhNhanDAL
    {
        ConnectionDB ConnectionDB = new ConnectionDB();
        public DataTable BenhNhanSelectAll()
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanSelectAll", conn);
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

        public DataTable BenhNhanSelectByFlag()
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanSelectByFlag", conn);
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

        public int BenhNhanInsert(BenhNhanEntity bn)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            int i = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", bn.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@TenBenhNhan", bn.TenBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@CMND", bn.CMND));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", bn.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", bn.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", bn.SDT));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", bn.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@MaPhongKham", bn.MaPhongKham));
                cmd.ExecuteNonQuery();
                i = 1;
            }
            catch
            {
                i = 0;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return i;
        }
        public int BenhNhanUpDate(BenhNhanEntity bn)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            int i = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanUpDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", bn.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@TenBenhNhan", bn.TenBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@CMND", bn.CMND));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", bn.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", bn.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", bn.SDT));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", bn.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@MaPhongKham", bn.MaPhongKham));
                cmd.ExecuteNonQuery();
                i = 1;
            }
            catch
            {
                i = 0;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return i;
        }

        public DataTable BenhNhanSearch(BenhNhanEntity bn)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanSearch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@temp", bn.TenBenhNhan));
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

        public DataTable BenhNhanSelectByID(string id)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanSelectByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", id));
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

        public DataTable BenhNhanSearch1(BenhNhanEntity bn)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("BenhNhanSearch1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@temp", bn.TenBenhNhan));
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
