Info();
Console.WriteLine("Zadej číslo a");
int a = Overeni();
Console.WriteLine("Zadej číslo b");
int b = Overeni();
int soucet = Soucet(a, b);
Vypis(a, b, soucet);


static void Info()
{
    Console.Title = "bruh moment";
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Vítej v programu " + Console.Title);
}
static int Overeni()
{
    int bru;
    while (!int.TryParse(Console.ReadLine(), out bru))
        Console.WriteLine("ČÍSLO ZADEJ");
    return bru;
}
static int Soucet(int bru, int moment)
{
    int xd = bru + moment;
    return xd;
}
static void Vypis(int a, int b, int soucet)
{
    Console.WriteLine("Součet čísel " + a + " a " + b + " je: " + soucet);
}