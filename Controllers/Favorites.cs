using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Data_Transfer_Stonehocker.Models;   

namespace Data_Transfer_Stonehocker.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly GameService _service;

        public FavoritesController(GameService service)
        {
            _service = service;
        }

        private const string FavKey = "Favorites";

        private List<string> GetFavorites()
        {
            var json = HttpContext.Session.GetString(FavKey);
            return json == null ? new List<string>() : JsonSerializer.Deserialize<List<string>>(json)!;
        }

        private void SaveFavorites(List<string> favs)
        {
            HttpContext.Session.SetString(FavKey, JsonSerializer.Serialize(favs));
        }

        [HttpPost]
        public IActionResult ToggleFavorite(string code)
        {
            var favs = GetFavorites();
            if (!favs.Remove(code))
                favs.Add(code);
            SaveFavorites(favs);
            return RedirectToAction("Index", "OlympicGames");
        }

        public IActionResult Index()
        {
            var favs = GetFavorites();
            var games = _service.GetAll()
                .Where(g => favs.Contains(g.Code))
                .ToList();
            return View(games);
        }

        [HttpPost]
        public IActionResult ClearFavorites()
        {
            HttpContext.Session.Remove(FavKey);
            return RedirectToAction("Index");
        }
    }
}
