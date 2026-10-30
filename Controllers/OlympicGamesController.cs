using Data_Transfer_Stonehocker.Models;
using Data_Transfer_Stonehocker.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Data_Transfer_Stonehocker.Controllers
{
    public class OlympicGamesController : Controller
    {
        private readonly GameService _service;

        public OlympicGamesController(GameService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Heading = "All Countries";
            return View("Flags", _service.GetAll().OrderBy(g => g.Country));
        }

        public IActionResult Game(OlympicType id)
        {
            ViewBag.Heading = id.DisplayName();
            return View("Flags", _service.GetAll()
                .Where(g => g.TypeOfGame == id)
                .OrderBy(g => g.Country));
        }

        public IActionResult Category(IndoorOutdoor id)
        {
            ViewBag.Heading = id + " Events";
            return View("Flags", _service.GetAll()
                .Where(g => g.IndoorOrOutdoor == id)
                .OrderBy(g => g.Country));
        }
    }
}