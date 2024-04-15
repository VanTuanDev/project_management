using DAL.Entity;
using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class CategoryManager
    {
        private CategoryRepository categoryDAL;

        public CategoryManager()
        {
            categoryDAL = CategoryRepository.Instance;
        }

        public DataTable GetCategories()
        {
            return categoryDAL.GetCategories();
        }
        public bool DeleteCategory(CategoryEntity entity)
        {
            return categoryDAL.DeleteCategory(entity);
        }
        public bool InsertCategory(CategoryEntity entity, ref string error)
        {
            return categoryDAL.InsertCategory(entity, ref error);
        }
        public bool UpdateCategory(CategoryEntity entity)
        {
            return categoryDAL.UpdateCategory(entity);
        }
    }
}
