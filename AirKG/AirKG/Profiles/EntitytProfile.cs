using AirKG.Entity;
using AirKG.ViewModels.Account;
using AirKG.ViewModels.Markers;
using AutoMapper;

namespace AirKG.Profiles
{
    public class EntitytProfile : Profile
    {
        public EntitytProfile()
        {
            ///ПРимер создания
            //CreateMap<T,TEntity>()
            //    .ForMember();

            CreateMap<User, LoginViewModel>()
                .ReverseMap();

            CreateMap<Sensor, MapModel>()
                .ReverseMap();
        }
    }
}
