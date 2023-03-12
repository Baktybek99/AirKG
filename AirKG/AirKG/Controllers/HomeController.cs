using AirKG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AirKG.Controllers
{
    /// <summary>
    /// Домашний контроллер
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Первоначальная страница
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Privacy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// ДЛя отображения страницы при ошибках
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Отображени картины карты
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Cart()
        {
            return View();
        }
    }
}
