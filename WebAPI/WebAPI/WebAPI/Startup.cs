
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebAPI
{
    public class Startup
    {
        private IConfiguration config;

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}        

        public Startup(IConfiguration configuration)
        {
            this.config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {              
            services.AddDbContext<OtdelKadrovDbContext>(optionsBuilder => optionsBuilder.UseSqlServer(config.GetConnectionString("main")));           
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My API", Version = "v"});
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v/swagger.json", "V");
                c.RoutePrefix = string.Empty;
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
