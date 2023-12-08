using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Space.Data;
[Table("roket")]
public sealed class Roket
{
    public long Id {get; set;}
    
    public string Name {get; set;}
    public string type {get; set;}
    public string Mission {get; set;}
    public ICollection<Employee> employees {get; set;}
}
// public enum Type
// {
//     military  = 1,
//     civil = 2,
//     research =3
// }