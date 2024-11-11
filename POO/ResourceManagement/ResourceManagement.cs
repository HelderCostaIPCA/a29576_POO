public class ResourceManagement
{
    private List<Occurrence> occurrences = new List<Occurrence>();
    private List<Persons> persons = new List<Persons>();
    private List<Equipment> equipments = new List<Equipment>();

    public void AdicionarOccurrence(Occurrence Occurrence)
    {
        occurrences.Add(Occurrence);
    }

    public void AddPersons(Persons Persons)
    {
        persons.Add(Persons);
    }

    public void AddEquipament(Equipment Equipment)
    {
        equipments.Add(Equipment);
    }

    public void AddResources(int OccurrenceId, List<int> personIds, List<int> equipmentIds)
    {
        var Occurrence = occurrences.FirstOrDefault(o => o.Id == OccurrenceId);

        if (Occurrence != null)
        {
            foreach (var personID in personIds)
            {
                var person = persons.FirstOrDefault(p => p.Id == personID);
                if (person != null)
                    Occurrence.AddPersons(person);
            }

            foreach (var equipmentId in equipmentIds)
            {
                var equipment = equipments.FirstOrDefault(e => e.Id == equipmentId);
                if (equipment != null && equipment.Available)
                {
                    equipment.Use();
                    Occurrence.AddEquipment(equipment);
                }
            }
        }
    }
}
