using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Gomo.CC.Model;
using Gomo.CC.IDAL;
using Gomo.CC.EFDal;
using Gomo.CC.EFDAL;
using Gomo.CC.IBLL;
using Gomo.CC.BLL;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Hangfire;
using Gomo.CC.DIModule;
using Microsoft.AspNetCore.HttpOverrides;
using Hangfire.MySql;
using Serilog;
using System.Transactions;
using AutofacSerilogIntegration;

namespace Gomo.CC.UI.Portal
{
    //Development Production
    public class Startup
    {
       
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
       
        //設定hangfire
        void SetUpHangfire(IServiceCollection services)
        {
            string connstr = null;
            connstr = Configuration.GetConnectionString("HangfireConnection");
            Log.Information("設定Hangfire連線=" + connstr);
            //Hangfire的參數設定
            MySqlStorageOptions mySqlStorageOptions = new MySqlStorageOptions
            {
                TransactionIsolationLevel = IsolationLevel.ReadCommitted,
                QueuePollInterval = TimeSpan.FromSeconds(15),
                JobExpirationCheckInterval = TimeSpan.FromHours(1),
                CountersAggregateInterval = TimeSpan.FromMinutes(5),
                PrepareSchemaIfNecessary = true,
                DashboardJobListLimit = 50000,
                TransactionTimeout = TimeSpan.FromMinutes(1),
            };
            //services.AddHangfire(options => options
            //       .UseStorage(new MySqlStorage(connstr, mySqlStorageOptions))
            //       .UseColouredConsoleLogProvider());
            services.AddHangfire(options => options
                  .UseStorage(new MySqlStorage(connstr, mySqlStorageOptions))
                  );
            //services.AddHangfire(config =>
            //    config.UseSqlServerStorage(Configuration.GetConnectionString("HangfireConnection")));
        }
        //設定資料庫
        void SetUPDataBase(IServiceCollection services)
        {
            //services.AddDbContext<GomoCCDBContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("GomoLocalDatabase")));
            // services.AddDbContext<BloggingContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("myHome")));
            string connstr = null;
            connstr = Configuration.GetConnectionString("GomoDatabase");
            Log.Information("設定資料庫連線=" + connstr);
            services.AddDbContext<GomoCCDBContext>(options =>
                      options.UseMySql(connstr));
        }
        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            Log.Information("start ConfigureServices.." );
            //Development Production

            // Add framework services.
            //加入handfire
            SetUpHangfire(services);
            //連結資料庫
            SetUPDataBase(services);
            //加入MVC的框架
            services.AddMvc();
            //// create custom container
            //var container = new CustomContainer();
            //// read service collection to the custom container
            //container.RegisterFromServiceCollection(services);
            //// use and configure the custom container
            //container.RegisterSingelton<IProvider, MyProvider>();
            //// creating the IServiceProvider out of the custom container
            //return container.BuildServiceProvider();

            //autofac container
            var builder = new ContainerBuilder();
            // read service collection to Autofac
            builder.Populate(services);
            // use and configure Autofac
            builder.RegisterModule<DalModule>();
            builder.RegisterModule<ServiceModule>();
            //注入Serilog
            builder.RegisterLogger(autowireProperties: true);
            // build the Autofac container
            ApplicationContainer = builder.Build();
            // creating the IServiceProvider out of the Autofac container
            //return new AutofacServiceProvider(ApplicationContainer);
            Log.Information("Done ConfigureServices...");
            return ApplicationContainer.Resolve<IServiceProvider>();
            //
            //var builder = new ContainerBuilder();
            //builder.RegisterModule<DalModule>();
            //builder.RegisterModule<ServiceModule>();
            //builder.Populate(services);
            //ApplicationContainer = builder.Build();
            //return ApplicationContainer.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Log.Warning("Environment=" + env.EnvironmentName);
            //設定反向 Proxy 伺服器時，驗證中介軟體需要 UseForwardedHeaders 先執行
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            //驗證配置中介軟體
            //
            //使用Hangfire
            app.UseHangfireServer(
                new BackgroundJobServerOptions
                {
                    WorkerCount = 1//只准許一個instance
                });
            app.UseHangfireDashboard();
            //起動shcedulejob
            Helpers.Hangfire.HangfireHelp.Instance.DelayScheculdeJob();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
