using DAL.Repository;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using DAL.Entity;

namespace BLL.Manager
{
    public class AccountManager
    {
        private AccountRepository accountDAL;

        public AccountManager()
        {
            accountDAL = AccountRepository.Instance;
        }
        public bool LoginAccount(AccountEntity Entity)
        {
            return accountDAL.LoginAccount(Entity);
        }
        public bool checkAdmin(AccountEntity Entity)
        {
            return accountDAL.checkAdmin(Entity);
        }
        public bool checkUsername(AccountEntity Entity)
        {
            return accountDAL.checkUsername(Entity);
        }
        public DataTable GetAccount()
        {
            return accountDAL.GetAccount();
        }
        public bool InsertAccount(AccountEntity Entity)
        {
            return accountDAL.InsertAccount(Entity);
        }
        public bool DeleteAccount(AccountEntity Entity)
        {
            return accountDAL.DeleteAccount(Entity);
        }
        public bool UpdateAccount(AccountEntity Entity)
        {
            return accountDAL.UpdateAccount(Entity);
        }
        public bool UpdateInfo(AccountEntity Entity)
        {
            return accountDAL.UpdateInfo(Entity);
        }
        public int GetRoleIdByName(AccountEntity Entity)
        {
            return accountDAL.GetRoleIdByName(Entity);
        }
        public DataTable GetRoleName()
        {
            return accountDAL.GetRoleName();
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
