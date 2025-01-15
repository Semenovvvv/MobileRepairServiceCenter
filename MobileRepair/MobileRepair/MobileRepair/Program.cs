using Microsoft.EntityFrameworkCore;
using MobileRepair.Components;
using MobileRepair.Data;
using MobileRepair.Extensions;

namespace MobileRepair
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));

            builder.Services.AddCascadingAuthenticationState();

            builder.Services.AddIdentity();

            builder.Services.AddAuth();

            builder.Services.AddServices();

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddHttpClient();

            var serviceProvider = builder.Services.BuildServiceProvider();

            var registeredServices = serviceProvider.GetServices<object>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.MapAdditionalIdentityEndpoints();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    await SeedData.InitializeAsync(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Произошла ошибка при инициализации SeedData.");
                }
            }

            await app.RunAsync();
        }
    }
}
