namespace Equipment;

public class Rental
{
    public string Id { get; private set; }
    public string UserId { get; private set; }
    public string EquipmentId { get; private set; }
    public DateTime RentalDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }


    public Rental(string userId, string equipmentId, int days)
    {
        Id = Guid.NewGuid().ToString().Substring(0, 8);;
        UserId = userId;
        EquipmentId = equipmentId;
        RentalDate = DateTime.Now;
        DueDate = DateTime.Now.AddDays(days);
    }
    
    
    public void MarkAsReturned()
    {
        ReturnDate = DateTime.Now;
    }
    
    public bool IsOverdue => ReturnDate == null && DateTime.Now > DueDate;
    public bool IsReturned => ReturnDate != null;

}