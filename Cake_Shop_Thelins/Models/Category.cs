using System.IO.Pipelines;

namespace Cake_Shop_Thelins.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Cake> Cakes { get; set; }
    }
}

