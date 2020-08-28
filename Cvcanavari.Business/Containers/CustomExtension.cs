using Cvcanavari.Business.Concrete;
using Cvcanavari.Business.Interfaces;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.DataAccess.Concrete.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Cvcanavari.Business.Containers
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<ICvDal, EfCvDal>();
            services.AddScoped<ICvService, CvManager>();
        }
    }
}
