namespace Space.Data;
public sealed class Roket
{
    public long Id {get; set;}
    public string Name {get; set;}
    public Type type {get; set;}
    public string mission {get; set;}
}
public enum Type
{
    military  = 1,
    civil = 2,
    research =3
}