using DAL.Entity;
using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class ProductManager
    {
        private ProductRepository foodDAL;

        public ProductManager()
        {
            foodDAL = ProductRepository.Instance;
        }

        public DataTable GetFoods()
        {
            return foodDAL.GetFoods();
        }
        public bool DeleteFood(ProductEntity entity)
        {
            return foodDAL.DeleteFood(entity);
        }
        public bool InsertFood(ProductEntity entity, ref string error)
        {
            return foodDAL.InsertFood(entity,ref error);
        }
        public bool UpdateFood(ProductEntity entity)
        {
            return foodDAL.UpdateFood(entity);
        }
        public int GetCategoryIdByName(CategoryEntity entity)
        {
            return foodDAL.GetCategoryIdByName(entity);
        }
        public DataTable GetCategories()
        {
            return foodDAL.GetCategories();
        }
    }
}
