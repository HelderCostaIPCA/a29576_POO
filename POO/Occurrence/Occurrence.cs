using POO_Equipment;
using POO_Resources;
using System.Drawing.Drawing2D;

namespace POO_Occurrence;
public class Occurrence
{
    public int Id { get; set; }
    public string Household { get; set; }
    public string Description { get; set; }
    public string Coordinates { get; set; }
    public string ZipCode { get; set; }
    public DateTime Date { get; set; }
    public List<Resources> AllocatedResources { get; set; } = new List<Resources>();
    public List<Equipment> AllocatedEquipments { get; set; } = new List<Equipment>();

    public Occurrence(int id, string description, string coordinates, string household, string zipcode)
    {
        Id = id;
        Description = description;
        Coordinates = coordinates;
        Household = household;
        ZipCode = zipcode;
        Date = DateTime.Now;
    }

    public void AddResources(Resources resources)
    {
        AllocatedResources.Add(resources);
    }

    public void AddEquipment(Equipment equipment)
    {
        AllocatedEquipments.Add(equipment);
    }
}
