using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Serilog;
using Serilog.Events;
using Microsoft.OpenApi.Models;

namespace VictorOpsBackendApi
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
            var settings = services.BuildServiceProvider()
                        .GetService<IOptionsMonitor<AppConfiguration>>().CurrentValue;
            
            // Inject the configuration
            services.AddSingleton<IRedisClientConfiguration>(provider => settings);
            services.AddSingleton<IVictorOpsConfiguration>(provider => settings);
            
            // Create redis client
            //services.AddSingleton<IRedisClient, RedisClient>();

            //services.AddSingleton<ITaskManager, RedisTaskManager>();
            //services.AddSingleton<IHostedService, TaskRunnerService>();

            services.AddSingleton<ITeamsApi>(provider => new TeamsApi());
            services.AddSingleton<IUsersApi>(provider => new UsersApi());
            services.AddSingleton<ITeamRepository, TeamRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VictorOpsApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VictorOpsApi");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
