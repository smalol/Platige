# Platige

A .NET WinForms project for recruitment process.

Napisz program, który umożliwi podgląd, tworzenie, modyfikację i eksport danych.

Podstawowa struktura bazy danych: 
- Kontrahent: Typ/Rodzaj, Nazwa, Skrót, Kraj, Adres, NIP, czy aktywny, itp.
- Faktura: Numer, Kwota netto, Waluta, Stawka VAT, Data sprzedaży, Opis, itp.

Wymagania funkcjonalne:
1. Program powinien na początku poprosić o podanie serwera i bazy danych, na której ma
pracować oraz uwierzytelnić się na wskazanych parametrach przez użytkownika.
2. Program następnie powinien utworzyć wymaganą strukturę w bazie danych do swojej
późniejszej pracy.
3. Program powinien pozwalać na dodanie nowego kontrahenta, edycję, usuwanie i wyświetlać
listę kontrahentów.
4. Program powinien pozwalać na dodanie nowej faktury, edycję, usuwanie i wyświetlać listę
faktur.
5. Wszelkie walidacje poprawności wprowadzanych danych powinny zostać zaimplementowane
w minimalnym stopniu.
6. Dodatkowo opcja generowania automatycznego podanej wcześniej przez użytkownika liczby
obiektów (kontrahenci i faktury).
7. Program powinien pozwolić na eksport danych do (przynajmniej jednego) formatów XML i
CSV (użytkownik wybiera jaki format).


  
Program prezentuje raporty:
- wystawione faktury na kontrahenta wraz z sumą kwot;
- suma faktur netto i brutto w okresach miesięcznych;
- liczba kontrahentów w danym kraju.
 

Wymogi odnośnie technologii:
- język C#,
- wersja .NET: .NET 8.0
- Entity Framework Core
- MSSQL,
- WinForms.
