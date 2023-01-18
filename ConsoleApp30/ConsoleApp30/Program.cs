int[] mzdy = new int[] {/* 15500, 18500, 23000, 14000, 38000, 20000*/ };
Console.WriteLine(Prumer(mzdy));
Console.WriteLine(Min(mzdy));
Console.WriteLine(Max(mzdy));

static int Prumer(int[] x)
{
    int celkem = 0;
    if (x.Length == 0)
        return 0;
    int l = 0;
    for (int i = 0; i < x.Length; i++)
    {
        celkem += x[i];
    }
    
    return celkem / x.Length;

}
static int Min(int[] x)
{
    if (x.Length == 0)
        return 0;
    int min = x[0];
    
    for (int i = 1; i < x.Length; i++)
    {
        if (x[i] > min)
            min = x[i];
    }
    return min;
}
static int Max(int[] x)
{
    if (x.Length == 0)
        return 0;
    int max = x[0];
    for (int i = 1; i < x.Length; i++)
    {
        if (x[i] < max)
            max = x[i];
    }
    return max;
}