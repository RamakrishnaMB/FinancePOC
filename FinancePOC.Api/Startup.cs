using AutoMapper;
using Finance.Infra.Data2.ClassLibraryCore;
using Finance.Infra.Data2.ClassLibraryCore.DBModels;
using Finance.Infra.Data2.ClassLibraryCore.Implementation;
using Finance.Infra.Data2.ClassLibraryCore.Interface;
using FinancePOC.Api.Configurations;
using FinancePOC.Application.Interfaces;
using FinancePOC.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace FinancePOC.Api
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
            //services.AddDbContext<FinanceDBContext>(options =>
            //{
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("FinanceDbConnection"));


            //});

            services.AddDbContext<PaymentDetailDBContext>(opts => opts.UseSqlServer(ConnectionString.GetConnectionString));

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Finance Api", Version = "v1" });
            });

            services.AddCors();
            services.AddMediatR(typeof(Startup));


            services.AddAutoMapper(typeof(Startup));
            services.RegisterAutoMapper();
            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Finance Api v1");
            });

            app.UseCors(options =>
            options.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private static void RegisterServices(IServiceCollection services)
        {
            //DependencyContainer.RegisterServices(services);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IFinanceService, FinanceService>();

        }
    }
}
