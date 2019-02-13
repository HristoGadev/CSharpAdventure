using CompanyData;
using CompanyServices.Contracts;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompanyServices
{
    public class DbInitializerService : IDbInitializerService
    {
        private readonly CompanyContext context;
        public DbInitializerService(CompanyContext context)
        {
            this.context = context;
        }
        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
