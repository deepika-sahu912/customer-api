using System;
using System.Reflection;
using Application.Contracts;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
	public static class AddApplicationServices
	{

        public static IServiceCollection AddApplicationServicesReg(this IServiceCollection services)
        {
			services.AddMediatR(Assembly.GetExecutingAssembly());
			return services;
        }
    }
}

