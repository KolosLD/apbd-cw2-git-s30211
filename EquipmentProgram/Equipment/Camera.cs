namespace EquipmentProgram;

public class Camera : Equipment
{
    public string Zoom {set; get; }
    public string Model {set; get; }
    public string MemoryCardType{set; get; }

    public Camera(string name, string zoom, string model, string memoryCardType) : base(name)
    {
        Zoom = zoom;
        Model = model;
        MemoryCardType = memoryCardType;
    }



    public override string GetDetails() =>
        $"Camera: {Name} (ID: {Id}), Zoom: {Zoom}, Memory Card Type: {MemoryCardType}, Model: {Model},Available: {AvailabilityStatus}";

}