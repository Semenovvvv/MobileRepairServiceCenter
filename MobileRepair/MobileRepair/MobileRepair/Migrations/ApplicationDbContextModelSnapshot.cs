﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileRepair.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MobileRepair.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "c55e5d63-12e0-476c-a89f-1991c9adad90",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "79d612a1-9dbd-44ce-b09e-f9eeaed13165",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "f3eeb923-c857-4eed-b6f6-82c48cf538bd",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MobileRepair.Data.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateBy")
                        .HasColumnType("timestamp");

                    b.Property<bool?>("IsWarranty")
                        .HasColumnType("boolean");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBy")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descryption")
                        .HasColumnType("text");

                    b.Property<int>("DeviceId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.OrderHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("timestamp");

                    b.Property<int?>("EditUserId")
                        .HasColumnType("integer");

                    b.Property<string>("NewStatus")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("OldStatus")
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EditUserId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersHistory");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.OrderService", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("OrderId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("OrderServices");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseDuration")
                        .HasColumnType("text");

                    b.Property<decimal?>("BasePrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDuration = "1-2 часа",
                            BasePrice = 3500.00m,
                            Description = "Замена поврежденного или разбитого экрана",
                            Name = "Замена экрана"
                        },
                        new
                        {
                            Id = 2,
                            BaseDuration = "30-60 минут",
                            BasePrice = 2000.00m,
                            Description = "Установка нового аккумулятора",
                            Name = "Замена аккумулятора"
                        },
                        new
                        {
                            Id = 3,
                            BaseDuration = "20-30 минут",
                            BasePrice = 800.00m,
                            Description = "Удаление пыли и грязи внутри корпуса",
                            Name = "Чистка от пыли"
                        },
                        new
                        {
                            Id = 4,
                            BaseDuration = "1 час",
                            BasePrice = 1200.00m,
                            Description = "Восстановление или замена кнопки включения",
                            Name = "Ремонт кнопки включения"
                        },
                        new
                        {
                            Id = 5,
                            BaseDuration = "30 минут",
                            BasePrice = 1500.00m,
                            Description = "Замена поврежденной задней крышки",
                            Name = "Замена задней крышки"
                        },
                        new
                        {
                            Id = 6,
                            BaseDuration = "2-3 часа",
                            BasePrice = 5000.00m,
                            Description = "Очистка и ремонт устройства после попадания влаги",
                            Name = "Восстановление после залития"
                        },
                        new
                        {
                            Id = 7,
                            BaseDuration = "1 час",
                            BasePrice = 2500.00m,
                            Description = "Ремонт или замена основной или фронтальной камеры",
                            Name = "Ремонт камеры"
                        },
                        new
                        {
                            Id = 8,
                            BaseDuration = "40-60 минут",
                            BasePrice = 1800.00m,
                            Description = "Ремонт или замена разъема для зарядного устройства",
                            Name = "Замена разъема зарядки"
                        },
                        new
                        {
                            Id = 9,
                            BaseDuration = "30-40 минут",
                            BasePrice = 1000.00m,
                            Description = "Установка или настройка новой версии ОС",
                            Name = "Обновление программного обеспечения"
                        },
                        new
                        {
                            Id = 10,
                            BaseDuration = "20 минут",
                            BasePrice = 700.00m,
                            Description = "Настройка и установка антивирусного ПО",
                            Name = "Установка антивируса"
                        },
                        new
                        {
                            Id = 11,
                            BaseDuration = "1 час",
                            BasePrice = 1700.00m,
                            Description = "Замена или чистка основного динамика",
                            Name = "Ремонт динамика"
                        },
                        new
                        {
                            Id = 12,
                            BaseDuration = "40 минут",
                            BasePrice = 1900.00m,
                            Description = "Ремонт или установка нового микрофона",
                            Name = "Замена микрофона"
                        },
                        new
                        {
                            Id = 13,
                            BaseDuration = "1 час",
                            BasePrice = 1500.00m,
                            Description = "Полная переустановка ОС",
                            Name = "Перепрошивка устройства"
                        },
                        new
                        {
                            Id = 14,
                            BaseDuration = "2-4 часа",
                            BasePrice = 6000.00m,
                            Description = "Восстановление удаленных или поврежденных данных",
                            Name = "Восстановление данных"
                        },
                        new
                        {
                            Id = 15,
                            BaseDuration = "30 минут",
                            BasePrice = 1300.00m,
                            Description = "Установка нового вибромотора",
                            Name = "Замена вибромотора"
                        },
                        new
                        {
                            Id = 16,
                            BaseDuration = "1-2 часа",
                            BasePrice = 2200.00m,
                            Description = "Настройка или замена модуля Wi-Fi",
                            Name = "Ремонт Wi-Fi модуля"
                        },
                        new
                        {
                            Id = 17,
                            BaseDuration = "20 минут",
                            BasePrice = 800.00m,
                            Description = "Установка нового SIM-лотка",
                            Name = "Замена SIM-лотка"
                        },
                        new
                        {
                            Id = 18,
                            BaseDuration = "1 час",
                            BasePrice = 1400.00m,
                            Description = "Ремонт или замена кнопок регулировки громкости",
                            Name = "Замена кнопок громкости"
                        },
                        new
                        {
                            Id = 19,
                            BaseDuration = "1-2 часа",
                            BasePrice = 3500.00m,
                            Description = "Чистка и проверка системы охлаждения устройства",
                            Name = "Устранение перегрева"
                        },
                        new
                        {
                            Id = 20,
                            BaseDuration = "1-2 часа",
                            BasePrice = 4000.00m,
                            Description = "Полная замена дисплейного модуля",
                            Name = "Замена дисплея"
                        },
                        new
                        {
                            Id = 21,
                            BaseDuration = "1-2 часа",
                            BasePrice = 2500.00m,
                            Description = "Восстановление или замена модуля Bluetooth",
                            Name = "Ремонт Bluetooth модуля"
                        },
                        new
                        {
                            Id = 22,
                            BaseDuration = "40 минут",
                            BasePrice = 1700.00m,
                            Description = "Ремонт или замена аудиоразъема",
                            Name = "Замена разъема наушников"
                        },
                        new
                        {
                            Id = 23,
                            BaseDuration = "30 минут",
                            BasePrice = 900.00m,
                            Description = "Очистка устройства от вирусов",
                            Name = "Удаление вирусов"
                        },
                        new
                        {
                            Id = 24,
                            BaseDuration = "30 минут",
                            BasePrice = 800.00m,
                            Description = "Настройка синхронизации данных с облаком или ПК",
                            Name = "Настройка синхронизации"
                        },
                        new
                        {
                            Id = 25,
                            BaseDuration = "1-2 часа",
                            BasePrice = 2800.00m,
                            Description = "Ремонт или замена антенного модуля",
                            Name = "Ремонт антенны"
                        },
                        new
                        {
                            Id = 26,
                            BaseDuration = "1 час",
                            BasePrice = 2500.00m,
                            Description = "Установка нового NFC-модуля",
                            Name = "Замена модуля NFC"
                        },
                        new
                        {
                            Id = 27,
                            BaseDuration = "2-4 часа",
                            BasePrice = 8000.00m,
                            Description = "Полная замена материнской платы",
                            Name = "Замена системной платы"
                        },
                        new
                        {
                            Id = 28,
                            BaseDuration = "30 минут",
                            BasePrice = 1200.00m,
                            Description = "Снятие блокировки устройства (пароль, граф. ключ)",
                            Name = "Удаление блокировки"
                        },
                        new
                        {
                            Id = 29,
                            BaseDuration = "2-3 часа",
                            BasePrice = 4500.00m,
                            Description = "Полная замена корпуса устройства",
                            Name = "Замена корпуса"
                        },
                        new
                        {
                            Id = 30,
                            BaseDuration = "1 час",
                            BasePrice = 3000.00m,
                            Description = "Установка нового модуля задней камеры",
                            Name = "Замена задней камеры"
                        },
                        new
                        {
                            Id = 31,
                            BaseDuration = "1-2 часа",
                            BasePrice = 3500.00m,
                            Description = "Ремонт и восстановление IMEI устройства",
                            Name = "Восстановление IMEI"
                        },
                        new
                        {
                            Id = 32,
                            BaseDuration = "1 час",
                            BasePrice = 1600.00m,
                            Description = "Установка нового шлейфа",
                            Name = "Замена шлейфа"
                        },
                        new
                        {
                            Id = 33,
                            BaseDuration = "20 минут",
                            BasePrice = 700.00m,
                            Description = "Восстановление или настройка аккаунта",
                            Name = "Настройка учетной записи"
                        },
                        new
                        {
                            Id = 34,
                            BaseDuration = "1 час",
                            BasePrice = 1400.00m,
                            Description = "Установка нового датчика",
                            Name = "Замена датчика приближения"
                        },
                        new
                        {
                            Id = 35,
                            BaseDuration = "30 минут",
                            BasePrice = 1200.00m,
                            Description = "Проверка и ремонт зарядного адаптера",
                            Name = "Ремонт зарядного устройства"
                        },
                        new
                        {
                            Id = 36,
                            BaseDuration = "40 минут",
                            BasePrice = 1500.00m,
                            Description = "Замена модуля датчика освещения",
                            Name = "Замена датчика освещения"
                        },
                        new
                        {
                            Id = 37,
                            BaseDuration = "20 минут",
                            BasePrice = 600.00m,
                            Description = "Установка и настройка необходимых приложений",
                            Name = "Установка приложений"
                        },
                        new
                        {
                            Id = 38,
                            BaseDuration = "1-2 часа",
                            BasePrice = 2700.00m,
                            Description = "Ремонт или замена GPS-модуля",
                            Name = "Ремонт GPS"
                        },
                        new
                        {
                            Id = 39,
                            BaseDuration = "1 час",
                            BasePrice = 2000.00m,
                            Description = "Замена поврежденного разъема SIM",
                            Name = "Ремонт разъема SIM"
                        },
                        new
                        {
                            Id = 40,
                            BaseDuration = "1 час",
                            BasePrice = 2800.00m,
                            Description = "Установка нового модуля фронтальной камеры",
                            Name = "Замена передней камеры"
                        },
                        new
                        {
                            Id = 41,
                            BaseDuration = "30 минут",
                            BasePrice = 900.00m,
                            Description = "Настройка маршрутизатора и подключения устройства",
                            Name = "Настройка роутинга"
                        },
                        new
                        {
                            Id = 42,
                            BaseDuration = "30 минут",
                            BasePrice = 1000.00m,
                            Description = "Установка нового стекла на камеру",
                            Name = "Замена стекла камеры"
                        },
                        new
                        {
                            Id = 43,
                            BaseDuration = "1 час",
                            BasePrice = 2200.00m,
                            Description = "Настройка или замена модуля отпечатка",
                            Name = "Ремонт датчика отпечатка пальца"
                        },
                        new
                        {
                            Id = 44,
                            BaseDuration = "15 минут",
                            BasePrice = 500.00m,
                            Description = "Установка нового защитного стекла",
                            Name = "Замена защитного стекла"
                        },
                        new
                        {
                            Id = 45,
                            BaseDuration = "20 минут",
                            BasePrice = 600.00m,
                            Description = "Удаление пыли и грязи из микрофона",
                            Name = "Чистка микрофона"
                        },
                        new
                        {
                            Id = 46,
                            BaseDuration = "40 минут",
                            BasePrice = 1500.00m,
                            Description = "Восстановление работы вибромотора",
                            Name = "Ремонт вибромотора"
                        },
                        new
                        {
                            Id = 47,
                            BaseDuration = "1 час",
                            BasePrice = 1800.00m,
                            Description = "Починка или разблокировка загрузчика",
                            Name = "Восстановление загрузчика"
                        },
                        new
                        {
                            Id = 48,
                            BaseDuration = "30 минут",
                            BasePrice = 1200.00m,
                            Description = "Замена контактов батареи",
                            Name = "Замена батарейного контакта"
                        },
                        new
                        {
                            Id = 49,
                            BaseDuration = "1 час",
                            BasePrice = 2000.00m,
                            Description = "Замена термопасты на процессоре устройства",
                            Name = "Замена термопасты"
                        },
                        new
                        {
                            Id = 50,
                            BaseDuration = "30 минут",
                            BasePrice = 800.00m,
                            Description = "Чистка или ремонт динамика",
                            Name = "Устранение шумов в динамике"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MobileRepair.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MobileRepair.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileRepair.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MobileRepair.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Device", b =>
                {
                    b.HasOne("MobileRepair.Data.ApplicationUser", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Order", b =>
                {
                    b.HasOne("MobileRepair.Data.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.OrderHistory", b =>
                {
                    b.HasOne("MobileRepair.Data.ApplicationUser", "EditUser")
                        .WithMany()
                        .HasForeignKey("EditUserId");

                    b.HasOne("MobileRepair.Data.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EditUser");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.OrderService", b =>
                {
                    b.HasOne("MobileRepair.Data.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileRepair.Data.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MobileRepair.Data.Models.Payment", b =>
                {
                    b.HasOne("MobileRepair.Data.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
