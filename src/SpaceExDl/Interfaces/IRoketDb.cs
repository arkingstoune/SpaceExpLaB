namespace Space.Data;

interface IRoket
{
     ValueTask<bool> CreateRoket (Roket roket, CancellationToken token = default);
     ValueTask<int> CountRoket(CancellationToken token);
     ValueTask<bool> UpdateRoketMission(long roketid, string mission, CancellationToken token);
}