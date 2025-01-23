using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using MobileRepair.Components.Account;
using MobileRepair.Constants;
using MobileRepair.Data;
using MobileRepair.Interfaces;
using MobileRepair.Services;

namespace MobileRepair.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IdentityUserAccessor>();
            services.AddScoped<IdentityRedirectManager>();
            services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IExportService, ExportService>();

            services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

            services.AddLogging();

            return services;
        }

        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
             services.AddIdentityCore<ApplicationUser>((options) =>
                {
                    options.Password.RequireDigit = true;
                    options.Password.RequiredLength = 6;
                })
                .AddRoles<IdentityRole<int>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

            return services;
        }

        public static IServiceCollection AddAuth(this IServiceCollection services)
        {
            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
                options.AddPolicy("Employee", policy => policy.RequireRole("Admin", "Employee"));
                options.AddPolicy("Client", policy => policy.RequireRole("Client", "Admin"));
                options.AddPolicy("AuthorizedUser", policy => policy.RequireRole("Client", "Admin", "Employee"));
            });

            return services;
        }
    }
}
