using Microsoft.EntityFrameworkCore;
namespace Space.Data;

public sealed class EfCoreEmployeeRepository : IEmployeeDb
{
    private readonly SpaceDbContext _db;
    public EfCoreEmployeeRepository(SpaceDbContext spaceDbContext)
    {
        _db = spaceDbContext;
    }
    public async ValueTask<int> CountEmployeeAsync(CancellationToken token)
    {
        return await _db.Employees.CountAsync(token);
    }

    public async ValueTask<bool> CreateEmployeeAsync(Employee employee, CancellationToken token = default)
    {
        await _db.Employees.AddAsync(employee,token);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<Employee> ShowdataAsync(long orderid, CancellationToken token = default)
    {
        Employee employee = await _db.Employees.SingleAsync(o => o.Id == orderid, token);
        return employee;
    }
}