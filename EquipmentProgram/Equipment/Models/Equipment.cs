namespace EquipmentProgram;

public abstract class Equipment
{
    public string Id { get; private set; }
    public string Name { get; set; }
    public bool AvailabilityStatus { get; set; }


    protected Equipment(string name)
    {
        Id = Guid.NewGuid().ToString().Substring(0, 8);
        Name = name;
        AvailabilityStatus = true;
    }

    public abstract string GetDetails();
    
}