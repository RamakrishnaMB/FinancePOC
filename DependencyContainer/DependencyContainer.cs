using Finance.Infra.Data2.ClassLibraryCore.Implementation;
using Finance.Infra.Data2.ClassLibraryCore.Interface;
using FinancePOC.Application.Interfaces;
using FinancePOC.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FinancePOC.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
           // services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Application Layer 
            services.AddScoped<IFinanceService, FinanceService>();

            //Infra.Data Layer 
            //services.AddScoped<IFinanceRepository, FinanceRepository>();
            //services.AddScoped<FinanceDBContext>();


         
        }
    }
}
