using AirKG.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirKG.Controllers
{
    public class ChartController : Controller
    {
        private readonly ChartService _chartservice;

        public ChartController(ChartService chartService)
        {
            _chartservice = chartService;
        }

        [HttpGet]
        public async Task<IActionResult> Shared()
        {
            ViewBag.List = new SelectList(await _chartservice.GetSensors(), "Id", "PlaceName");
            return View();
        }

        [HttpGet]
        public async Task<List<object>> GetResult(int sensorId)
        {
            return await _chartservice.GetShared(sensorId);
        }

    }
}
