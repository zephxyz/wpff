int size = 10;
int end;
//int dm;
//int hm;

/*
Console.WriteLine("Kolik hodnot chcete vygenerovat?");
while (!int.TryParse(Console.ReadLine(), out size))
    Console.WriteLine("Zadejte celé číslo!");

Console.WriteLine("Zadejte dolní mez generování...");
while(!int.TryParse(Console.ReadLine(), out dm))
    Console.WriteLine("Zadejte celé číslo!");

Console.WriteLine("Zadejte horní mez generování...");
while (!int.TryParse(Console.ReadLine(), out hm) || hm <= dm)
    Console.WriteLine("Zadejte celé číslo větší než " + dm + "!");

hm--;
*/
Console.WriteLine("Jakou hodnotu chcete vypsat na konci?");
while(!int.TryParse(Console.ReadLine(), out end))
    Console.WriteLine("Zadejte celé číslo!");

Thread.Sleep(500);
Console.Clear();

int[] ran = new int[size];
Random rng = new Random();
int l;
int j;

for (int i = 0; i < size; i++)
{
    //ran[i] = rng.Next(dm, hm);
    ran[i] = rng.Next(0, 6);
}

int[] filtered = new int[size];

l = 0;
j = size - 1;


for (int i = 0; i < size; i++)
{
    if (ran[i] == end)
    {
        filtered[j] = ran[i];
        j--;
    }
    if (ran[i] != end)
    {
        filtered[l] = ran[i];
        l++;
    }
}

foreach (var x in filtered)
{
    Console.WriteLine(x);
}
Console.ReadKey();