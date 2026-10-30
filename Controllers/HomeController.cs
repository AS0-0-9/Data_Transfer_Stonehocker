using Data_Transfer_Stonehocker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Data_Transfer_Stonehocker.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameService _service;

        public HomeController(GameService service)
        {
            _service = service;
        }

        public IActionResult Index(OlympicViewModel model)
        {
            var filters = model.Filters;
            var games = _service.GetAll().AsEnumerable();


            if (filters.HasCategory)
                games = games.Where(g => g.TypeOfGame.ToString().ToLower() == filters.Category.ToLower());
                

            if (filters.HasType)
                games = games.Where(g => g.IndoorOrOutdoor.ToString().ToLower() == filters.Type.ToLower());

            model.Games = games.ToList();
            return View(model);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
