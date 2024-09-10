using ProjectTemplate.BL.Authentication;
using ProjectTemplate.BL.AzureStorage;
using ProjectTemplate.BL.FindCep;
using ProjectTemplate.BL.LayoutLot;
using ProjectTemplate.BL.Profile;
using ProjectTemplate.BL.Security;
using ProjectTemplate.BL.SendEmail;
using ProjectTemplate.BL;
using ProjectTemplate.Data.Repository;
using ProjectTemplate.Repository;
using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Domain.Helpers;
using Azure.Storage.Blobs;
using ProjectTemplate.BL.Jwt;

namespace ProjectTemplate.API.Configuration
{
    public static class IocConfig
    {
        public static IServiceCollection IocResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            #region INFRA
            services.AddDbContext<ProjectTemplateDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));

            var appSettingsConfig = configuration.GetSection("LinkApplication").Get<AppSettingsConfig>();
            services.AddSingleton(appSettingsConfig);

            var azureConfig = configuration.GetSection("AzureConfig").Get<AzureConfig>();
            services.AddSingleton(azureConfig);

            services.AddSingleton(x => new BlobServiceClient(configuration["AzureConfig:StorageAccount"]));

            services.AddSingleton<IJwtFactory, JwtFactory>();

            #endregion

            #region SERVICES

            // Registro de BOs (Business Objects)
            services.AddScoped<ISecurityBO, SecurityBO>();
            services.AddScoped<IAzureStorageBO, AzureStorageBO>();
            services.AddScoped<ISendEmailBO, SendEmailBO>();
            services.AddScoped<IFindCepBO, FindCepBO>();
            services.AddScoped<ILayoutColumnsBO, LayoutColumnsBO>();
            services.AddScoped<IAuthenticationBO, AuthenticationBO>();
            services.AddScoped<IUserBO, UserBO>();
            services.AddScoped<IProfileBO, ProfileBO>();

            #endregion

            return services;
        }
    }
}
