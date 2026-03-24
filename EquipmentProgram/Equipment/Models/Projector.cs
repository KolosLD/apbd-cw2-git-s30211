namespace Equipment;

public class Projector : Equipment
{
    public string Resolution { get; set; }
    public int BrightnessLumens { get; set; }

    public Projector(string name, string resolution, int brightness) : base(name)
    {
        Resolution = resolution;
        BrightnessLumens = brightness;
    }

    public override string GetDetails() => 
        $"Projector: {Name} (ID: {Id}), Res: {Resolution}, Brightness: {BrightnessLumens}lm, Available: {AvailabilityStatus}";
}