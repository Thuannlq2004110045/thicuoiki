using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class Connection
    {
        public static SqlConnection getConnection()
        {
       
             string strConnection = @"Data Source=MSI;Initial Catalog=QuanLySieuThi;User ID=sa;Password=123";
             return new SqlConnection(strConnection);

        }
    }
}
