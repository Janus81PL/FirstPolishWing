using FirstPolishWing.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace FirstPolishWing.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<FirstPolishWingDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("FirstPolishWing")
            ));
        }
    }
}
