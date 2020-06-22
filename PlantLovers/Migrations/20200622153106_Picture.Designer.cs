﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantLovers;

namespace PlantLovers.Migrations
{
    [DbContext(typeof(PlantLoversDbContext))]
    [Migration("20200622153106_Picture")]
    partial class Picture
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlantLovers.DataModel.Flower", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Picture");

                    b.Property<string>("PlantDescription")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("PlantPrice");

                    b.HasKey("ID");

                    b.ToTable("Flowers");
                });
#pragma warning restore 612, 618
        }
    }
}
