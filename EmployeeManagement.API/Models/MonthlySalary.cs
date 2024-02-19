using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API.Models;

public class MonthlySalary
{
    [Key]
    public int RecordID { get; set; }
    public int EmployeeID { get; set; }
    public string Month { get; set; }
    public int Year { get; set; }
    public decimal TotalHoursWorked { get; set; }
    public decimal SalaryPaid { get; set; }

    public Employee Employee { get; set; }
}