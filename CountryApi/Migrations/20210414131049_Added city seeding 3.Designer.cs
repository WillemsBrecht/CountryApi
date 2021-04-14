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
    [Migration("20210414131049_Added city seeding 3")]
    partial class Addedcityseeding3
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
                            CityId = new Guid("9ec01e17-c44a-432b-9d32-c2e0ac92299a"),
                            CountryISOCode = "BE",
                            Name = "Bruges",
                            Population = 0
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
                            Name = "Netherlands",
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
