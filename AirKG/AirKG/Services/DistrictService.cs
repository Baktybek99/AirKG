using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AutoMapper;

namespace AirKG.Services
{
    public class DistrictService : EntityService<District>
    {
        public DistrictService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }
    }
}
