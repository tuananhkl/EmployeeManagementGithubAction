namespace EmployeeManagement.API.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task Insert(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}