using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxim.Core.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Maxim.Web.Api.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<BusinessEntities>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString(@"Server =.; Initial Catalog = Maxim;Integrated Security=true")));
            //services.AddDbContext<BusinessEntities>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase")));


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            
            using (BusinessEntities db=new BusinessEntities())
            {
                bool check = (db.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists();
                if (check)
                {
                    return;
                }
                else
                {
                    db.Database.EnsureCreated();
                }
               
            }
           
        }
        
    }
}
