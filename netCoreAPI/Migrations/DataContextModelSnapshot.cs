﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netCoreAPI.Services;

namespace netCoreAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("netCoreAPI.Services.NotToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsComplete");

                    b.Property<int>("Priority");

                    b.HasKey("Id");

                    b.ToTable("NotToDos");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2020, 1, 27, 12, 33, 47, 729, DateTimeKind.Local).AddTicks(4925),
                            Description = "Clean house",
                            IsComplete = true,
                            Priority = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2020, 1, 27, 12, 33, 47, 729, DateTimeKind.Local).AddTicks(4938),
                            Description = "Bake cake",
                            IsComplete = false,
                            Priority = 3
                        });
                });

            modelBuilder.Entity("netCoreAPI.Services.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsComplete");

                    b.Property<int>("Priority");

                    b.HasKey("Id");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2020, 1, 27, 12, 33, 47, 726, DateTimeKind.Local).AddTicks(6949),
                            Description = "Sleep",
                            IsComplete = true,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2020, 1, 27, 12, 33, 47, 729, DateTimeKind.Local).AddTicks(2614),
                            Description = "Sing",
                            IsComplete = false,
                            Priority = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
