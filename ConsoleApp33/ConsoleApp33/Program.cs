
Info();
int a = Nacti("a");
int b = Nacti("b");
int soucet = Soucet(a, b);
int rozdil = Rozdil(a, b);
int soucin = Soucin(a, b);
Vypis(a, b, soucet, "Součet");
Vypis(a, b, rozdil, "Rozdíl");
Vypis(a, b, soucin, "Součin");

static void Info()
{
    Console.Title = "TEST-METODY-01";
    Console.WriteLine("Vítejte v programu: TEST-METODY-01");
}
static int Nacti(string inf)
{
    int cislo;
    Console.Write("Zadejte číslo " + inf + ": ");
    while(!int.TryParse(Console.ReadLine(), out cislo))
        Console.Write("Zadejte celé číslo! ");
    return cislo;
}
static int Soucet(int x, int y)
{
    return x + y;
}
static int Rozdil(int x, int y)
{
    return x - y;
}
static int Soucin(int x, int y)
{
    return x * y;
}
static void Vypis(int x, int y, int op, string o)
{
    Console.WriteLine(o + " " + x + " a " + y + " je " + op);
}