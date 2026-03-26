Projekt System Wypozyczalni Sprzetu APBD Cwiczenia 2

Decyzje projektowe

Podzial odpowiedzialnosci
Kod zostal podzielony tak, aby kazda klasa miala jedno zadanie. Modele takie jak Equipment, User i Rental przechowuja tylko dane o obiektach. RentalService zawiera cala logike biznesowa. To tutaj sprawdzam, czy sprzet jest dostepny oraz czy uzytkownik nie przekroczyl swojego limitu. Program.cs sluzy do uruchomienia przykladowego scenariusza i komunikacji z uzytkownikiem.

Wykorzystanie dziedziczenia i polimorfizmu
Uzym dziedziczenia dla klas sprzetu jak Laptop, Projector i Camera. Dzieki temu wspolne pola sa w jednej klasie bazowej, a kazda podklasa ma swoje specyficzne parametry. Program rozroznia studentow z limitem 2 przedmioty oraz pracownikow z limitem 5 przedmioty i blokuje wypozyczenie po ich przekroczeniu. System automatycznie wylicza kare pieniezna, jesli faktyczna data zwrotu jest pozniejsza niz planowana.

Scenariusz demonstracyjny
Program po uruchomieniu wykonuje nastepujace kroki. Dodaje rozne rodzaje sprzetu do systemu i rejestruje uzytkownikow. Pokazuje poprawne wypozyczenie i zwrot sprzetu. Probuje wypozyczyc sprzet ponad limit lub gdy jest niedostepny, co konczy sie komunikatem o bledzie. Symuluje spozniony zwrot z naliczeniem kary i wyswietla raporty o stanie wypozyczalni.

