using System.Data;
using DAL.Entity;

namespace DAL.Repository
{
    public class AccountRepository
    {
        public static AccountRepository instance;
        public static AccountRepository Instance
        {
            get { if (instance == null) instance = new AccountRepository(); return instance; }
            private set { instance = value; }
        }
        private AccountRepository() { }
        public bool LoginAccount(AccountEntity Entity)
        {
            string query = "LoginAccount @Username , @Password ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Entity.username, Entity.pwd });
            return result.Rows.Count > 0;
        }
        public bool checkAdmin(AccountEntity Entity)
        {
            string query = "checkAdmin @Username ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Entity.username });
            return result.Rows.Count > 0;
        }
        public bool checkUsername(AccountEntity Entity)
        {
            string query = "select * from Account where username like @Username ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Entity.username });
            return result.Rows.Count > 0;
        }
        public DataTable GetAccount()
        {
            string query = "GetAccounts";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool InsertAccount(AccountEntity Entity)
        {
            string query = "InsertAccount @Username , @fullname , @pwd , @roleid";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Entity.username, Entity.fullname, Entity.pwd, Entity.role });
            return result > 0;
        }
        public bool DeleteAccount(AccountEntity Entity)
        {
            string query = "DeleteAccount @Username ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Entity.username });
            return result > 0;
        }
        public bool UpdateAccount(AccountEntity Entity)
        {
            string query = "UpdateAccount @Username , @fullname , @roleid , @status";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Entity.username, Entity.fullname, Entity.role, Entity.status });
            return result > 0;
        }
        public bool UpdateInfo(AccountEntity Entity)
        {
            string query = "UpdateInfo @Username , @fullname , @pwd ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Entity.username, Entity.fullname, Entity.pwd });
            return result > 0;
           
        }
        public int GetRoleIdByName(AccountEntity Entity)
        {
            int roleId = 0;
            try
            {
                string query = "SELECT id FROM Role WHERE rolename = @roleName";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { Entity.rolename });

                if (result != null && int.TryParse(result.ToString(), out int roleIdResult))
                {
                    roleId = roleIdResult;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ ghi log, thông báo lỗi
            }
            return roleId;
        }
        public DataTable GetRoleName()
        {
            DataTable roleNameTable = new DataTable();
            try
            {
                string query = "SELECT rolename FROM Role";
                DataProvider.Instance.FillDataTable(query, roleNameTable);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ ghi log, thông báo lỗi
            }
            return roleNameTable;
            
        }
    }

}
