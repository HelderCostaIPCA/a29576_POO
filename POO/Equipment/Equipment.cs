namespace POO_Equipment;
public class Equipment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public bool Available { get; set; } = true;

    public Equipment(int id, string name, string type)
    {
        Id = id;
        Name = name;
        Type = type;
    }

    public void Use()
    {
        Available = false;
    }

    public void Free()
    {
        Available = true;
    }
}