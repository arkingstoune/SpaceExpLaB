namespace Space.Data;
public sealed class Employee
{
    public long Id {get; set;}
    public  string SpecialIdentity {get; set;}
    public  string FirstName {get; set;}
    public  string LastName {get; set;}
    public  string MiddleName {get; set;}
    public  short Age {get; set;}
    public  Gender Gender {get; set;}
    
}
public enum Gender
{
    male = 1,
    female =2
}