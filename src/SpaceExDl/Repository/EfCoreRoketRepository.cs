using Microsoft.EntityFrameworkCore;
namespace Space.Data;

public sealed class EfCoreRoketRepository : IRoketDb
{ 
    private readonly SpaceDbContext _db;
    public EfCoreRoketRepository(SpaceDbContext spaceDbContext)
    {
        _db = spaceDbContext;
    }
    public async ValueTask<int> CountRoketAsync(CancellationToken token)
    {
        return await _db.Rokets.CountAsync(token);
    }
    public async ValueTask<bool> CreateRoketAsync(Roket roket, CancellationToken token = default)
    {
        await _db.Rokets.AddAsync(roket, token);
        return  await _db.SaveChangesAsync(token) > 0;

    }

    public async ValueTask<Roket> ShowdataAsync(long roketid, CancellationToken token = default)
    {
        Roket roket = await _db.Rokets.SingleAsync(o => o.Id == roketid, token);
        return roket;
    }

    public async ValueTask<bool> UpdateRoketMissionAsync(long roketid, string mission, CancellationToken token)
    {
        Roket roket = await _db.Rokets.SingleAsync(o => o.Id == roketid, token);
        roket.Mission = mission;
        _db.Update(roket);
        return await _db.SaveChangesAsync(token) > 0;
        
    }

   
}