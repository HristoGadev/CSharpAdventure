using CompanyApp.Core;
using CompanyApp.Core.Contracts;
using CompanyApp.Core.Controllers;
using CompanyData;
using CompanyServices;
using CompanyServices.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;

namespace CompanyApp
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var service = ConfigureService();
            IEngine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<CompanyContext>(opt => opt.UseSqlServer(Configuration.ConfigurationString));
            serviceCollection.AddAutoMapper(c => c.AddProfile<CompanyProfile>());
            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();
            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();
            serviceCollection.AddTransient<IManagerController, ManagerController>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
