using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using BLL;

namespace BLL
{
    public class StaffBLL
    {
        public bool insert(string id , string tenNV, string tuoi, string sodt, string password)
        {
            Staff staff = new Staff(id ,tenNV, tuoi, sodt,  password);
            string query = "INSERT INTO tblStaff VALUES(@tenNV, @tuoi, @SDT, @password)";
            StaffDAL staffDAL = new StaffDAL();                               
            staffDAL.Command(staff, query);

            RegisterBLL registerBLL = new RegisterBLL();
            registerBLL.regiterAccount(tenNV,password);
            return true;
        }

        public bool update(string id, string tenNV, string tuoi, string sodt, string password)
        {
            Staff staff = new Staff(id, tenNV, tuoi, sodt, password);
            string query = "UPDATE tblStaff" +
                " SET tenNV = @tenNV, tuoi = @tuoi, SDT = @SDT, password = @password" +
                " WHERE idNV = @idNV";
            StaffDAL staffDAL = new StaffDAL();
            if (staffDAL.Command(staff, query))
            {
                RegisterBLL registerBLL = new RegisterBLL();
                registerBLL.updateAccount( tenNV, password);
                return true;
            }

            return false;
        }

        public bool delete(string tenNV)
        {
            Staff staff = new Staff("",tenNV, "", "", "");
            string query = "DELETE FROM tblStaff WHERE tenNV = @tenNV";
            StaffDAL staffDAL = new StaffDAL();
            if (staffDAL.Command(staff, query))
            {
                return true;
            }

            return false;
        }

        public DataTable loadAll()
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblStaff";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }

        public DataTable selectCondition(string tenNV)
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblStaff WHERE tenNV like N'" + tenNV + "'";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }
    }
}
