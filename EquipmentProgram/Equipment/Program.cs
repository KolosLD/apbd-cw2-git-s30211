using Equipment;

var rentalService = new RentalService();

var laptop = new Laptop("Dell XPS", "i7", "9520", "RTX 3050");
var camera = new Camera("Canon R6", "10x", "Mark II", "SD V90");
var student = new Student("Ivan", "Ivanov");


Console.WriteLine(rentalService.RentItem(student, laptop));


Console.WriteLine(rentalService.RentItem(student, laptop)); 

var projector = new Projector("Epson EB", "4K", 3000);
Console.WriteLine(rentalService.RentItem(student, camera));    
Console.WriteLine(rentalService.RentItem(student, projector)); 


Console.WriteLine("\n--- Raport o zaległych czynszach ---");
foreach (var r in rentalService.GetOverdueRentals()) {
    Console.WriteLine($"\nWynajem {r.Id} zaległy!");

}



