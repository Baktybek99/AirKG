using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using AirKG.ViewModels;

namespace AirKG.Services
{
    /// <summary>
    /// Сервис для работы с диаграммами
    /// </summary>
    public class ChartService : EntityService<AirData>
    {
        public ChartService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }

        /// <summary>
        /// Получить данные для диаграммы
        /// </summary>
        /// <param name="sensorId"></param>
        /// <returns></returns>
        public async Task<List<object>> GetShared(int sensorId)
        {
            List<object> data = new List<object>();
            var airData = Context.Set<AirData>()
                .Where(x => x.SensorId == sensorId)
                .OrderBy(x => x.DateCreate)
                .Take(6)
                .ToList();
            List<DateTime> labels = airData.Select(x => x.DateCreate).ToList();
            List<double> salesNumber = airData.Select(x => x.AirQuality).ToList();
            data.Add(labels);
            data.Add(salesNumber);
            return data;
        }

        /// <summary>
        /// Получить датчики
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SensorLIstVM>> GetSensors()
        {
            return await Context.Set<Sensor>()
                .Select(x => new SensorLIstVM
                {
                    Id = x.Id,
                    PlaceName = x.PlaceName
                })
                .ToListAsync();
        }
    }
}
