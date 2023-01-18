Console.WriteLine("Zadejte počet zaměstnanců...");
int pocet;
while (!int.TryParse(Console.ReadLine(), out pocet))
    Console.WriteLine("Zadejte celé číslo!");

string[] zamestnanec = new string[pocet];
double[] plat = new double[pocet];
double x = 0;
double prumer;

for (int i = 0; i < pocet; i++)
{
    Console.Write((i + 1) + ". zaměstnanec:");
    zamestnanec[i] = Console.ReadLine();
}

Console.WriteLine("\nPlat jednotlivých zaměstnanců:");

for (int i = 0; i < pocet; i++)
{
    Console.Write("Zadej plat pro zaměstnance " + zamestnanec[i] + " v Kč:");
    while (!double.TryParse(Console.ReadLine(), out plat[i]))
        Console.WriteLine("Zadejte celé číslo!");
}

Console.WriteLine();

for (int i = 0; i < pocet; i++)
{
    Console.WriteLine(zamestnanec[i] + " má plat " + plat[i] + " Kč.");
    x += plat[i];
}

Console.WriteLine();
prumer = x / pocet;
Console.WriteLine("Průměrný plat je: " + prumer + " Kč.");

for (int i = 0; i < pocet; i++)
{
    if (plat[i] > prumer)
        Console.WriteLine("Zaměstnanec " + zamestnanec[i] + " má nadprůměrný plat o výši " +plat[i]+ " Kč.");
}