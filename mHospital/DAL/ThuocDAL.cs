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

        public bool ThuocInsert(ThuocEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThuocInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaThuoc", obj.MaThuoc));
                cmd.Parameters.Add(new SqlParameter("@TenThuoc", obj.TenThuoc));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", obj.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@HanSuDung", obj.HanSuDung));
                cmd.Parameters.Add(new SqlParameter("@CachSuDung", obj.CachSuDung));
                cmd.Parameters.Add(new SqlParameter("@GiaThuoc", obj.GiaThuoc));
                cmd.ExecuteNonQuery();
                conn.Close();             
            }
            catch { return false; }
            return true;
        }

        public bool ThuocUpDate(ThuocEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThuocUpDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaThuoc", obj.MaThuoc));
                cmd.Parameters.Add(new SqlParameter("@TenThuoc", obj.TenThuoc));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", obj.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@HanSuDung", obj.HanSuDung));
                cmd.Parameters.Add(new SqlParameter("@CachSuDung", obj.CachSuDung));
                cmd.Parameters.Add(new SqlParameter("@GiaThuoc", obj.GiaThuoc));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public DataTable ThuocSelectAll()
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThuocSelectAll", conn);
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

        public DataTable ThuocSearch(string t)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThuocSearch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaThuoc", t));            
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
