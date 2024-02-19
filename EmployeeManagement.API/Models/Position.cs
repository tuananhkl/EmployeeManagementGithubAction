namespace EmployeeManagement.API.Models;

public class Position
{
    public int PositionID { get; set; }
    public string PositionName { get; set; }

    public List<Employee> Employees { get; set; }
}