using Microsoft.Extensions.DependencyInjection;
using Template.CrossCutting.Logging;

namespace Template.CrossCutting.InjecaoDependencia
{
    public static class LoggingServiceCollectionExtension
    {
        public static IServiceCollection AddLogger(this IServiceCollection services)
	    {
            var logger = LoggerManager.CreateLogger();
		    services.AddSingleton(logger);
            return services;
	    }
    }
}