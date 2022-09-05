using ApplicationCore.Services;
using DomainService.Interface;

namespace ApplicationCore.Helpers
{
    public class Helper
    {
        public static void BussinessHelper(IServiceCollection services)
        {
            services.AddScoped<UserInterface,UserServices>();

        }
    }    
}
