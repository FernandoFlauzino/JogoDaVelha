using CaseItauJogoDaVelha.Application.Interface;
using CaseItauJogoDaVelha.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace CaseItauJogoDaVelha.Infra.IoC
{
    public class DependencyInjector
    {

        private static IServiceProvider _serviceProvider;
        private static IServiceCollection _services;
        public static T GetService<T>()
        {
            _services = _services ?? RegisterServices();
            _serviceProvider = _serviceProvider ?? _services.BuildServiceProvider();
            return _serviceProvider.GetService<T>();
        }

        public static IServiceCollection RegisterServices()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();

            return RegisterServices(new ServiceCollection(), configuration);
        }

        public static IServiceCollection RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            _services = services;

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Jogo da Velha",
                        Version = Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                        Description = "Documentação da API do jogo da velha. \r\n"

                    }
                );
            });


            services.AddControllers();

            services.AddScoped<IGameService, GameService>();

            services.AddMvc();

            services.AddControllersWithViews();

            return _services;
        }
    }
}
