using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class StaffDAL
    {
        private SqlConnection conn = null;
        private SqlCommand cmd;
        public bool Command(Staff staff, string query)
        {
            conn = Connection.getConnection();

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idNV", SqlDbType.NVarChar).Value = staff.Id;
                cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = staff.TenNV;
                cmd.Parameters.Add("@tuoi", SqlDbType.NVarChar).Value = staff.Tuoi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = staff.Sodt;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = staff.Password;
                
                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
    }
}
