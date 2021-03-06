// <auto-generated />
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
    [Migration("20210414130647_Added city seeding 2")]
    partial class Addedcityseeding2
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
                            CityId = new Guid("c269c938-f236-4746-9eaa-3f384e41e375"),
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
