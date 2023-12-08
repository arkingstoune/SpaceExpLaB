using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Space.Data;
namespace Space.Data;
[Table("employee")]
public sealed class Employee
{
    public long Id {get; set;}
    public  string SpecialIdentity {get; set;}
    public  string FirstName {get; set;}
    public  string LastName {get; set;}
    public  short Age {get; set;}
    // [Column("gender")]
   // public  Gender Gender {get; set;}
    public Roket roket {get; set;}
    
}

// public enum Gender
// {
//     male = 1,
//     female =2
// }