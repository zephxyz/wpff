
int count = NacitaniInt("Zadejte počet zaměstnanců", 1, false).Length;


string[] jmena = NacitaniString("Zadejte jméno a příjmení zaměstnance", count);

int[] mzdy = NacitaniInt("Zadejte mzdu zaměstnance ", count, true);

int prumer = Prumer(mzdy, count);

Vypis(jmena, prumer, count, mzdy);

static int[] NacitaniInt1(string cw, int x, bool y)
{
    int[] nr = new int[x];
    for (int i = 0; i < x; i++)
    {
        if (!y) 
        {
            Console.WriteLine(cw);
            while (!int.TryParse(Console.ReadLine(), out nr[i]) || nr[i] < 1)
                Console.WriteLine("Zadejte celé číslo větší než 0!");
        }
        else
        {
            Console.WriteLine(cw + " " + i + 1);
            while (!int.TryParse(Console.ReadLine(), out nr[i]) || nr[i] < 1)
                Console.WriteLine("Zadejte celé číslo větší než 0!");
        }       
    }
    return nr;
}
static string[] NacitaniString(string cw, int x)
{
    string[] y = new string[x];
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine(cw + " " + i + 1);
        y[i] = Console.ReadLine();
    }
    return y;
}
static int Prumer(int[] x, int y)
{
    int celkem = 0;
    for (int i = 0; i < y; i++)
    {
        celkem += x[i];
    }
    return celkem / y;
}
static void Vypis(string[] name, int avg, int x, int[] pay)
{
    for (int i = 0; i < x; i++)
    {
        if (pay[i] > avg)
            Console.WriteLine("Zaměstnanec " + name[i] + " má nadprůměrnou mzdu: " + pay[i]);
    }
}