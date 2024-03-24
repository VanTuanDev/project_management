using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class FoodManager
    {
        private FoodRepository foodDAL;

        public FoodManager()
        {
            foodDAL = new FoodRepository();
        }

        public DataTable GetFoods()
        {
            return foodDAL.GetFoods();
        }
        public bool DeleteFood(int foodId)
        {
            return foodDAL.DeleteFood(foodId);
        }
        public bool InsertFood(int foodId, string foodName, string unit, string price, int categoryId)
        {
            return foodDAL.InsertFood(foodId, foodName, unit, price, categoryId);
        }
        public bool UpdateFood(int foodId, string newFoodName, string newUnit, string newPrice, int newCategoryId)
        {
            return foodDAL.UpdateFood(foodId, newFoodName, newUnit, newPrice, newCategoryId);
        }
        public int GetCategoryIdByName(string categoryName)
        {
            return foodDAL.GetCategoryIdByName(categoryName);
        }
    }
}
