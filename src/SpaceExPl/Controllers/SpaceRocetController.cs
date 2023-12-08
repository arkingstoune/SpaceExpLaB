using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Space.Data;
namespace Space.Pres;

[ApiController]
[Route("spaceexroklab")]
public sealed class RoketControiller : ControllerBase
{
    private readonly SpaceDbContext _db;
    public RoketControiller(SpaceDbContext spaceDbContext)
    {
        _db = spaceDbContext;
    }
    // public async ValueTask<int> CountRoketAsync(CancellationToken token)
    // {
    //     return await _db.Rokets.CountAsync(token);
    // }

    [HttpPost]
    public async ValueTask<Roket> CreateRoketAsync(Roket roket, CancellationToken token = default)
    {
        await _db.Rokets.AddAsync(roket, token);
        await _db.SaveChangesAsync(token) ;
        return roket;

    }

    [HttpGet]
    public async ValueTask<IEnumerable<Roket>> ShowdataAsync( CancellationToken token = default)
    {
        return await _db.Rokets.ToListAsync(token);
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