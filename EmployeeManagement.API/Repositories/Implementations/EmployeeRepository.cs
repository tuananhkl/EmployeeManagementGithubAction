using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Repositories.Implementations;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(EmployeeContext context) : base(context)
    {
    }
}