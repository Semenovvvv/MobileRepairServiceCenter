using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MobileRepair.Constants;
using MobileRepair.Data.Models;

namespace MobileRepair.Data
{
    public static class SeedData
    {
        #region Extensions
        public static ModelBuilder AddServices(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service() { Id = 1, Name = "Замена экрана", Description = "Замена поврежденного или разбитого экрана", BaseDuration = "1-2 часа", BasePrice = 3500.00M },
                new Service() { Id = 2, Name = "Замена аккумулятора", Description = "Установка нового аккумулятора", BaseDuration = "30-60 минут", BasePrice = 2000.00M },
                new Service() { Id = 3, Name = "Чистка от пыли", Description = "Удаление пыли и грязи внутри корпуса", BaseDuration = "20-30 минут", BasePrice = 800.00M },
                new Service() { Id = 4, Name = "Ремонт кнопки включения", Description = "Восстановление или замена кнопки включения", BaseDuration = "1 час", BasePrice = 1200.00M },
                new Service() { Id = 5, Name = "Замена задней крышки", Description = "Замена поврежденной задней крышки", BaseDuration = "30 минут", BasePrice = 1500.00M },
                new Service() { Id = 6, Name = "Восстановление после залития", Description = "Очистка и ремонт устройства после попадания влаги", BaseDuration = "2-3 часа", BasePrice = 5000.00M },
                new Service() { Id = 7, Name = "Ремонт камеры", Description = "Ремонт или замена основной или фронтальной камеры", BaseDuration = "1 час", BasePrice = 2500.00M },
                new Service() { Id = 8, Name = "Замена разъема зарядки", Description = "Ремонт или замена разъема для зарядного устройства", BaseDuration = "40-60 минут", BasePrice = 1800.00M },
                new Service() { Id = 9, Name = "Обновление программного обеспечения", Description = "Установка или настройка новой версии ОС", BaseDuration = "30-40 минут", BasePrice = 1000.00M },
                new Service() { Id = 10, Name = "Установка антивируса", Description = "Настройка и установка антивирусного ПО", BaseDuration = "20 минут", BasePrice = 700.00M },
                new Service() { Id = 11, Name = "Ремонт динамика", Description = "Замена или чистка основного динамика", BaseDuration = "1 час", BasePrice = 1700.00M },
                new Service() { Id = 12, Name = "Замена микрофона", Description = "Ремонт или установка нового микрофона", BaseDuration = "40 минут", BasePrice = 1900.00M },
                new Service() { Id = 13, Name = "Перепрошивка устройства", Description = "Полная переустановка ОС", BaseDuration = "1 час", BasePrice = 1500.00M },
                new Service() { Id = 14, Name = "Восстановление данных", Description = "Восстановление удаленных или поврежденных данных", BaseDuration = "2-4 часа", BasePrice = 6000.00M },
                new Service() { Id = 15, Name = "Замена вибромотора", Description = "Установка нового вибромотора", BaseDuration = "30 минут", BasePrice = 1300.00M },
                new Service() { Id = 16, Name = "Ремонт Wi-Fi модуля", Description = "Настройка или замена модуля Wi-Fi", BaseDuration = "1-2 часа", BasePrice = 2200.00M },
                new Service() { Id = 17, Name = "Замена SIM-лотка", Description = "Установка нового SIM-лотка", BaseDuration = "20 минут", BasePrice = 800.00M },
                new Service() { Id = 18, Name = "Замена кнопок громкости", Description = "Ремонт или замена кнопок регулировки громкости", BaseDuration = "1 час", BasePrice = 1400.00M },
                new Service() { Id = 19, Name = "Устранение перегрева", Description = "Чистка и проверка системы охлаждения устройства", BaseDuration = "1-2 часа", BasePrice = 3500.00M },
                new Service() { Id = 20, Name = "Замена дисплея", Description = "Полная замена дисплейного модуля", BaseDuration = "1-2 часа", BasePrice = 4000.00M },
                new Service() { Id = 21, Name = "Ремонт Bluetooth модуля", Description = "Восстановление или замена модуля Bluetooth", BaseDuration = "1-2 часа", BasePrice = 2500.00M },
                new Service() { Id = 22, Name = "Замена разъема наушников", Description = "Ремонт или замена аудиоразъема", BaseDuration = "40 минут", BasePrice = 1700.00M },
                new Service() { Id = 23, Name = "Удаление вирусов", Description = "Очистка устройства от вирусов", BaseDuration = "30 минут", BasePrice = 900.00M },
                new Service() { Id = 24, Name = "Настройка синхронизации", Description = "Настройка синхронизации данных с облаком или ПК", BaseDuration = "30 минут", BasePrice = 800.00M },
                new Service() { Id = 25, Name = "Ремонт антенны", Description = "Ремонт или замена антенного модуля", BaseDuration = "1-2 часа", BasePrice = 2800.00M },
                new Service() { Id = 26, Name = "Замена модуля NFC", Description = "Установка нового NFC-модуля", BaseDuration = "1 час", BasePrice = 2500.00M },
                new Service() { Id = 27, Name = "Замена системной платы", Description = "Полная замена материнской платы", BaseDuration = "2-4 часа", BasePrice = 8000.00M },
                new Service() { Id = 28, Name = "Удаление блокировки", Description = "Снятие блокировки устройства (пароль, граф. ключ)", BaseDuration = "30 минут", BasePrice = 1200.00M },
                new Service() { Id = 29, Name = "Замена корпуса", Description = "Полная замена корпуса устройства", BaseDuration = "2-3 часа", BasePrice = 4500.00M },
                new Service() { Id = 30, Name = "Замена задней камеры", Description = "Установка нового модуля задней камеры", BaseDuration = "1 час", BasePrice = 3000.00M },
                new Service() { Id = 31, Name = "Восстановление IMEI", Description = "Ремонт и восстановление IMEI устройства", BaseDuration = "1-2 часа", BasePrice = 3500.00M },
                new Service() { Id = 32, Name = "Замена шлейфа", Description = "Установка нового шлейфа", BaseDuration = "1 час", BasePrice = 1600.00M },
                new Service() { Id = 33, Name = "Настройка учетной записи", Description = "Восстановление или настройка аккаунта", BaseDuration = "20 минут", BasePrice = 700.00M },
                new Service() { Id = 34, Name = "Замена датчика приближения", Description = "Установка нового датчика", BaseDuration = "1 час", BasePrice = 1400.00M },
                new Service() { Id = 35, Name = "Ремонт зарядного устройства", Description = "Проверка и ремонт зарядного адаптера", BaseDuration = "30 минут", BasePrice = 1200.00M },
                new Service() { Id = 36, Name = "Замена датчика освещения", Description = "Замена модуля датчика освещения", BaseDuration = "40 минут", BasePrice = 1500.00M },
                new Service() { Id = 37, Name = "Установка приложений", Description = "Установка и настройка необходимых приложений", BaseDuration = "20 минут", BasePrice = 600.00M },
                new Service() { Id = 38, Name = "Ремонт GPS", Description = "Ремонт или замена GPS-модуля", BaseDuration = "1-2 часа", BasePrice = 2700.00M },
                new Service() { Id = 39, Name = "Ремонт разъема SIM", Description = "Замена поврежденного разъема SIM", BaseDuration = "1 час", BasePrice = 2000.00M },
                new Service() { Id = 40, Name = "Замена передней камеры", Description = "Установка нового модуля фронтальной камеры", BaseDuration = "1 час", BasePrice = 2800.00M },
                new Service() { Id = 41, Name = "Настройка роутинга", Description = "Настройка маршрутизатора и подключения устройства", BaseDuration = "30 минут", BasePrice = 900.00M },
                new Service() { Id = 42, Name = "Замена стекла камеры", Description = "Установка нового стекла на камеру", BaseDuration = "30 минут", BasePrice = 1000.00M },
                new Service() { Id = 43, Name = "Ремонт датчика отпечатка пальца", Description = "Настройка или замена модуля отпечатка", BaseDuration = "1 час", BasePrice = 2200.00M },
                new Service() { Id = 44, Name = "Замена защитного стекла", Description = "Установка нового защитного стекла", BaseDuration = "15 минут", BasePrice = 500.00M },
                new Service() { Id = 45, Name = "Чистка микрофона", Description = "Удаление пыли и грязи из микрофона", BaseDuration = "20 минут", BasePrice = 600.00M },
                new Service() { Id = 46, Name = "Ремонт вибромотора", Description = "Восстановление работы вибромотора", BaseDuration = "40 минут", BasePrice = 1500.00M },
                new Service() { Id = 47, Name = "Восстановление загрузчика", Description = "Починка или разблокировка загрузчика", BaseDuration = "1 час", BasePrice = 1800.00M },
                new Service() { Id = 48, Name = "Замена батарейного контакта", Description = "Замена контактов батареи", BaseDuration = "30 минут", BasePrice = 1200.00M },
                new Service() { Id = 49, Name = "Замена термопасты", Description = "Замена термопасты на процессоре устройства", BaseDuration = "1 час", BasePrice = 2000.00M },
                new Service() { Id = 50, Name = "Устранение шумов в динамике", Description = "Чистка или ремонт динамика", BaseDuration = "30 минут", BasePrice = 800.00M }
            );

            return modelBuilder;
        }

        public static ModelBuilder AddRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>() { Id = 1, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole<int>() { Id = 2, Name = "Client", NormalizedName = "CLIENT", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole<int>() { Id = 3, Name = "Employee", NormalizedName = "EMPLOYEE", ConcurrencyStamp = Guid.NewGuid().ToString() }
            );

            return modelBuilder;
        }

        #endregion

        #region Methods

        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

            await EnsureRoleAsync(roleManager, "Admin");
            await EnsureRoleAsync(roleManager, "Employee");
            await EnsureRoleAsync(roleManager, "Client");

            await EnsureAdminUserAsync(userManager);
        }

        private static async Task EnsureRoleAsync(RoleManager<IdentityRole<int>> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole<int>(roleName));
            }
        }

        private static async Task EnsureAdminUserAsync(UserManager<ApplicationUser> userManager)
        {
            var adminEmail = "admin@email.com";
            var adminPassword = "Pass1.";

            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var adminUser = new ApplicationUser()
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    CreatedDate = DateTime.UtcNow,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, RoleConstants.Admin);
                }
            }
        }

        #endregion
    }
}