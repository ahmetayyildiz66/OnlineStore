using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.Common.Contracts;
using OnlineStore.Core.Common.LoggingService;

namespace OnlineStore.ServiceHost
{
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services){
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}