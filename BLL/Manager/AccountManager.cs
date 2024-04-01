using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class AccountManager
    {
        private AccountRepository accountDAL;

        public AccountManager()
        {
            accountDAL = new AccountRepository();
        }
        public bool LoginAccount(string username, string pwd)
        {
            return accountDAL.LoginAccount(username, pwd);
        }
        public bool checkAdmin(string username)
        {
            return accountDAL.checkAdmin(username);
        }
        public DataTable GetAccount()
        {
            return accountDAL.GetAccount();
        }
        public bool InsertAccount(string username, string pwd, int role)
        {
            return accountDAL.InsertAccount(username, pwd, role);
        }
        public bool DeleteAccount(string username)
        {
            return accountDAL.DeleteAccount(username);
        }
        public bool UpdateAccount(string username, string pwd, int role, string status)
        {
            return accountDAL.UpdateAccount(username, pwd, role, status);
        }
        public int GetRoleIdByName(string roleName)
        {
            return accountDAL.GetRoleIdByName(roleName);
        }
        public DataTable GetRoleName()
        {
            return accountDAL.GetRoleName();
        }
    }

}
