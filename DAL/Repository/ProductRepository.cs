using System.Data;
using DAL.Entity;

namespace DAL.Repository
{
    public class ProductRepository
    {
        public static ProductRepository instance;
        public static ProductRepository Instance
        {
            get { if (instance == null) instance = new ProductRepository(); return instance; }
            private set { instance = value; }
        }
        private ProductRepository() { }
        public DataTable GetFoods()
        {
            string query = "GetFoods";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool DeleteFood(ProductEntity entity)
        {
            string query = "DeleteFood @FoodId ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id });
            return result > 0;
        }
        public bool InsertFood(ProductEntity entity)
        {
            string query = "InsertFood @FoodId , @FoodName , @Unit , @Price , @CategoryId";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id, entity.name, entity.unit, entity.price, entity.cateid });
            return result > 0;
        }
        public bool UpdateFood(ProductEntity entity)
        {
            string query = "UpdateFood @FoodId , @FoodName , @Unit , @Price , @CategoryId";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id, entity.name, entity.unit, entity.price, entity.cateid });
            return result > 0;
        }
        public int GetCategoryIdByName(CategoryEntity entity)
        {
            int categoryId = 0;
            try
            {
                string query = "SELECT id FROM Category WHERE catename = @categoryName";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { entity.catename });

                if (result != null && int.TryParse(result.ToString(), out int roleIdResult))
                {
                    categoryId = roleIdResult;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ ghi log, thông báo lỗi
            }
            return categoryId;
        }
        public DataTable GetCategories()
        {
            string query = "GetCategoryName";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
