using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudDBEntity2;
using LcsWebAPI.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LcsWebAPI
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
            services.AddControllers();
            //自动初始化AppSettings实例并且映射appSettings里的配置
            // services.Configure<AppSettingModel>(Configuration.GetSection("Appsettings"));
            // services.AddDbContext<h5_lisboa_tkContext>(options =>
            //  options.UseMySql(Configuration.GetConnectionString("mysqlConnectstr")));

            //配置EF的服务注册
            services.AddEntityFrameworkMySql()
                .AddDbContext<h5_lisboa_tkContext>(options =>
                {
                    options.UseMySql(Configuration.GetConnectionString("mysqlConnectstr")); //读取配置文件中的链接字符串
                });

            //允许一个或多个来源可以跨域
            services.AddCors(options =>
            {
                options.AddPolicy("CustomCorsPolicy", policy =>
                {
                    // 设定允许跨域的来源，有多个可以用','隔开
                    policy.WithOrigins("https://localhost:5001")//只允许https://localhost:5001来源允许跨域
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors("CustomCorsPolicy");
        }
    }
}
