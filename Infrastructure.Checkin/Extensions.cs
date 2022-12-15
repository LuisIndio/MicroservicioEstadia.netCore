using Application.Estadia;
using Domain.Estadia.Repositories;
using Infrastructure.Estadia.EF.Context;
using Infrastructure.Estadia.EF.Repository;
using Infrastructure.Ventas.EF;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddApplication();
            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EstadiaConnectionString"));
            });
            services.AddDbContext<WriteDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EstadiaConnectionString"));
            });

            //Scoped: se crea una instancia por cada request
            //Transient: se crea una instancia por cada uso
            //Singleton: se crea una instancia por cada aplicación
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IHabitacionRepository, HabitacionRepository>();
            services.AddScoped<ICheckInRepository, CheckinRepository>();
            services.AddScoped<ICheckoutRepository, CheckoutRepository>();




            return services;
        }
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }



    }
}
