using EmployeeManagement.API.Models;
using EmployeeManagement.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    // GET: api/Employee
    [HttpGet]
    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await _employeeRepository.GetAll();
    }

    // GET: api/Employee/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        var employee = await _employeeRepository.GetById(id);

        if (employee == null)
        {
            return NotFound();
        }

        return employee;
    }

    // PUT: api/Employee/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutEmployee(int id, Employee employee)
    {
        if (id != employee.EmployeeID)
        {
            return BadRequest();
        }

        _employeeRepository.Update(employee);

        return NoContent();
    }

    // POST: api/Employee
    [HttpPost]
    public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
    {
        _employeeRepository.Insert(employee);
        return CreatedAtAction("GetEmployee", new { id = employee.EmployeeID }, employee);
    }

    // DELETE: api/Employee/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var employee = await _employeeRepository.GetById(id);
        if (employee == null)
        {
            return NotFound();
        }

        _employeeRepository.Delete(employee);

        return NoContent();
    }
}
