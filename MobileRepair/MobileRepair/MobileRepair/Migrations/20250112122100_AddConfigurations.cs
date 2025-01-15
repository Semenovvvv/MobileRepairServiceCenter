using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobileRepair.Migrations
{
    /// <inheritdoc />
    public partial class AddConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: true),
                    HireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BasePrice = table.Column<decimal>(type: "numeric", nullable: true),
                    BaseDuration = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    DateBy = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Manufacturer = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    ProblemDescription = table.Column<string>(type: "text", nullable: false),
                    IsWarranty = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    DateBy = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Descryption = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderServices",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderServices", x => new { x.ServiceId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderServices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OldStatus = table.Column<string>(type: "text", nullable: true),
                    NewStatus = table.Column<string>(type: "text", nullable: true),
                    EditUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersHistory_AspNetUsers_EditUserId",
                        column: x => x.EditUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdersHistory_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "b0f69897-1de2-467e-9ead-8388d3cfd9ca", "Admin", "ADMIN" },
                    { 2, "cddf9665-4dc6-4c08-bdd2-699bd5f7c120", "Client", "CLIENT" },
                    { 3, "b4d5cc02-8dbf-424c-bd8e-1d4c10a52516", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BaseDuration", "BasePrice", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "1-2 часа", 3500.00m, "Замена поврежденного или разбитого экрана", "Замена экрана" },
                    { 2, "30-60 минут", 2000.00m, "Установка нового аккумулятора", "Замена аккумулятора" },
                    { 3, "20-30 минут", 800.00m, "Удаление пыли и грязи внутри корпуса", "Чистка от пыли" },
                    { 4, "1 час", 1200.00m, "Восстановление или замена кнопки включения", "Ремонт кнопки включения" },
                    { 5, "30 минут", 1500.00m, "Замена поврежденной задней крышки", "Замена задней крышки" },
                    { 6, "2-3 часа", 5000.00m, "Очистка и ремонт устройства после попадания влаги", "Восстановление после залития" },
                    { 7, "1 час", 2500.00m, "Ремонт или замена основной или фронтальной камеры", "Ремонт камеры" },
                    { 8, "40-60 минут", 1800.00m, "Ремонт или замена разъема для зарядного устройства", "Замена разъема зарядки" },
                    { 9, "30-40 минут", 1000.00m, "Установка или настройка новой версии ОС", "Обновление программного обеспечения" },
                    { 10, "20 минут", 700.00m, "Настройка и установка антивирусного ПО", "Установка антивируса" },
                    { 11, "1 час", 1700.00m, "Замена или чистка основного динамика", "Ремонт динамика" },
                    { 12, "40 минут", 1900.00m, "Ремонт или установка нового микрофона", "Замена микрофона" },
                    { 13, "1 час", 1500.00m, "Полная переустановка ОС", "Перепрошивка устройства" },
                    { 14, "2-4 часа", 6000.00m, "Восстановление удаленных или поврежденных данных", "Восстановление данных" },
                    { 15, "30 минут", 1300.00m, "Установка нового вибромотора", "Замена вибромотора" },
                    { 16, "1-2 часа", 2200.00m, "Настройка или замена модуля Wi-Fi", "Ремонт Wi-Fi модуля" },
                    { 17, "20 минут", 800.00m, "Установка нового SIM-лотка", "Замена SIM-лотка" },
                    { 18, "1 час", 1400.00m, "Ремонт или замена кнопок регулировки громкости", "Замена кнопок громкости" },
                    { 19, "1-2 часа", 3500.00m, "Чистка и проверка системы охлаждения устройства", "Устранение перегрева" },
                    { 20, "1-2 часа", 4000.00m, "Полная замена дисплейного модуля", "Замена дисплея" },
                    { 21, "1-2 часа", 2500.00m, "Восстановление или замена модуля Bluetooth", "Ремонт Bluetooth модуля" },
                    { 22, "40 минут", 1700.00m, "Ремонт или замена аудиоразъема", "Замена разъема наушников" },
                    { 23, "30 минут", 900.00m, "Очистка устройства от вирусов", "Удаление вирусов" },
                    { 24, "30 минут", 800.00m, "Настройка синхронизации данных с облаком или ПК", "Настройка синхронизации" },
                    { 25, "1-2 часа", 2800.00m, "Ремонт или замена антенного модуля", "Ремонт антенны" },
                    { 26, "1 час", 2500.00m, "Установка нового NFC-модуля", "Замена модуля NFC" },
                    { 27, "2-4 часа", 8000.00m, "Полная замена материнской платы", "Замена системной платы" },
                    { 28, "30 минут", 1200.00m, "Снятие блокировки устройства (пароль, граф. ключ)", "Удаление блокировки" },
                    { 29, "2-3 часа", 4500.00m, "Полная замена корпуса устройства", "Замена корпуса" },
                    { 30, "1 час", 3000.00m, "Установка нового модуля задней камеры", "Замена задней камеры" },
                    { 31, "1-2 часа", 3500.00m, "Ремонт и восстановление IMEI устройства", "Восстановление IMEI" },
                    { 32, "1 час", 1600.00m, "Установка нового шлейфа", "Замена шлейфа" },
                    { 33, "20 минут", 700.00m, "Восстановление или настройка аккаунта", "Настройка учетной записи" },
                    { 34, "1 час", 1400.00m, "Установка нового датчика", "Замена датчика приближения" },
                    { 35, "30 минут", 1200.00m, "Проверка и ремонт зарядного адаптера", "Ремонт зарядного устройства" },
                    { 36, "40 минут", 1500.00m, "Замена модуля датчика освещения", "Замена датчика освещения" },
                    { 37, "20 минут", 600.00m, "Установка и настройка необходимых приложений", "Установка приложений" },
                    { 38, "1-2 часа", 2700.00m, "Ремонт или замена GPS-модуля", "Ремонт GPS" },
                    { 39, "1 час", 2000.00m, "Замена поврежденного разъема SIM", "Ремонт разъема SIM" },
                    { 40, "1 час", 2800.00m, "Установка нового модуля фронтальной камеры", "Замена передней камеры" },
                    { 41, "30 минут", 900.00m, "Настройка маршрутизатора и подключения устройства", "Настройка роутинга" },
                    { 42, "30 минут", 1000.00m, "Установка нового стекла на камеру", "Замена стекла камеры" },
                    { 43, "1 час", 2200.00m, "Настройка или замена модуля отпечатка", "Ремонт датчика отпечатка пальца" },
                    { 44, "15 минут", 500.00m, "Установка нового защитного стекла", "Замена защитного стекла" },
                    { 45, "20 минут", 600.00m, "Удаление пыли и грязи из микрофона", "Чистка микрофона" },
                    { 46, "40 минут", 1500.00m, "Восстановление работы вибромотора", "Ремонт вибромотора" },
                    { 47, "1 час", 1800.00m, "Починка или разблокировка загрузчика", "Восстановление загрузчика" },
                    { 48, "30 минут", 1200.00m, "Замена контактов батареи", "Замена батарейного контакта" },
                    { 49, "1 час", 2000.00m, "Замена термопасты на процессоре устройства", "Замена термопасты" },
                    { 50, "30 минут", 800.00m, "Чистка или ремонт динамика", "Устранение шумов в динамике" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ClientId",
                table: "Devices",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeviceId",
                table: "Orders",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderServices_OrderId",
                table: "OrderServices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersHistory_EditUserId",
                table: "OrdersHistory",
                column: "EditUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersHistory_OrderId",
                table: "OrdersHistory",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderServices");

            migrationBuilder.DropTable(
                name: "OrdersHistory");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
