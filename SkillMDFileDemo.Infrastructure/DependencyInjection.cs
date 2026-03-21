using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkillMDFileDemo.Domain.Repositories;
using SkillMDFileDemo.Infrastructure.Repositories;

namespace SkillMDFileDemo.Infrastructure
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SkillMDFileDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SkillMDFileConnectionString")));

            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
         
            return services;
        }
    }
}
