using Microsoft.Extensions.DependencyInjection;
using EFAndLinqPractice_SchoolAPI.Repositories;
using EFAndLinqPractice_SchoolAPI.ExternalAPIs;
using EFAndLinqPractice_SchoolAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SchoolAPI.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddSqlDbAsDataSource(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IStudentRepository, StudentEntityFrameworkRepository>();
            services.AddDbContext<SchoolContext>(options => options.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection AddExternalApiAsDataSource(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentExternalCallRepository>();
            services.AddScoped<ExternalSchoolHttpClient>();
            services.AddHttpClient();
            
            return services;
        }
    }
}