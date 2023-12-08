using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Space.Data;
namespace Space.Pres;

[ApiController]
[Route("spacexemlab")]
public sealed class EmployeeController : ControllerBase
{
    private readonly SpaceDbContext _db;
    public EmployeeController(SpaceDbContext spaceDbContext)
    {
        _db = spaceDbContext;
    }
    // public async ValueTask<int> CountRoketAsync(CancellationToken token)
    // {
    //     return await _db.Rokets.CountAsync(token);
    // }

    [HttpPost]
    public async ValueTask<Employee> CreateEmployeetAsync(Employee employee, CancellationToken token = default)
    {
        await _db.Employees.AddAsync(employee, token);
        await _db.SaveChangesAsync(token) ;
        return employee;

    }

    [HttpGet]
    public async ValueTask<IEnumerable<Employee>> ShowdataAsync( CancellationToken token = default)
    {
        return await _db.Employees.ToListAsync(token);
;
    }

    // public async ValueTask<bool> UpdateRoketMissionAsync(long roketid, string mission, CancellationToken token)
    // {
    //     Roket roket = await _db.Rokets.SingleAsync(o => o.Id == roketid, token);
    //     roket.Mission = mission;
    //     _db.Update(roket);
    //     return await _db.SaveChangesAsync(token) > 0;
        
    // }
}