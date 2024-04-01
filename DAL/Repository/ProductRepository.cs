using System.Data.SqlClient;
using System.Data;

namespace DAL.Repository
{
    public class ProductRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=QLCH;Integrated Security=True";
        //private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True;Encrypt=False";
        public DataTable GetFoods()
        {
            DataTable foods = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetFoods", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(foods);
                    }
                }
            }

            return foods;
        }
        public bool DeleteFood(int foodID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("DeleteFood", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FoodID", foodID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool InsertFood(int foodId, string foodName, string unit, string price, int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsertFood", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FoodId", foodId);
                    command.Parameters.AddWithValue("@FoodName", foodName);
                    command.Parameters.AddWithValue("@Unit", unit);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

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
        public bool UpdateFood(int foodId, string newFoodName, string newUnit, string newPrice, int newCategoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("UpdateFood", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FoodId", foodId);
                    command.Parameters.AddWithValue("@NewFoodName", newFoodName);
                    command.Parameters.AddWithValue("@NewUnit", newUnit);
                    command.Parameters.AddWithValue("@NewPrice", newPrice);
                    command.Parameters.AddWithValue("@NewCategoryId", newCategoryId);

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
        public int GetCategoryIdByName(string categoryName)
        {
            int categoryId = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT id FROM Category WHERE catename = @categoryName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@categoryName", categoryName);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            categoryId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 
            }
            return categoryId;
        }
        public DataTable GetCategories()
        {
            DataTable categoriesTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT catename FROM Category";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(categoriesTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 
            }

            return categoriesTable;
        }
    }
}
