using AirKG.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirKG.Controllers
{
    /// <summary>
    /// Основной контроллер для отображения контроллера
    /// </summary>
    public class MapController : Controller
    {
        private readonly SensorService _sensorService;
        public MapController(SensorService sensorService)
        {
            _sensorService = sensorService;
        }

        /// <summary>
        /// Основная страничка для отображения 1 части
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index()
        {            
            return View(await _sensorService.GetMapModel());
        }

        /// <summary>
        /// Основная страничка для отображения 1 части
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index1()
        {
            return View(await _sensorService.GetMapModel());
        }

        /// <summary>
        /// Основная страничка для отображения 2 части
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index2()
        {
            return View(await _sensorService.GetMapModel());
        }

        /// <summary>
        /// Основная страничка для отображения 3 части
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index3()
        {
            return View(await _sensorService.GetMapModel());
        }

        /// <summary>
        /// Основная страничка для отображения 4 части
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index4()
        {
            return View(await _sensorService.GetMapModel());
        }
    }
}
