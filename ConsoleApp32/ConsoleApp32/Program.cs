int EmployeeCount = HowManyEmployees();

string[] name = new string[EmployeeCount];
int[] mzda = new int[EmployeeCount];
int[] aboveAverage = new int[EmployeeCount];

AddName(name);
AddPay(mzda);
ShowEmployees(EmployeeCount, mzda, name);

static string[] AddName(string[] name)
{
    for (int i = 0; i < name.Length; i++)
    {
        System.Console.WriteLine($"Zadejte jmeno zamestnance {i + 1}");
        name[i] = Console.ReadLine();
    }
    return name;
}
static int[] AddPay(int[] mzda)
{
    for (int i = 0; i < mzda.Length; i++)
    {
        System.Console.WriteLine($"Zadejte mzdu zamestnance {i + 1}");
        bool checker = int.TryParse(Console.ReadLine(), out int num);
        while (!checker)
        {
            System.Console.WriteLine("Musi to byt cislo");
            checker = int.TryParse(Console.ReadLine(), out num);
        }
        mzda[i] = num;
    }
    return mzda;
}

static int HowManyEmployees()
{
    System.Console.WriteLine("Kolik ma vase firma zamestnancu?");
    bool checker = int.TryParse(Console.ReadLine(), out int num);
    while (!checker)
    {
        System.Console.WriteLine("Musi to byt cislo");
        checker = int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

static void ShowEmployees(int EmployeeCount, int[] mzda, string[] name)
{
    int value = 0;

    for (int e = 0; e < EmployeeCount; e++)
    {
        value += mzda[e];
    }
    int avg = value / EmployeeCount;
    System.Console.WriteLine("\n");
    for (int i = 0; i < EmployeeCount; i++)
    {
        if (mzda[i] > avg)
        {
            System.Console.WriteLine(
                $"pracovnik cislo {i + 1} ma nadprumerny plat.\njmeno: {name[i]}\nmzda je {mzda[i]}\n"
            );
        }
    }
}
