using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
using Entity;

namespace DAL
{
    public class BenhNhanDAL
    {
        public DataTable fnGetBenhNhanList(string myConnectionString)
        {
            var conn = new ConnectionDB(myConnectionString);
            var myTable = new DataTable();
            try
            {
                conn.CallStoredProcedureFromDB("spBenhNhanList");
                conn.Reader = conn.Command.ExecuteReader();               
                myTable.Columns.Add("MaBenhNhan", typeof(string));
                myTable.Columns.Add("TenBenhNhan", typeof(string));
                myTable.Columns.Add("CMND", typeof(string));
                myTable.Columns.Add("NgaySinh", typeof(string));
                myTable.Columns.Add("DiaChi", typeof(string));
                myTable.Columns.Add("SDT", typeof(string));
                myTable.Columns.Add("MaPhongKham", typeof(string));
                myTable.AcceptChanges();
                while (conn.Reader.Read())
                {
                    myTable.Rows.Add(new[]
                                     {
                                         conn.Reader["MaBenhNhan"].ToString(),
                                         conn.Reader["TenBenhNhan"].ToString(),
                                         conn.Reader["CMND"].ToString(),
                                         conn.Reader["NgaySinh"].ToString(),
                                         conn.Reader["DiaChi"].ToString(),
                                         conn.Reader["SDT"].ToString(),
                                         conn.Reader["MaPhongKham"].ToString()
                                     });
                }                
                return myTable;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.Connection.Close();
            }
        }

        public int fnDoInsertBenhNhan(string _strConn, BenhNhan bn)
        {
            var conn = new ConnectionDB(_strConn);
            int i = 0;
            try
            {
                conn.CallStoredProcedureFromDB("spBenhNhanInsert");
                conn.Command.Parameters.AddWithValue("@MaBenhNhan", bn.MaBenhNhan);
                conn.Command.Parameters.AddWithValue("@TenBenhNhan", bn.TenBenhNhan);
                conn.Command.Parameters.AddWithValue("@CMND", bn.CMND);
                conn.Command.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                conn.Command.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                conn.Command.Parameters.AddWithValue("@SDT", bn.SDT);
                conn.Command.Parameters.AddWithValue("@MaPhongKham", bn.MaPhongKham);               
                conn.Reader = conn.Command.ExecuteReader();
                i = 1;
            }
            catch
            {
                i = 0;
                throw;
            }
            finally
            {
                conn.Connection.Close();
            }
            return i;
        }

    }
}
