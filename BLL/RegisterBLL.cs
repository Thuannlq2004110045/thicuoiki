using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class RegisterBLL
    {
        AccountDAL accountDAL;
        public bool checkAccount(string username, string password)
        {
            accountDAL = new AccountDAL();
            string query = "SELECT * FROM tblAccount";
            DataTable dataTable = accountDAL.Select(query);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                if (username.Equals(dataTable.Rows[i][1].ToString()))
                {
                    return false;
                }
            }
            regiterAccount(username, password);
            return true;
        }

        public bool regiterAccount(string username, string password)
        {

            Account account = new Account(username, password, "User");
            AccountDAL accountDAL = new AccountDAL();
            string query = "insert into tblAccount values(@username, @password, @typeUser)";

            accountDAL.Command(account, query);


            return true;

        }

        public bool updateAccount(string username, string password)
        {
            Account account = new Account(username, password, "User");
            string query = "UPDATE tblAccount" +
                " SET username = @username, password = @password" +
                " WHERE username = @username";
            AccountDAL accountDAL = new AccountDAL();
            if (accountDAL.Command(account, query))
            {
                return true;
            }

            return false;
        }
    }
}
