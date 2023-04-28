using System;
using Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Persistence.Context;

namespace Persistence
{
	public static class AddPersistanceServices
	{

        public static IServiceCollection AddPersistanceServicesReg(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddDbContext<CustomerContext>();

            return services;
        }
    }
}

