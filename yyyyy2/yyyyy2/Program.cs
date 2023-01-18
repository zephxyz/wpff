Console.Write("Aktuální počet zaměstnanců:");
int poceta;
while (!int.TryParse(Console.ReadLine(), out poceta))
    Console.WriteLine("Zadejte celé číslo!");

string[] aktualniz = new string[poceta];
for (int i = 0; i < poceta; i++)
{
    Console.Write((i+1) + ". Zaměstnanec: ");
    aktualniz[i] = Console.ReadLine();
}

Console.Write("Počet nových zaměstnanců:");
int pocetb;
while (!int.TryParse(Console.ReadLine(), out pocetb))
    Console.WriteLine("Zadejte celé číslo!");

string[] novyz = new string[pocetb];
for (int i = 0; i < pocetb; i++)
{
    Console.Write((i + 1) + ". Zaměstnanec: ");
    novyz[i] = Console.ReadLine();
}

string[] all = new string[poceta + pocetb];
Console.WriteLine("Výpis všech zaměstnanců:");
for (int i = 0; i < poceta + pocetb; i++)
{
    if (i < poceta)
        all[i] = aktualniz[i];
    else
        all[i] = novyz[i-poceta];
}
foreach (var x in all)
{
    Console.WriteLine(x);
}
