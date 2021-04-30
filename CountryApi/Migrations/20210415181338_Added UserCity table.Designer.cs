﻿// <auto-generated />
using System;
using CountryApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CountryApi.Migrations
{
    [DbContext(typeof(VisitContext))]
    [Migration("20210415181338_Added UserCity table")]
    partial class AddedUserCitytable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CountryApi.Models.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryISOCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryISOCode");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = new Guid("28b28b96-6233-4f0c-a19b-adacb9b22342"),
                            CountryISOCode = "LUX",
                            Name = "Luxembourg City",
                            Population = 114303
                        },
                        new
                        {
                            CityId = new Guid("69e322ac-b6b0-40c0-bfc4-d91e085dbfd9"),
                            CountryISOCode = "LUX",
                            Name = "Echternach",
                            Population = 5614
                        },
                        new
                        {
                            CityId = new Guid("b496c2e5-ead9-4663-baa5-ad7b03f91b93"),
                            CountryISOCode = "BE",
                            Name = "Bruges",
                            Population = 118656
                        },
                        new
                        {
                            CityId = new Guid("3352e80a-526b-4437-9085-6c7f2e11193d"),
                            CountryISOCode = "BE",
                            Name = "Ghent",
                            Population = 466000
                        },
                        new
                        {
                            CityId = new Guid("89aaca47-e2ce-4501-aeec-a721dd7ecf2f"),
                            CountryISOCode = "BE",
                            Name = "Antwerp",
                            Population = 523248
                        },
                        new
                        {
                            CityId = new Guid("a349ce6a-ed96-469c-bbab-e5bf2dda852e"),
                            CountryISOCode = "BE",
                            Name = "Brussels",
                            Population = 2081000
                        },
                        new
                        {
                            CityId = new Guid("46e7c825-de9b-4427-a37f-261001370fdd"),
                            CountryISOCode = "BE",
                            Name = "Liège",
                            Population = 195965
                        },
                        new
                        {
                            CityId = new Guid("a4ed6caa-8573-417f-96fd-35a1c6ef77e6"),
                            CountryISOCode = "BE",
                            Name = "Tournai",
                            Population = 69083
                        },
                        new
                        {
                            CityId = new Guid("bf879fb7-495e-4dce-a366-045eb552d1fb"),
                            CountryISOCode = "FR",
                            Name = "Strasbourg",
                            Population = 272222
                        },
                        new
                        {
                            CityId = new Guid("9fa9bb93-003f-4d41-8791-5bca90c1dc41"),
                            CountryISOCode = "FR",
                            Name = "Paris",
                            Population = 11017000
                        },
                        new
                        {
                            CityId = new Guid("ee1e18f7-8b7d-45f5-9c17-c23aafbc79a3"),
                            CountryISOCode = "FR",
                            Name = "Calais",
                            Population = 72929
                        },
                        new
                        {
                            CityId = new Guid("413c3255-5122-4ed1-8833-6ae771265333"),
                            CountryISOCode = "FR",
                            Name = "Calais",
                            Population = 868277
                        },
                        new
                        {
                            CityId = new Guid("dc559bc6-22f2-4f03-8573-c6a3d144b203"),
                            CountryISOCode = "FR",
                            Name = "Bordeaux",
                            Population = 257068
                        },
                        new
                        {
                            CityId = new Guid("665115cc-b429-4946-a7d0-d37e0b8fce23"),
                            CountryISOCode = "NL",
                            Name = "Rotterdam",
                            Population = 651446
                        },
                        new
                        {
                            CityId = new Guid("3e53b2fa-94e5-47db-95ac-489e2cb367e7"),
                            CountryISOCode = "NL",
                            Name = "Amsterdam",
                            Population = 1149000
                        },
                        new
                        {
                            CityId = new Guid("7be043a5-7c59-4ba1-ad62-23c183f9c154"),
                            CountryISOCode = "DE",
                            Name = "Berlin",
                            Population = 3562000
                        },
                        new
                        {
                            CityId = new Guid("bc05a63d-f02b-48fb-8b7a-da0b207eba7f"),
                            CountryISOCode = "DE",
                            Name = "Frankfurt",
                            Population = 777000
                        },
                        new
                        {
                            CityId = new Guid("6cf5ad79-ca0f-4e03-8572-84500cb9bf89"),
                            CountryISOCode = "DE",
                            Name = "Hamburg",
                            Population = 1790000
                        },
                        new
                        {
                            CityId = new Guid("5fcea13c-1c67-4e2d-9642-17c9cea029be"),
                            CountryISOCode = "DE",
                            Name = "Munich",
                            Population = 1558395
                        },
                        new
                        {
                            CityId = new Guid("ff132038-0670-4cf3-8816-b3e774447213"),
                            CountryISOCode = "DE",
                            Name = "Trier",
                            Population = 111528
                        });
                });

            modelBuilder.Entity("CountryApi.Models.Country", b =>
                {
                    b.Property<string>("ISOCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("ISOCode");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            ISOCode = "BE",
                            Name = "Belgium",
                            Population = 11629113
                        },
                        new
                        {
                            ISOCode = "LUX",
                            Name = "Luxembourg",
                            Population = 613894
                        },
                        new
                        {
                            ISOCode = "FR",
                            Name = "France",
                            Population = 65387226
                        },
                        new
                        {
                            ISOCode = "DE",
                            Name = "Germany",
                            Population = 83995211
                        },
                        new
                        {
                            ISOCode = "NL",
                            Name = "The Netherlands",
                            Population = 17164721
                        });
                });

            modelBuilder.Entity("CountryApi.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CountryApi.Models.UserCity", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "CityId");

                    b.ToTable("UserCities");
                });

            modelBuilder.Entity("CountryApi.Models.UserCountry", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISOCode")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "ISOCode");

                    b.ToTable("UserCountries");
                });

            modelBuilder.Entity("CountryApi.Models.City", b =>
                {
                    b.HasOne("CountryApi.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryISOCode");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CountryApi.Models.UserCity", b =>
                {
                    b.HasOne("CountryApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CountryApi.Models.UserCountry", b =>
                {
                    b.HasOne("CountryApi.Models.User", "User")
                        .WithMany("VisitedCountries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CountryApi.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("CountryApi.Models.User", b =>
                {
                    b.Navigation("VisitedCountries");
                });
#pragma warning restore 612, 618
        }
    }
}