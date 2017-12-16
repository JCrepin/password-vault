using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordVault.Core.DAL
{
    // Hack to get Entity Framework migrations to work in a class library
    // http://benjii.me/2017/05/enable-entity-framework-core-migrations-visual-studio-2017/ 
    public class MigrationsDbContextFactory : IDesignTimeDbContextFactory<AppDbContext> //IDbContextFactory<AppDbContext>
    {
        const string SQL_CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=PasswordVault;Trusted_Connection=True;MultipleActiveResultSets=true";

        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer(SQL_CONNECTION_STRING);
            return new AppDbContext(builder.Options);
        }
    }
}
