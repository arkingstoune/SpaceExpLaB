namespace Space.Data;

interface IEmployeeDb
{
     ValueTask<bool> CreateEmployee (Employee employee, CancellationToken token = default);
     ValueTask<int> CountEmployee(CancellationToken token);
}