using POO_Resources;

namespace POO_Resources;
public class Nurse : Resources
{
    public Nurse(int id, string name, int nif, DateTime dateofbirth, string household, string zipcode, string city, int type) : base(id, name, nif, dateofbirth, household, zipcode, city, type) { }
}