public abstract class Persons
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Function { get; set; }

    public Persons(int id, string name, string function)
    {
        Id = id;
        Name = name;
        Function = function;
    }
}