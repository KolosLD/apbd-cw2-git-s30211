namespace EquipmentProgram;

public class Employee : User
{
    public Employee(string id, string firstName, string lastName) : base(id, firstName, lastName)
    {
        
    }
    
    public override int MaxRentalLimit => 5;
    
}