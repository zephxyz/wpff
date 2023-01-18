Random rng = new Random();
int dolnim = Mez("dolní", 0);
int hornim = Mez("horní", dolnim);
int[] pole = Generator(rng, Velikost(), dolnim, hornim);
Vypis(pole);


static int Velikost()
{
    int siz;
    Console.WriteLine("Zadejte kolik čísel chcete vygenerovat...");
    while (!int.TryParse(Console.ReadLine(), out siz) || siz < 1)
        Console.WriteLine("Zadejte celé číslo větší než 0!");
    return siz;
}
static int[] Generator(Random random, int size, int dm, int hm)
{
    int[] x = new int[size];
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = random.Next(dm, hm);
    }
    return x;
}
static int Mez(string info, int michal)
{
    int david = 0;
    Console.WriteLine("Zadej " + info + " mez.");
    if (info == "dolní")
    {
        while (!int.TryParse(Console.ReadLine(), out david))
            Console.WriteLine("Zadej číslo!");
    }
    else
    {
        while(!int.TryParse(Console.ReadLine(), out david) || david <= michal)
            Console.WriteLine("Zadej číslo, které je větší než dolní mez!");
        david++;
    }    
    return david;
}
static void Vypis(int[] hodnoty)
{
    foreach (var x in hodnoty)
    {
        Console.Write(x + " | ");
    }
}



