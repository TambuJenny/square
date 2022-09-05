using DomaineService.Models.Product;
using DomainService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastruture.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public virtual DbSet<UserModel> Users {get;set;}
        public virtual DbSet<PCModel> PCs {get;set;}
        public virtual DbSet<BrandModel> Brands {get;set;}

    }

    public class DatabaseContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
           var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration["MyConnection"];
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new Context(optionsBuilder.Options);
        }

    }
}
