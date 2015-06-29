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
    public class DonThuocDAL
    {
        ConnectionDB ConnectionDB = new ConnectionDB();

        public bool DonThuocInsert(DonThuocEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DonThuocInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDonThuoc", obj.MaDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@TenBacSiKeDon", obj.TenBacSiKeDon));
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", obj.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@NgayLapDonThuoc", obj.NgayLapDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@NoiDungDonThuoc", obj.NoiDungDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@GhiChu", obj.GhiChu));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool DonThuocUpDate(DonThuocEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DonThuocUpDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDonThuoc", obj.MaDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@TenBacSiKeDon", obj.TenBacSiKeDon));
                cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", obj.MaBenhNhan));
                cmd.Parameters.Add(new SqlParameter("@NgayLapDonThuoc", obj.NgayLapDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@NoiDungDonThuoc", obj.NoiDungDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@GhiChu", obj.GhiChu));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool KT_DonThuocBenhNhan(string MaBN)
        {
            bool temp = false;
            SqlConnection conn = ConnectionDB.GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("KT_DonThuocBenhNhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaBenhNhan", MaBN));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (MaBN == reader.GetString(0))
                {
                    temp = true;
                    break;
                }
            }
            conn.Close();
            return temp;
        }

        //KT_MaDonThuoc
        public bool KT_MaDonThuoc(string MaDonThuoc)
        {
            bool temp = false;
            SqlConnection conn = ConnectionDB.GetConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("KT_MaDonThuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonThuoc", MaDonThuoc));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (MaDonThuoc == reader.GetString(0))
                {
                    temp = true;
                    break;
                }
            }
            conn.Close();
            return temp;
        }

        public DataTable DonThuocSelectAll()
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DonThuocSelectAll", conn);
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

        public DataTable DonThuocSelectByMaBN(string MaBN)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DonThuocSelectByMaBN", conn);
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

    }
}
