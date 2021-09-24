﻿// <auto-generated />
using System;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(SuperHeroContext))]
    partial class SuperHeroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.SuperHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("alias");

                    b.Property<string>("HideOuts")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("hideout");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("superhero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Superman",
                            HideOuts = "NYC apartment",
                            Name = "Peter Parker"
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Ironman",
                            HideOuts = "Dumpyard",
                            Name = "Tony Stark"
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Thor",
                            HideOuts = "Asgard",
                            Name = "Thor"
                        },
                        new
                        {
                            Id = 4,
                            Alias = "Shaktiman",
                            HideOuts = "tenant in a village",
                            Name = "Gangadhar"
                        });
                });

            modelBuilder.Entity("Data.Entities.SuperPower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("SuperPower");
                });

            modelBuilder.Entity("Data.Entities.SuperPower", b =>
                {
                    b.HasOne("Data.Entities.SuperHero", "Owner")
                        .WithMany("SuperPowers")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Data.Entities.SuperHero", b =>
                {
                    b.Navigation("SuperPowers");
                });
#pragma warning restore 612, 618
        }
    }
}
