namespace Cake_Shop_Thelins.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
           new List<Category>
           {
                new Category{CategoryId=1, CategoryName="Fruit Cake", Description="All-fruity cakes"},
                new Category{CategoryId=2, CategoryName="Cheese Cakes", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal Cakes", Description="Get in the mood for a seasonal Cake"}
           };

    }
}
