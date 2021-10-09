using Quartz;
using Serilog;
using Quartz.Spi;
using Quartz.Impl;
using Serilog.Events;
using Microsoft.AspNetCore.Mvc;
using DemoHub.Persistence.Models;
using Microsoft.AspNetCore.Builder;
using DemoHub.WebServices.Scheduler;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DemoHub.WebServices.Scheduler.Jobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoHub.WebServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override(
                    "Microsoft",
                    LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.File(
                    "./Log/log.txt",
                    fileSizeLimitBytes: 1_000_000,
                    rollOnFileSizeLimit: true,
                    rollingInterval: RollingInterval.Day,
                    shared: true)
                .CreateLogger();

            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc()
            //.AddJsonOptions(
            //    options => options
            //        .SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //    )
            //.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // net core 3.0 upgrade
            services.AddControllers();


            services.AddDbContext<DemoHubDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DemoHubDB")));

            // Quartz Job Configurations
            #region Quartz Job Configurations
            // Add Quartz services
            services.AddSingleton<IJobFactory, SingletonJobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            services.AddSingleton<QuartzJobRunner>();
            services.AddHostedService<QuartzHostedService>();

            // Add DemoHub jobs
            #region Add Calastone jobs
            services.AddSingleton<GetCTNMessagesJob>();
            services.AddSingleton<SendCTNMessagesJob>();
            services.AddScoped<GetQueueMessagesJob>();
            services.AddScoped<SendQueueOrderConfirmationsJob>();

            services.AddScoped<ValidateMessagesJob>();
            services.AddScoped<SendToRegistryJob>();
            services.AddScoped<ProcessMessagesJob>();
            services.AddScoped<ProcessSwitchJob>();
            #endregion Add Calastone jobs

            #region Get/Send CTN Messages
            services.AddSingleton(new JobSchedule(
                jobType: typeof(GetCTNMessagesJob),
                cronExpression: "0 */1 9-22 ? * *")); // run every 1 minute

            services.AddSingleton(new JobSchedule(
                jobType: typeof(SendCTNMessagesJob),
                cronExpression: "0 */1 8-22 ? * *")); // run every 1 minute
            #endregion Get/Send CTN Messages

            #region Get/Send Queue Messages
            services.AddSingleton(new JobSchedule(
                jobType: typeof(GetQueueMessagesJob),
                cronExpression: "0 */1 9-22 ? * *")); // run every 5 seconds

            services.AddSingleton(new JobSchedule(
                jobType: typeof(SendQueueOrderConfirmationsJob),
                cronExpression: "0 */1 8-22 ? * *")); // run every 5 seconds
            #endregion Get/Send Queue Messages

            #region Processing Messages
            services.AddSingleton(new JobSchedule(
                jobType: typeof(ValidateMessagesJob),
                cronExpression: "0 */1 8-22 ? * *")); // run every 5 seconds

            services.AddSingleton(new JobSchedule(
                jobType: typeof(SendToRegistryJob),
                cronExpression: "0 */1 9-22 ? * *")); // run every 5 seconds

            services.AddSingleton(new JobSchedule(
                jobType: typeof(ProcessMessagesJob),
                cronExpression: "0 */1 9-22 ? * *")); // run every 5 seconds

            services.AddSingleton(new JobSchedule(
                jobType: typeof(ProcessSwitchJob),
                cronExpression: "0 */1 9-22 ? * *")); // run every 5 seconds
            #endregion Processing Messages

            #region Add CHESS jobs
            services.AddSingleton<GetCHESSMessagesJob>();
            services.AddSingleton<SendCHESSMessagesJob>();
            services.AddScoped<GetCHESSQueueMessagesJob>();
            services.AddScoped<SendCHESSQueueMessagesJob>();
            #endregion Add CHESS jobs

            #region Get/Send CHESS Messages
            services.AddSingleton(new JobSchedule(
                jobType: typeof(GetCHESSMessagesJob),
                cronExpression: "0 */1 9-23 ? * *")); // run every 1 minute

            services.AddSingleton(new JobSchedule(
                jobType: typeof(GetCHESSQueueMessagesJob),
                cronExpression: "0 */1 9-23 ? * *")); // run every 1 minute

            services.AddSingleton(new JobSchedule(
                jobType: typeof(SendCHESSQueueMessagesJob),
                cronExpression: "0 */1 9-23 ? * *")); // run every 1 minute

            services.AddSingleton(new JobSchedule(
                jobType: typeof(SendCHESSMessagesJob),
                cronExpression: "0 */1 9-23 ? * *")); // run every 1 minute
            #endregion Get/Send CHESS Messages

            #endregion Quartz Job Configurations
        }

        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseHsts();
            //}
            loggerFactory.AddSerilog();
            //app.UseHttpsRedirection();
            //app.UseMvc();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}