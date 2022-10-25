using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastucture.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.IoC
{
    public static class DependencyContainer
    {
        public static void ResgisterService(this IServiceCollection services)
        {
            //Services
            services.AddScoped<ICourseService, CourseService>();

            //Repository
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
