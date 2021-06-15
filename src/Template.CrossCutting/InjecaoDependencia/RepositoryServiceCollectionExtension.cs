using Microsoft.Extensions.DependencyInjection;
using Template.Domain.Repositorios;
using Template.Infrastructure.Oracle;

namespace Template.CrossCutting.InjecaoDependencia
{
    public static class RepositoryServiceCollectionExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
	    {
		    services.AddTransient<IWeatherReadRepository, WeatherReadRepository>();
            return services;
	    }
    }
}