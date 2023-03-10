using Cake_Shop_Thelins.Models;
using System.IO.Pipelines;

namespace Cake_Shop_Thelins.ViewModels
{
    public class CakesListViewModel
    {
        public IEnumerable<Cake> Cakes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
