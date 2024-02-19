﻿// <auto-generated />
using System;
using EmployeeManagement.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.API.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.API.Models.DailyTimeTracking", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"));

                    b.Property<TimeSpan>("CheckInTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("CheckOutTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("RecordID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("DailyTimeTrackings");

                    b.HasData(
                        new
                        {
                            RecordID = 1,
                            CheckInTime = new TimeSpan(0, 8, 0, 0, 0),
                            CheckOutTime = new TimeSpan(0, 17, 0, 0, 0),
                            Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeID = 1
                        });
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("PositionID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Address = "123 Main St",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            HireDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Doe",
                            PhoneNumber = "123-456-7890",
                            PositionID = 1,
                            Salary = 50000m
                        });
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.MonthlySalary", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SalaryPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalHoursWorked")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("RecordID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("MonthlySalaries");

                    b.HasData(
                        new
                        {
                            RecordID = 1,
                            EmployeeID = 1,
                            Month = "January",
                            SalaryPaid = 50000m,
                            TotalHoursWorked = 160m,
                            Year = 2024
                        });
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionID"));

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionID");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionID = 1,
                            PositionName = "Pourer"
                        },
                        new
                        {
                            PositionID = 2,
                            PositionName = "Cutter"
                        },
                        new
                        {
                            PositionID = 3,
                            PositionName = "Glazer"
                        },
                        new
                        {
                            PositionID = 4,
                            PositionName = "Kiln Operator"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.DailyTimeTracking", b =>
                {
                    b.HasOne("EmployeeManagement.API.Models.Employee", "Employee")
                        .WithMany("DailyTimeTrackings")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.API.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.MonthlySalary", b =>
                {
                    b.HasOne("EmployeeManagement.API.Models.Employee", "Employee")
                        .WithMany("MonthlySalaries")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.Employee", b =>
                {
                    b.Navigation("DailyTimeTrackings");

                    b.Navigation("MonthlySalaries");
                });

            modelBuilder.Entity("EmployeeManagement.API.Models.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
