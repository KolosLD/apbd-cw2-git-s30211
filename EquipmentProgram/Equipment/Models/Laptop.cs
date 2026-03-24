namespace EquipmentProgram;

public class Laptop : Equipment
{
    public string Processor {set; get; }
    public string Model {set; get; }
    public string VideoCard{set; get; }

    public Laptop(string name, string processor, string model, string videoCard) : base(name)
    {
        Processor = processor;
        Model = model;
        VideoCard = videoCard;
    }



    public override string GetDetails() =>
        $"Laptop: {Name} (ID: {Id}), CPU: {Processor}, VideoCard: {VideoCard}, Model: {Model},Available: {AvailabilityStatus}";

}