﻿using System.Reflection;
using GondorsLegacy.Domain.Repositories;
using GondorsLegacy.Services.Reservation.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GondorsLegacy.Services.Reservation;

public static class ReservationModuleServiceCollectionExtensions
{
    public static IServiceCollection AddReservationModule(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddScoped<IRepository<Entities.Reservation, Guid>, Repository<Entities.Reservation, Guid>>();
        services.AddScoped<IReservationRepository, ReservationRepository>();
        services.AddDbContext<ReservationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ReservationDatabase")));

        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }

    public static void MigrateReservationDb(this IApplicationBuilder app)
    {
        using(var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
        {
            serviceScope.ServiceProvider.GetRequiredService<ReservationDbContext>().Database.Migrate();
        }
    }
}

