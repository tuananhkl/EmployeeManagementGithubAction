using EmployeeManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Data;

public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<DailyTimeTracking> DailyTimeTrackings { get; set; }
    public DbSet<MonthlySalary> MonthlySalaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.Salary).HasPrecision(18, 2);
            modelBuilder.Entity<MonthlySalary>().Property(m => m.SalaryPaid).HasPrecision(18, 2);
            modelBuilder.Entity<MonthlySalary>().Property(m => m.TotalHoursWorked).HasPrecision(18, 2);
            
            modelBuilder.Entity<Position>().HasData(
                new Position { PositionID = 1, PositionName = "Pourer" },
                new Position { PositionID = 2, PositionName = "Cutter" },
                new Position { PositionID = 3, PositionName = "Glazer" },
                new Position { PositionID = 4, PositionName = "Kiln Operator" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe", Gender = "Male", Address = "123 Main St", Email = "john.doe@example.com", PhoneNumber = "123-456-7890", HireDate = new DateTime(2020, 1, 1), PositionID = 1, Salary = 50000 }
                // Add more employees here
            );

            modelBuilder.Entity<DailyTimeTracking>().HasData(
                new DailyTimeTracking { RecordID = 1, EmployeeID = 1, Date = new DateTime(2024, 1, 1), CheckInTime = new TimeSpan(8, 0, 0), CheckOutTime = new TimeSpan(17, 0, 0) }
                // Add more daily time tracking records here
            );

            modelBuilder.Entity<MonthlySalary>().HasData(
                new MonthlySalary { RecordID = 1, EmployeeID = 1, Month = "January", Year = 2024, TotalHoursWorked = 160, SalaryPaid = 50000 }
                // Add more monthly salary records here
            );
        }
}