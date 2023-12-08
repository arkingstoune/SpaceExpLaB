namespace Space.Data;

interface IRoketDb
{
     ValueTask<bool> CreateRoketAsync (Roket roket, CancellationToken token = default);
     ValueTask<int> CountRoketAsync(CancellationToken token);
     ValueTask<bool> UpdateRoketMissionAsync(long roketid, string mission, CancellationToken token);
     ValueTask<Roket> ShowdataAsync (long roketid, CancellationToken token = default);
 
}