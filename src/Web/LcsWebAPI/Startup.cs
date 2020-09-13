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
            //�Զ���ʼ��AppSettingsʵ������ӳ��appSettings�������
            // services.Configure<AppSettingModel>(Configuration.GetSection("Appsettings"));
            // services.AddDbContext<h5_lisboa_tkContext>(options =>
            //  options.UseMySql(Configuration.GetConnectionString("mysqlConnectstr")));

            //����EF�ķ���ע��
            services.AddEntityFrameworkMySql()
                .AddDbContext<h5_lisboa_tkContext>(options =>
                {
                    options.UseMySql(Configuration.GetConnectionString("mysqlConnectstr")); //��ȡ�����ļ��е������ַ���
                });

            //����һ��������Դ���Կ���
            services.AddCors(options =>
            {
                options.AddPolicy("CustomCorsPolicy", policy =>
                {
                    // �趨����������Դ���ж��������','����
                    policy.WithOrigins("https://localhost:5001")//ֻ����https://localhost:5001��Դ�������
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
