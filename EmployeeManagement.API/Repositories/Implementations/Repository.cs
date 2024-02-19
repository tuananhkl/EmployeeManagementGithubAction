using EmployeeManagement.API.Data;
using EmployeeManagement.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly DbContext Context;

    public Repository(EmployeeContext context)
    {
        Context = context;
    }

    public IQueryable<T> GetAll()
    {
        return Context.Set<T>().AsQueryable();
    }

    public async Task<T> GetById(int id)
    {
        return await Context.Set<T>().FindAsync(id);
    }

    public async Task Insert(T entity)
    {
        await Context.Set<T>().AddAsync(entity);
    }

    public async Task Update(T entity)
    {
        Context.Set<T>().Attach(entity);
        Context.Entry(entity).State = EntityState.Modified;
        await Task.CompletedTask;
    }

    public async Task Delete(T entity)
    {
        Context.Set<T>().Remove(entity);
        await Task.CompletedTask;
    }
}