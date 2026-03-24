namespace Equipment;

public class Employee : User
{
    public Employee(string firstName, string lastName) : base(firstName, lastName)
    {
        
    }
    
    public override int MaxRentalLimit => 5;
    
}