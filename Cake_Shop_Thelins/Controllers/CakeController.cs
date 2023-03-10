using Cake_Shop_Thelins.Models;
using Cake_Shop_Thelins.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cake_Shop_Thelins.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;
        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;

        }
        public IActionResult ShowCakeList()
        {
            CakesListViewModel model = new CakesListViewModel();
            model.Cakes = _cakeRepository.AllCakes;
            model.CurrentCategory = "Chees cakes";
            return View(model);
        }
    }
}
