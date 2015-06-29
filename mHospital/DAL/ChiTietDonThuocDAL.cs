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
    public class ChiTietDonThuocDAL
    {
        ConnectionDB ConnectionDB = new ConnectionDB();

        public bool ChiTietDonThuocInsert(ChiTietDonThuocEntites obj)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiTietDonThuocInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDonThuoc", obj.MaDonThuoc));
                cmd.Parameters.Add(new SqlParameter("@MaThuoc", obj.MaThuoc));
                cmd.Parameters.Add(new SqlParameter("@LieuDung", obj.LieuDung));
                cmd.Parameters.Add(new SqlParameter("@SoLuongThuoc", obj.SoLuongThuoc));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public bool ChiTietDonThuocDelete(string Ma)
        {
            try
            {
                SqlConnection conn = ConnectionDB.GetConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiTietDonThuocDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaChiTietDonThuoc", Ma));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { return false; }
            return true;
        }

        public DataTable ChiTietDonThuocSelectBN(string MaBN)
        {
            SqlConnection conn = ConnectionDB.GetConnect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ChiTietDonThuocSelectBN", conn);
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
