using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API.Models;

public class DailyTimeTracking
{
    [Key]
    public int RecordID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan CheckInTime { get; set; }
    public TimeSpan CheckOutTime { get; set; }

    public Employee Employee { get; set; }
}