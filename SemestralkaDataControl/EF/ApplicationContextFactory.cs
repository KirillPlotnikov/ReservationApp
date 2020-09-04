using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemestralkaDataControl.EF
{
    class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = @"server=(LocalDb)\MSSQLLocalDB;database=Semestralka;integrated security=True;
                    MultipleActiveResultSets=True;App=EntityFramework;";
            optionsBuilder.UseSqlServer(
                    connectionString,
                    options => options.EnableRetryOnFailure());
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
