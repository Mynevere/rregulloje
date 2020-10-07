using Microsoft.Extensions.DependencyInjection;
using Rregulloje.Application.Interfaces;
using Rregulloje.Application.Services;
using Rregulloje.Infrastructure.Data.Interfaces;
using Rregulloje.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Infrastructure.IoC
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IServicesService, ServicesService>();  

            //Infrastructure.Data Layer
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>(); 
        }
    }
}
