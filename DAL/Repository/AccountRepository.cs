using System.Data.SqlClient;
using System.Data;

namespace DAL.Repository
{
    public class AccountRepository
    {
        //private string connectionString = "Data Source=.;Initial Catalog=QLCH;Integrated Security=True";
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True;Encrypt=False";
        public bool LoginAccount(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("LoginAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object data = command.ExecuteScalar();
                    return data != null;
                }
            }
        }
        public bool checkAdmin(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("checkAdmin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object data = command.ExecuteScalar();
                    return data != null;
                }
            }
        }
        public DataTable GetAccount()
        {
            DataTable account = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetAccounts", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(account);
                    }
                }
            }

            return account;
        }
        public bool InsertAccount(string username,string fullname ,string pwd, int role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsertAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@pwd", pwd);
                    command.Parameters.AddWithValue("@roleid", role);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
        public bool DeleteAccount(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("DeleteAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateAccount(string username, string fullname, string pwd, int role, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("UpdateAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@pwd", pwd);
                    command.Parameters.AddWithValue("@roleid", role);
                    command.Parameters.AddWithValue("@status", status);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
        public int GetRoleIdByName(string roleName)
        {
            int roleId = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT id FROM Role WHERE rolename = @roleName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@roleName", roleName);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            roleId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 
            }
            return roleId;
        }
        public DataTable GetRoleName()
        {
            DataTable rolenameTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT rolename FROM Role";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(rolenameTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 
            }

            return rolenameTable;
        }
        public bool checkpwd(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("checkpwd", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@pwd", password);

                    connection.Open();
                    object data = command.ExecuteScalar();
                    return data != null;
                }
            }
        }
    }

}
