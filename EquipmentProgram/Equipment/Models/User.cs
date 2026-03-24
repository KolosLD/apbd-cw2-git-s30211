namespace Equipment;

public abstract class User
{
 public string Id { get; private set; }   
 public string FirstName { get; set; }
 public string LastName { get; set; }
  
 public abstract int MaxRentalLimit { get; }
 
 protected User(string id, string firstName, string lastName)
 {
 Id = Guid.NewGuid().ToString().Substring(0, 8);
 FirstName = firstName;
 LastName = lastName;
 }
 
 
}