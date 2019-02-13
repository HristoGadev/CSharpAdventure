using CompanyApp.Core.Contracts;
using CompanyServices.Contracts;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyApp
{
    public class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;
        public Engine(IServiceProvider service)
        {
            this.serviceProvider = service;
        }

        public void Run()
        {
            var initializeDb = this.serviceProvider.GetService<IDbInitializerService>();
            initializeDb.InitializeDatabase();

            var commandInterpreter = this.serviceProvider.GetService<ICommandInterpreter>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
