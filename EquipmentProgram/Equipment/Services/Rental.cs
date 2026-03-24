namespace Equipment;

public class Rental
{
    public string Id { get; private set; }
    public User User { get; set; }
    public Equipment Equipment { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }


    public Rental(User user, Equipment equipment, int days)
    {
        Id = Guid.NewGuid().ToString().Substring(0, 8);;
        User = user;
        Equipment = equipment;
        RentalDate = DateTime.Now;
        DueDate = DateTime.Now.AddDays(days);
    }

    public decimal CalculatePenalty(decimal penaltyPerDay)
    {
        if (!ReturnDate.HasValue || ReturnDate <= DueDate) return 0;
        var delay = (ReturnDate.Value - DueDate).Days;
        return delay * penaltyPerDay;
    }


}