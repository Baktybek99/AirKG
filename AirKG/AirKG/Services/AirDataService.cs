using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AutoMapper;

namespace AirKG.Services
{
    /// <summary>
    /// Сервис для работы с данными о воздухе
    /// </summary>
    public class AirDataService : EntityService<AirData>
    {
        public AirDataService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }

    }
}
