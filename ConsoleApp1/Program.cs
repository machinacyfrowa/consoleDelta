// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//postac ogolna F(x) = ax^2 + bx + c

//deklarujemy zmienne na atrybuty funkcji
double a, b, c;
//deklarujemy zmienną na wejście od użytkownika
string input;

//polecenie
Console.WriteLine("Podaj parametry według wzoru ogólnego: F(x) = ax^2 + bx + c");
//wypytaj o parametry, pytaj do skutku jeśli nie podano liczby
do
{
    //polecenie
    Console.WriteLine("Podaj a:");
    //pobranie do stringa - operator ??powoduje,
    //że jeśli otrzymam null to zapisuje zamiast tego ""
    input = Console.ReadLine() ?? "";
    //dopóki nie uzyskam wartości
} while (input != "");
//zamień string na liczbę typu double
a = double.Parse(input);
do
{
    Console.WriteLine("Podaj b:");
    input = Console.ReadLine() ?? "";
} while (input != "");
b = double.Parse(input);
do
{
    Console.WriteLine("Podaj c:");
    input = Console.ReadLine() ?? "";
} while (input != "");
c = double.Parse(input);

//polciz deltę ze wzoru 
double delta = Math.Pow(b, 2) - 4 * a * c;
//wypisz deltę na ekranie
Console.WriteLine("Delta wynosi: " + delta.ToString());

//jeśli delta mniejsza od zera
if(delta < 0)
{
    Console.WriteLine("Delta jest mniejsza od zera.");
    Console.WriteLine("Równanie nie ma pierwiastków");
} else //delta >=0
{
    //liczymy pierwiastek z delty
    double deltaRoot = Math.Sqrt(delta);
    //wypisujemy
    Console.WriteLine("Pierwiastek z delty wynosi:" + deltaRoot.ToString());
    if(delta > 0) //delta dodatnia
    {
        //liczymy miejsca zerowe
        double x1, x2;
        x1 = ( (-1) * b - deltaRoot) / ( 2 * a );
        x2 = ((-1) * b + deltaRoot) / ( 2 * a );
        //wypisujemy
        Console.WriteLine("Delta jest większa od zera");
        Console.WriteLine("x1: " + x1.ToString());
        Console.WriteLine("x2: " + x2.ToString());
    } else if (delta == 0)
    {
        //liczymy jedno miejsce zerowe
        double x;
        x = ((-1) * b) / (2 * a);
        //wypisujemy
        Console.WriteLine("Delta jest równa zero");
        Console.WriteLine("x: " + x.ToString());
    }
}


