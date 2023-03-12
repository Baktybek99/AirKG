using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AirKG.ViewModels;
using AirKG.ViewModels.Markers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AirKG.Services
{
    /// <summary>
    /// Для работы с датчиками
    /// </summary>
    public class SensorService : EntityService<Sensor>
    {
        public SensorService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<MapModel> GetMapModel()
        {
            var model = new MapModel();
            model.Sensors =  (await Context.Set<Sensor>()
                .Include(x => x.AirDatas)
                .ToListAsync())
                .Select(x => new SensorVM
                {
                    Id = x.Id,
                    AirQuality = x.AirDatas?.OrderByDescending(x => x.DateCreate)?.First()?.AirQuality,
                    HeightCoordinates = x.HeightCoordinates,
                    Latitude = x.Latitude,
                    Longitude = x.Longitude,
                    PlaceName = x.PlaceName

                })
                .ToList();
            return model;
        }

    }
}
