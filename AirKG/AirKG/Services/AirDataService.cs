using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AutoMapper;

namespace AirKG.Services
{
    public class AirDataService : EntityService<AirData>
    {
        public AirDataService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }

    }
}
