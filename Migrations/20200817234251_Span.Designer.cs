﻿// <auto-generated />
using System;
using Architecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Architecture.Migrations
{
    [DbContext(typeof(ArchitectureContext))]
    [Migration("20200817234251_Span")]
    partial class Span
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Architecture.Models.Bridge", b =>
                {
                    b.Property<int>("BridgeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Architect");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<int>("Span");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("BridgeId");

                    b.ToTable("Bridges");

                    b.HasData(
                        new
                        {
                            BridgeId = 1,
                            Architect = "Joseph Strauss",
                            City = "San Francisco",
                            Country = "USA",
                            EndDate = new DateTime(1937, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Golden Gate",
                            Span = 1280,
                            StartDate = new DateTime(1933, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
