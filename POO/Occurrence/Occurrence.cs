public class Occurrence
{
    public int Id { get; set; }
    public string Localization { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public List<Persons>AllocatedPersons { get; set; } = new List<Persons>();
    public List<Equipment> AllocatedEquipments { get; set; } = new List<Equipment>();

    public Occurrence(int id, string localization, string description)
    {
        Id = id;
        Localization = localization;
        Description = description;
        Date = DateTime.Now;
    }

    public void AddPersons(Persons persons)
    {
        AllocatedPersons.Add(persons);
    }

    public void AddEquipment(Equipment equipment)
    {
        AllocatedEquipments.Add(equipment);
    }
}
