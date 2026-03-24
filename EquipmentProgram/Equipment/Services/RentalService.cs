namespace Equipment;

public class RentalService
{
    private readonly List<Rental> _rentals = new();
    private const decimal DailyPenaltyRate = 10.0m;


    public string RentItem(User user, Equipment equipment)
    {
        if (!equipment.AvailabilityStatus)
            return "Błąd: Sprzęt jest niedostępny ";
        
        int activeRentalsCount = _rentals.Count(r => r.UserId == user.Id && !r.IsReturned);
        if (activeRentalsCount >= user.MaxRentalLimit)
            return $"Błąd: użytkownik {user.LastName} przekroczył swój limit ({user.MaxRentalLimit}).";
        
        
        var newRental = new Rental(user.Id, equipment.Id, 7); 
        _rentals.Add(newRental);
        equipment.AvailabilityStatus = false; 

        return $"Skutecznie: {equipment.Name} wydawane użytkownikowi {user.LastName}. Identyfikator wynajmu: {newRental.Id}";
    }
    
    public string ReturnItem(Rental rental, Equipment equipment)
    {
        rental.MarkAsReturned();
        equipment.AvailabilityStatus = true; 

        decimal penalty = CalculatePenalty(rental);
        if (penalty > 0)
            return $"\nZwrócono towar. Naliczono opłatę za zwłokę.: {penalty} pln.";

        return "Przedmiot został zwrócony na czas. Bez żadnych kar.";
    }

    private decimal CalculatePenalty(Rental rental)
    {
        if (rental.ReturnDate <= rental.DueDate) return 0;
        
        var delay = (rental.ReturnDate.Value - rental.DueDate).Days;
        return delay * DailyPenaltyRate; 
    }
    
    public List<Rental> GetOverdueRentals() => _rentals.Where(r => r.IsOverdue).ToList();
    
    
    
}