using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Maxim.Core.DataAccess
{
 
    public class BusinessEntities : DbContext
    {
        public DbSet<Person> Persons { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Initial Catalog=Maxim;" +
                                        "Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().Property(c => c.FirstName).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Person>().Property(c => c.LastName).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Person>().HasQueryFilter(c => c.IsDeleted == false);
            base.OnModelCreating(modelBuilder);
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    var connection = @"Server=.;Database=MyDb;Trusted_Connection=True;";
        //    services.AddDbContext<BusinessEntities>(options => options.UseSqlServer(connection));
        //}



    }
}