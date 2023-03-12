using AirKG.Entity;
using AirKG.Services;
using AirKG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirKG.Controllers
{
    /// <summary>
    /// Основной контроллер для работы с данными о воздухе
    /// </summary>
    public class AirController : Controller
    {
        private readonly AirDataService _airDataService;

        public AirController(AirDataService airDataService)
        {
            _airDataService = airDataService;
        }

        /// <summary>
        /// Получение данных
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _airDataService.GetAsync<SensorVM>(x => x.Sensor.IsWork == true));
        }

        /// <summary>
        /// Получить детали
        /// </summary>
        /// <param name="id">код</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            return View(await _airDataService.GetAsync<SensorVM>(x => x.Id == id));
        }

        /// <summary>
        /// Для создания
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            return View();
        }

        /// <summary>
        /// Для создания
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Sensor sensorVM)
        {
            await _airDataService.Add(sensorVM);
            return Ok();
        }

        /// <summary>
        /// Получение данных для изменение
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _airDataService.GetAsync<SensorVM>());
        }

        /// <summary>
        /// Изменение данных
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sensorVM"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Sensor sensorVM)
        {
            await _airDataService.Edit<Sensor>(sensorVM);
            return View();
        }

        /// <summary>
        /// Удалить 
        /// </summary>
        /// <param name="id">Код объекта</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            await _airDataService.Delete(id);
            return Ok();
        }
    }
}
