using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class CategoryManager
    {
        private CategoryRepository categoryDAL;

        public CategoryManager()
        {
            categoryDAL = new CategoryRepository();
        }

        public DataTable GetCategories()
        {
            return categoryDAL.GetCategories();
        }
        public bool DeleteCategory(int categoryID)
        {
            return categoryDAL.DeleteCategory(categoryID);
        }
        public bool InsertCategory(int categoryId, string categoryName)
        {
            return categoryDAL.InsertCategory(categoryId, categoryName);
        }
        public bool UpdateCategory(int categoryId, string newCategoryName)
        {
            return categoryDAL.UpdateCategory(categoryId, newCategoryName);
        }
    }
}
