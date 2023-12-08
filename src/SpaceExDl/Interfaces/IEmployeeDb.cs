namespace Space.Data;

interface IEmployeeDb
{
     ValueTask<bool> CreateEmployeeAsync (Employee employee, CancellationToken token = default);
     ValueTask<int> CountEmployeeAsync(CancellationToken token);
     ValueTask<Employee> ShowdataAsync (long orderid, CancellationToken token = default);
 
}