using DAL.Repository;
using System.Data;
using System.Security.Cryptography;
using System.Text;

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
        public bool InsertAccount(string username, string fullname, string pwd, int role)
        {
            return accountDAL.InsertAccount(username, fullname, pwd, role);
        }
        public bool DeleteAccount(string username)
        {
            return accountDAL.DeleteAccount(username);
        }
        public bool UpdateAccount(string username, string fullname, int role, string status)
        {
            return accountDAL.UpdateAccount(username, fullname, role, status);
        }
        public bool UpdateInfo(string username, string fullname, string pwd)
        {
            return accountDAL.UpdateInfo(username, fullname, pwd);
        }
        public int GetRoleIdByName(string roleName)
        {
            return accountDAL.GetRoleIdByName(roleName);
        }
        public DataTable GetRoleName()
        {
            return accountDAL.GetRoleName();
        }
        public bool checkpwd(string username, string pwd)
        {
            return accountDAL.checkpwd(username, pwd);
        }
        public class textToMd5
        {
            public static string converText(string text)
            {
                MD5 md = MD5.Create();
                byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = md.ComputeHash(inputstr);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();

            }
        }
    }

}
