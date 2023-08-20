string title = "Zadanie domowe - dzien 4";
Console.WriteLine(title);
string name = "Ewa";
Console.WriteLine(name);
char gender = 'K';
Console.WriteLine("płeć:" + gender);
var ageEwa = 33;
Console.WriteLine("wiek:" + ageEwa);
var age1 = 30;
var age2 = 17;
string name2 = "Niepełnoletni mężczyzna";

Console.WriteLine("Kobieta, poniżej 30 lat");
Console.WriteLine("Ewa, lat 33");
Console.WriteLine("Niepełnoletni mężczyzna");

bool isActive = false;
isActive = true;
var isValid = 33 < 30;

if (ageEwa < age1)
{
    Console.WriteLine("Ewa jest w grupie wiekowej 30-latek");
}
else
{
    Console.WriteLine("Ewa jest starsza niż grupa 30");
}

if (isValid)
{
    Console.WriteLine("Ewa jest w grupie młodszych");
}
else
{
    Console.WriteLine("Ewa jest w grupie starszych kobiet");
}

if (age2 == 18)
{
    Console.WriteLine("Mężczyzna poniżej 18 lat jest pełnoletni");
}
else
{
    Console.WriteLine("Mężczyzna poniżej 18 lat jest niepełnoletni");
}
if (age2 == 18)
{
    Console.WriteLine("Mężczyzna poniżej 18 lat jest pełnoletni");
}

else
    Console.WriteLine(!(age2 == 18));