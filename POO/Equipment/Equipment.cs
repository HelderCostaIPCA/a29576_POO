namespace POO_Equipment;
public class Equipment
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string SerialNumber {  get; set; }
    public string Type { get; set; }
    public bool Enable { get; set; }
    public bool Available { get; set; } = true;

    public Equipment(int id, string description, string serialnumber , bool enable ,string type)
    {
        Id = id;
        Description = description;
        SerialNumber = serialnumber;
        Enable = enable;
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