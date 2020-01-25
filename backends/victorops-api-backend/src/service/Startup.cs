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
            services.AddSingleton<IRedisClientConfiguration>(provider => settings);
            services.AddSingleton<IVictorOpsConfiguration>(provider => settings);
            
            // Add the redis client used for task leasing
            services.AddSingleton<IRedisClient, RedisClient>();
            
            // Add all the tasks to be handled
            AddVictorOpsDataCollectionTasks(services);

            // Add the task handling services
            services.AddSingleton<ITaskRepository, SqlTaskRepository>();
            services.AddSingleton<ITaskHandlerRegistry, TaskHandlerRegistry>();
            services.AddSingleton<ILeasedLockProvider,RedisLeasedLockProvider>();
            services.AddSingleton<IHostedService, TaskRunnerHostedService>();

            // Add the VictorOps Api Clients
            services.AddSingleton<ITeamsApi>(provider => new TeamsApi());
            services.AddSingleton<IUsersApi>(provider => new UsersApi());

            // Add the database repositories
            services.AddSingleton<ITeamRepository, TeamRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            
            // Add the database context
            services.AddDbContext<VictorOpsDataContext>(options =>
                options.UseNpgsql(VictorOpsDataContext.ConnectionStringBuilder(settings)));

            services.AddDbContext<TaskBrokerDataContext>(options =>
                options.UseNpgsql(TaskBrokerDataContext.ConnectionStringBuilder(settings)));

            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VictorOpsApi", Version = "v1" });
            });
        }

        private void AddVictorOpsDataCollectionTasks(IServiceCollection services)
        {
            services.AddSingleton<ILeasedTask>(p => new LeasedTask(){
                Id = $"{TaskHandlerType.VICTOROPS_API}_{TaskHandlerSubType.TEAMS_UPDATE}",
                HanlderType = TaskHandlerType.VICTOROPS_API,
                HandlerSubType = TaskHandlerSubType.TEAMS_UPDATE,
                Interval = TimeSpan.FromSeconds(30),
                LeaseDuration = TimeSpan.FromSeconds(30),
                NextTimeToRun = DateTime.UtcNow
            });

            services.AddSingleton<ILeasedTask>(p => new LeasedTask(){
                Id = $"{TaskHandlerType.VICTOROPS_API}_{TaskHandlerSubType.USERS_UPDATE}",
                HanlderType = TaskHandlerType.VICTOROPS_API,
                HandlerSubType = TaskHandlerSubType.USERS_UPDATE,
                Interval = TimeSpan.FromSeconds(30),
                LeaseDuration = TimeSpan.FromSeconds(30),
                NextTimeToRun = DateTime.UtcNow
            });

            services.AddSingleton<ILeasedTask>(p => new LeasedTask(){
                Id = $"{TaskHandlerType.VICTOROPS_API}_{TaskHandlerSubType.MEMBERS_UPDATE}",
                HanlderType = TaskHandlerType.VICTOROPS_API,
                HandlerSubType = TaskHandlerSubType.MEMBERS_UPDATE,
                Interval = TimeSpan.FromSeconds(30),
                LeaseDuration = TimeSpan.FromSeconds(30),
                NextTimeToRun = DateTime.UtcNow
            });
        }
    }
}
