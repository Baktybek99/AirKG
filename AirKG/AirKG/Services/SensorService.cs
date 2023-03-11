using AirKG.Context;
using AirKG.Entity;
using AirKG.Services.Bases;
using AutoMapper;


namespace AirKG.Services
{
    public class SensorService : EntityService<Sensor>
    {
        public SensorService(AirKGDbContext context, IMapper mapper) : base(context, mapper) { }


    }
}
