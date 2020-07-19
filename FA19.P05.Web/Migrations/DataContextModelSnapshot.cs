﻿// <auto-generated />
using System;
using FA19.P05.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FA19.P05.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FA19.P05.Web.Features.Authorization.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Authorization.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Authorization.UserFavorites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName", "InventoryId")
                        .IsUnique();

                    b.ToTable("UserFavorites");
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Authorization.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("FA19.P05.Web.Features.CreditScores.CreditScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreditNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CreditScore");
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Dealerships.Dealership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OpenHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("SalesPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Dealership");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OpenHours = "9-5",
                            SalesPhoneNumber = "+19857431545",
                            StoreName = "Gator Auto"
                        },
                        new
                        {
                            Id = 2,
                            OpenHours = "9-5",
                            SalesPhoneNumber = "+19857283746",
                            StoreName = "Gator Auto"
                        });
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Inventory.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("AddedToStockUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("BaseCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DealershipId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DealershipId");

                    b.ToTable("InventoryItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedToStockUtc = new DateTimeOffset(new DateTime(2019, 11, 30, 1, 14, 55, 50, DateTimeKind.Unspecified).AddTicks(1185), new TimeSpan(0, 0, 0, 0, 0)),
                            BaseCost = 3000m,
                            DealershipId = 1,
                            Image = "https://i.imgur.com/xJYcO50.png",
                            Make = "NISSAN",
                            Model = "Sentra",
                            VIN = "3N1CB51D96L487364",
                            Year = 2006
                        },
                        new
                        {
                            Id = 2,
                            AddedToStockUtc = new DateTimeOffset(new DateTime(2019, 11, 30, 1, 14, 55, 50, DateTimeKind.Unspecified).AddTicks(2413), new TimeSpan(0, 0, 0, 0, 0)),
                            BaseCost = 20000m,
                            DealershipId = 1,
                            Image = "https://i.imgur.com/rD8ShNd.png",
                            Make = "FORD",
                            Model = "Fusion",
                            VIN = "3FAHP0JA3CR394884",
                            Year = 2012
                        },
                        new
                        {
                            Id = 3,
                            AddedToStockUtc = new DateTimeOffset(new DateTime(2019, 11, 30, 1, 14, 55, 50, DateTimeKind.Unspecified).AddTicks(2434), new TimeSpan(0, 0, 0, 0, 0)),
                            BaseCost = 30000m,
                            DealershipId = 2,
                            Image = "https://i.imgur.com/oLsO8Bw.png",
                            Make = "FORD",
                            Model = "F150",
                            VIN = "1FTFW1CT6CFB64889",
                            Year = 2012
                        },
                        new
                        {
                            Id = 4,
                            AddedToStockUtc = new DateTimeOffset(new DateTime(2019, 11, 30, 1, 14, 55, 50, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 0, 0, 0, 0)),
                            BaseCost = 35000m,
                            DealershipId = 2,
                            Image = "https://i.imgur.com/gzpjD4f.png",
                            Make = "TOYOTA",
                            Model = "Prius Prime",
                            VIN = "JTDKARFP9J3071163",
                            Year = 2018
                        },
                        new
                        {
                            Id = 5,
                            AddedToStockUtc = new DateTimeOffset(new DateTime(2019, 11, 30, 1, 14, 55, 50, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 0, 0, 0, 0)),
                            BaseCost = 20000m,
                            DealershipId = 1,
                            Image = "https://i.imgur.com/5CDUcon.png",
                            Make = "TOYOTA",
                            Model = "Corolla",
                            VIN = "5YFBURHE5FP260426",
                            Year = 2015
                        });
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Inventory.InventoryOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("OptionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InventoryOption");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Make = "NISSAN",
                            Model = "Sentra",
                            OptionDescription = @"-Includes Floor Mats 
-Heated Seats",
                            Price = 4000m,
                            Year = 2006
                        },
                        new
                        {
                            Id = 2,
                            Make = "NISSAN",
                            Model = "Sentra",
                            OptionDescription = @"-Includes Floor Mats 
-Heated Seats 
-Bluetooth Radio",
                            Price = 4100m,
                            Year = 2006
                        },
                        new
                        {
                            Id = 3,
                            Make = "FORD",
                            Model = "F150",
                            OptionDescription = @"-Includes Floor Mats 
-Heated Seats 
-Bluetooth Radio",
                            Price = 35000m,
                            Year = 2012
                        });
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Inventory.MakeList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Make")
                        .IsUnique()
                        .HasFilter("[Make] IS NOT NULL");

                    b.ToTable("MakeList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Make = "NISSAN"
                        },
                        new
                        {
                            Id = 2,
                            Make = "FORD"
                        },
                        new
                        {
                            Id = 3,
                            Make = "TOYOTA"
                        });
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Inventory.MakeModelOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Make", "Model")
                        .IsUnique()
                        .HasFilter("[Make] IS NOT NULL AND [Model] IS NOT NULL");

                    b.ToTable("MakeModelOption");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Make = "NISSAN",
                            Model = "Sentra"
                        },
                        new
                        {
                            Id = 2,
                            Make = "FORD",
                            Model = "Fusion"
                        },
                        new
                        {
                            Id = 3,
                            Make = "FORD",
                            Model = "F150"
                        },
                        new
                        {
                            Id = 4,
                            Make = "TOYOTA",
                            Model = "Prius Prime"
                        },
                        new
                        {
                            Id = 5,
                            Make = "TOYOTA",
                            Model = "Corolla"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Authorization.UserRole", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Authorization.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA19.P05.Web.Features.Authorization.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FA19.P05.Web.Features.CreditScores.CreditScore", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Authorization.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Dealerships.Dealership", b =>
                {
                    b.OwnsOne("FA19.P05.Web.Features.Shared.Address", "Address", b1 =>
                        {
                            b1.Property<int>("DealershipId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(64)")
                                .HasMaxLength(64);

                            b1.Property<string>("Line1")
                                .HasColumnType("nvarchar(64)")
                                .HasMaxLength(64);

                            b1.Property<string>("Line2")
                                .HasColumnType("nvarchar(64)")
                                .HasMaxLength(64);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(2)")
                                .HasMaxLength(2);

                            b1.Property<string>("ZipCode")
                                .HasColumnType("nvarchar(5)")
                                .HasMaxLength(5);

                            b1.HasKey("DealershipId");

                            b1.ToTable("Dealership");

                            b1.WithOwner()
                                .HasForeignKey("DealershipId");

                            b1.HasData(
                                new
                                {
                                    DealershipId = 1,
                                    City = "Hammond",
                                    Line1 = "101 Gator Dr.",
                                    Line2 = "",
                                    State = "LA",
                                    ZipCode = "70403"
                                },
                                new
                                {
                                    DealershipId = 2,
                                    City = "Slidell",
                                    Line1 = "101 Gator Dr.",
                                    Line2 = "",
                                    State = "LA",
                                    ZipCode = "70458"
                                });
                        });
                });

            modelBuilder.Entity("FA19.P05.Web.Features.Inventory.InventoryItem", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Dealerships.Dealership", "Dealership")
                        .WithMany()
                        .HasForeignKey("DealershipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Authorization.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Authorization.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Authorization.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FA19.P05.Web.Features.Authorization.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
