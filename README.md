# Zadanie-Rekrutacyjne-.NET-SQL-Developer

## Technologie
* **C#**,
* **.NET WinForms**,
* **Entity Framework**.

## Informacje
Solucja została podzielona na dwa projekty: **Model** odpowiadający za logikę i dostęp do danych oraz **Prezentacja** odpowiadający za warstwę prezentacji.
Podczas korzystania **Entity Framework** wykorzystałem metodę **Code First**. Z pakietu DevExpress wykorzystałem kontrolkę **ComboBoxEdit**.

## Opis
Aplikacja wyświetla rekordy bazy danych oraz umożliwia wyszukiwanie wśród niej, aby to zrobić podajemy szukaną wartość oraz w której kolumnie 
(lub czy dany ma nie mieć telefonu i emailu) chcemy wyszukać wartość. Jeśli kolumna nie zostanie podana lub zostanie podana błędnie wtedy wartość będzie wyszukiwana
we wszystkich kolumanch poza kolumną ID. Podwójne kliknięcie na komórkę z danymi klienta powoduje otwarcie okna z edycją jego danych oraz możliwością usunięcia danego klienta.
W aplikacji jest też przycisk **Odśwież**, który odświeża wyświetlenie danych, w razie gdyby klient został podany bez udziału aplikacji. 
W głównym oknie znajduje się też przycisk **Dodaj nowego klienta**.
