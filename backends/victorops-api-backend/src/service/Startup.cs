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
using Microsoft.EntityFrameworkCore;
using VictorOpsBackendApi.Repositories;
using VictorOpsBackendApi.Sql;
using VictorOpsBackendApi.Services;

namespace VictorOpsBackendApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var settings = services.BuildServiceProvider()
                        .GetService<IOptionsMonitor<AppConfiguration>>().CurrentValue;
            
            // Inject the configuration
            services.AddSingleton<IAppConfiguration>(provider => settings);
            services.AddSingleton<IRedisClientConfiguration>(provider => settings);
            services.AddSingleton<IVictorOpsConfiguration>(provider => settings);
            services.AddSingleton<ISqlBackendConfiguration>(provider => settings);

            // Add the VictorOps Api Clients
            services.AddSingleton<ITeamsApi, TeamsApi>();
            services.AddSingleton<IUsersApi, UsersApi>();
            services.AddSingleton<IOnCallApi, OnCallApi>();

            // Add the VictorOps Services
            // services.AddSingleton<IUserService, UserService>();
            // services.AddSingleton<ITeamService, TeamService>();
            // services.AddSingleton<IMemberService, MemberService>();
            // services.AddSingleton<IOnCallService, OnCallService>();

            // Add the VictorOps Mock Services (For testing only)
            services.AddSingleton<IServiceDataMocks, ServiceDataMocks>();
            services.AddSingleton<IUserService, UserServiceMock>();
            services.AddSingleton<ITeamService, TeamServiceMock>();
            services.AddSingleton<IMemberService, MemberServiceMock>();
            services.AddSingleton<IOnCallService, OnCallServiceMock>();

            // Add the database repositories
            services.AddSingleton<ITeamRepository, TeamRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IOnCallRepository, OnCallRepository>();
            
            // Add the database context
            services.AddSqlBackendContext<VictorOpsDataContext>(settings);
            services.AddSqlBackendContext<TaskBrokerDataContext>(settings);
            
            // Add the task handling services
            services.AddSingleton<ITaskRepository, SqlTaskRepository>();
            services.AddSingleton<ITaskHandlerRegistry, TaskHandlerRegistry>();
            services.AddHostedService<TaskRunnerHostedService>();
            
            // Add lease lock services
            services.AddLeaseLockServices();

            // Add task handlers
            services.AddSingleton<ITaskHandler, VictorOpsTaskHandler>();
            services.AddHostedService<TaskHandlerRegistrationService>();

            services.AddControllers()
                    .AddNewtonsoftJson();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VictorOpsApi", Version = "v1" });
            });
        }
    }
}
