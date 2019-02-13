using CompanyApp.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CompanyApp.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] input)
        {
            string commandName = input[0] + "Command";
            string[] args = input.Skip(1).ToArray();

            var type = Assembly.GetCallingAssembly()
                               .GetTypes()
                               .FirstOrDefault(n => n.Name == commandName);

            if (type==null)
            {
                throw new ArgumentException("Invalid command!");
            }
            
            var constructor = type
                .GetConstructors()
                .First();

            var constructParams = constructor
                .GetParameters()
                .Select(p => p.ParameterType);

            var service = constructParams
                .Select(serviceProvider.GetService)
                .ToArray();

            var command = (ICommand)constructor.Invoke(service);

            string result=command.Execute(args);

            return result;
        }
    }
}
