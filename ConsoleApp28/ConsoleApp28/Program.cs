Info();
double a = Overeni("a");
double b = Overeni("b");
double rozdil = Vypocet(a, b, "-");
double soucet = Vypocet(a, b, "+");
double soucin = Vypocet(a, b, "*");
double podil = Vypocet(a, b, "/");
Vypis(a, b, rozdil, "-");
Vypis(a, b, soucet, "+");
Vypis(a, b, soucin, "*");
Vypis(a, b, podil, "/");
Console.ResetColor();

static void Info()
{
    Console.Title = "Rozdíl";
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Vítej v programu pro vypočítání rozdílu a součtu");
}
static double Overeni(string var)
{
    Console.WriteLine("Zadej číslo " + var);
    int bruh;
    while(!int.TryParse(Console.ReadLine(), out bruh))
        Console.WriteLine("Zadej celé číslo!");
    return bruh;
}
static double Vypocet(double x, double y, string operace)
{ 
    if(operace == "-")
        return (x - y);
    else if (operace == "+")
        return (x + y);
    else if (operace == "*")
        return (x * y);
    else
        return (x / y);
    
}
static void Vypis(double a, double b, double x, string lol)
{
    Console.WriteLine( a + " " + lol + " " + b + " = " + x);
}
 