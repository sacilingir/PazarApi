using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PazarApi.Application.Interfaces.Repositories;
using PazarApi.Persistence.Context;

namespace PazarApi.Persistence
{
    public static class Registration
    {

        public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(IReadRepository<>));
        }
    }
}
 