using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas.Repository.Common
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var fileName = Directory.GetCurrentDirectory() + $"/../Tarefas.API/appsettings.{environmentName}.json";

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(fileName)
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connnetionsString = configuration.GetConnectionString("App");
            builder.UseSqlServer(connnetionsString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}
