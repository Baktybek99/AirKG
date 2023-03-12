using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AutoMapper;

namespace AirKG.Services
{
    /// <summary>
    /// Для работы с районами
    /// </summary>
    public class DistrictService : EntityService<District>
    {
        public DistrictService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }
    }
}
