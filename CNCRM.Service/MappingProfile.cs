using AutoMapper;
using CNCRM.Dto.Concrete;
using CNCRM.Entity.Entity;
using System;

namespace CNCRM.Service
{
    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
        //var destination = Mapping.Mapper.Map<Destination>(yourSourceInstance);

    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BackupUnit, BackupUnitDto>().ReverseMap();
            CreateMap<Computer, ComputerDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Firewall, FirewallDto>().ReverseMap();
            CreateMap<Server, ServerDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserComputer, UserComputerDto>().ReverseMap();
        }
    }
}
