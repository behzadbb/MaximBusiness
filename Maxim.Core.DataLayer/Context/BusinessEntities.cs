using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace Maxim.Core.DataAccess
{
 
    public class BusinessEntities : DbContext
    {
        public DbSet<Person> Persons { get; set; }

       

        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //{
        //    using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
        //    {
        //        var context = serviceScope.ServiceProvider.GetRequiredService<BusinessEntities>();
        //        context.Database.Migrate();
        //    }

        //}

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



    }
}