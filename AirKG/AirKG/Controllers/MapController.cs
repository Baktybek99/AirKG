using AirKG.Context;
using AirKG.Entity;
using AirKG.ViewModels;
using AirKG.ViewModels.Markers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AirKG.Controllers
{
    public class MapController : Controller
    {
        private readonly AirKGDbContext _context;
        public MapController (AirKGDbContext context)
        {
            _context = context;
        }
        
        public ActionResult Index()
        {
            var model = new MapModel();
            model.Sensors = _context.Set<Sensor>()
                .Include(x => x.AirDatas)
                .ToList()
                .Select(x => new SensorVM
                {
                    Id = x.Id,
                    AirQuality = x.AirDatas?.OrderByDescending(x => x.DateCreate)?.First()?.AirQuality,
                    HeightCoordinates = x.HeightCoordinates,
                    Latitude= x.Latitude,
                    Longitude= x.Longitude
                })
                .ToList();
            return View(model);
        }
    }
}
