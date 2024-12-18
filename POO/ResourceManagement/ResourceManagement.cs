using POO.Resources;
using POO.Equipments;
using POO.Occurrences;

namespace POO.ResourceManagement;
public class ResourceManagement
{
    private List<Occurrence> occurrences = new List<Occurrence>();
    private List<Resource> resources = new List<Resource>();
    private List<Equipment> equipments = new List<Equipment>();

    public void AdicionarOccurrence(Occurrence Occurrence)
    {
        occurrences.Add(Occurrence);
    }

    public void AddResources(Resource Resources)
    {
        resources.Add(Resources);
    }

    public void AddEquipament(Equipment Equipment)
    {
        equipments.Add(Equipment);
    }

    public void AddResources(int OccurrenceId, List<int> resourcesIds, List<int> equipmentIds)
    {
        var Occurrence = occurrences.FirstOrDefault(o => o.Id == OccurrenceId);

        if (Occurrence != null)
        {
            foreach (var resourceID in resourcesIds)
            {
                var resource = resources.FirstOrDefault(p => p.Id == resourceID);
                if (resource != null)
                    Occurrence.AddResources(resource);
            }

            foreach (var equipmentId in equipmentIds)
            {
                var equipment = equipments.FirstOrDefault(e => e.Id == equipmentId);
                if (equipment != null && equipment.Available)
                {
                    //equipments.Use();
                    Occurrence.AddEquipment(equipment);
                }
            }
        }
    }
}
