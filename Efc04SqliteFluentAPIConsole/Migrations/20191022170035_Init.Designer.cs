﻿// <auto-generated />
using Efc04SqliteFluentAPIConsole.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Efc04SqliteFluentAPIConsole.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191022170035_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Efc04SqliteFluentAPIConsole.Data.Classroom", b =>
                {
                    b.Property<int>("ClassroomIdentificator")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ClassroomIdentificator");

                    b.ToTable("Classrooms");

                    b.HasData(
                        new
                        {
                            ClassroomIdentificator = 1,
                            Name = "P1"
                        },
                        new
                        {
                            ClassroomIdentificator = 2,
                            Name = "P2"
                        },
                        new
                        {
                            ClassroomIdentificator = 3,
                            Name = "P3"
                        },
                        new
                        {
                            ClassroomIdentificator = 4,
                            Name = "P4"
                        });
                });

            modelBuilder.Entity("Efc04SqliteFluentAPIConsole.Data.Student", b =>
                {
                    b.Property<int>("StudentIdentificator")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassroomId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasDefaultValue("Doe");

                    b.HasKey("StudentIdentificator");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentIdentificator = 1,
                            ClassroomId = 1,
                            Email = "a.a@school.cloud",
                            FirstName = "Alice",
                            LastName = "Astra"
                        },
                        new
                        {
                            StudentIdentificator = 2,
                            ClassroomId = 1,
                            Email = "b.b@school.cloud",
                            FirstName = "Bruce",
                            LastName = "Banner"
                        },
                        new
                        {
                            StudentIdentificator = 3,
                            ClassroomId = 2,
                            Email = "c.c@school.cloud",
                            FirstName = "Cyrus",
                            LastName = "Creed"
                        },
                        new
                        {
                            StudentIdentificator = 4,
                            ClassroomId = 2,
                            Email = "d.d@school.cloud",
                            FirstName = "Diane",
                            LastName = "Drake"
                        },
                        new
                        {
                            StudentIdentificator = 5,
                            ClassroomId = 2,
                            Email = "e.e@school.cloud",
                            FirstName = "Emilia",
                            LastName = "Evening"
                        });
                });

            modelBuilder.Entity("Efc04SqliteFluentAPIConsole.Data.Student", b =>
                {
                    b.HasOne("Efc04SqliteFluentAPIConsole.Data.Classroom", "Classroom")
                        .WithMany("Students")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}