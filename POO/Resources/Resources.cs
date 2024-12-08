namespace POO_Resources;
public abstract class Resources
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int NIF { get; set; }
    public DateTime DateOfBirth { get; set; } 
    public string Household { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public int Type { get; set; }

    public Resources(int id, string name,int nif ,DateTime dateofbirth, string household,string zipcode,string city,int type)
    {
        Id = id;
        Name = name;
        NIF = nif;
        DateOfBirth = dateofbirth;
        Household = household;
        ZipCode = zipcode;
        City = city;
        Type = type;

    }
}