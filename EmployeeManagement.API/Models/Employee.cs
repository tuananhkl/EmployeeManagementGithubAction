namespace EmployeeManagement.API.Models;

public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    public int PositionID { get; set; }
    public decimal Salary { get; set; }

    public Position Position { get; set; }
    public List<DailyTimeTracking> DailyTimeTrackings { get; set; }
    public List<MonthlySalary> MonthlySalaries { get; set; }
}