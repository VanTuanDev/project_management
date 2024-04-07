using System.Data;
using DAL.Entity;

namespace DAL.Repository
{
    public class CategoryRepository
    {
        public static CategoryRepository instance;

        public static CategoryRepository Instance
        {
            get { if (instance == null) instance = new CategoryRepository(); return instance; }
            private set { instance = value; }
        }

        private CategoryRepository() { }

        public DataTable GetCategories()
        {
            string query = "GetCategories";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DeleteCategory(CategoryEntity entity)
        {
            string query = "DeleteCategory @@CategoryID ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id });
            return result > 0;
        }

        public bool InsertCategory(CategoryEntity entity)
        {
            string query = "InsertCategory @CategoryId , @CategoryName";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id, entity.catename });
            return result > 0;
        }

        public bool UpdateCategory(CategoryEntity entity)
        {
            string query = "UpdateCategory @CategoryId , @NewCategoryName";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id, entity.catename });
            return result > 0;
        }
    }
}