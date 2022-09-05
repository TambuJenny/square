using ApplicationCore.Services;
using AutoMapper;
using DomainService.Interface;
using DomainService.Models;
using DomainService.Models.Request;

namespace ApplicationCore.Helpers
{
    public class Helper
    {
        private static IServiceScopeFactory _serviceScopeFactory;

        public Helper(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public static void BussinessHelper(IServiceCollection services)
        {
            services.AddScoped<UserInterface, UserServices>();
            
            
            //AutoMapper
            var mapperConfig = new MapperConfiguration(conf =>
            {
                conf.CreateMap<UserModel, UserRequest>().ReverseMap();
            });
            
            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
        }

    }
}
