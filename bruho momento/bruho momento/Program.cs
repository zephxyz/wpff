Start:
Console.CursorVisible = false;
Random random = new Random();


List<Cards> id = new List<Cards>
            {
                new Cards {ID = 10},
                new Cards {ID = 11},
                new Cards {ID = 12},
                new Cards {ID = 13},
                new Cards {ID = 16},
                new Cards {ID = 17},
                new Cards {ID = 18},
                new Cards {ID = 19},
                new Cards {ID = 20},
                new Cards {ID = 21},
                new Cards {ID = 22},
                new Cards {ID = 23},
                new Cards {ID = 26},
                new Cards {ID = 27},
                new Cards {ID = 28},
                new Cards {ID = 29},
                new Cards {ID = 30},
                new Cards {ID = 31},
                new Cards {ID = 32},
                new Cards {ID = 33},
                new Cards {ID = 36},
                new Cards {ID = 37},
                new Cards {ID = 38},
                new Cards {ID = 39},
                new Cards {ID = 40},
                new Cards {ID = 41},
                new Cards {ID = 42},
                new Cards {ID = 43},
                new Cards {ID = 46},
                new Cards {ID = 47},
                new Cards {ID = 48},
                new Cards {ID = 49} // - 4, 5
            };

var Shuffled = id.OrderBy(x => random.Next());

int[] shuffledCard = new int[32];
int i = 0;
foreach (var card in Shuffled)
{
    shuffledCard[i] = card.ID;
    i++;
}
//pregame
int available = 32;
int[] id1 = new int[32];
int[] id2 = new int[32];
int[] tossed = new int[32];
int tossnr = 1;
int topTossed;
int l = 0;
for (i = 0; i < 4; i++)
{
    id1[i] = shuffledCard[l];
    l++;
    available--;
    id2[i] = shuffledCard[l];
    l++;
    available--;
}
tossed[0] = shuffledCard[l];
topTossed = tossed[0];
l++;
available--;

//gamestarts
i = 0;
string[] p1 = new string[32];
string[] p2 = new string[32];
string[] p11 = new string[32];
string[] p22 = new string[32];
string winner = "";


bool zaludy1;
bool cerveny1;
bool zeleny1;
bool koule1;
bool sedm;
bool osm;
bool devet;
bool deset;
bool jj;
bool qq;
bool kk;
bool aa;

bool gameover = false;

bool tryparse;

bool hasAce = false;
bool hasSeven = false;
bool p1hasAceImmunity = true;
bool p2hasAceImmunity = true;
bool p1hasSevenImmunity = true;
bool p2hasSevenImmunity = true;
int changedColorTo = 0;


int count1 = 4;
int count2 = 4;

int turn = 0;
int choice = 0;
int drawSeven = 0;

string topStatus = "";
string p111 = "";
string p222 = "";

do
{
    turn++;

    zaludy1 = topTossed / 10 < 2;
    cerveny1 = topTossed / 10 >= 2 && topTossed / 10 < 3;
    zeleny1 = topTossed / 10 >= 3 && topTossed / 10 < 4;
    koule1 = topTossed / 10 >= 4;

    if((topTossed == 17 || topTossed == 27 || topTossed == 37 || topTossed == 47) && turn > 1)
    {
        zaludy1 = changedColorTo == 1;
        cerveny1 = changedColorTo == 2;
        zeleny1 = changedColorTo == 3;
        koule1 = changedColorTo == 4;
    }
    

    sedm = topTossed % 10 == 0;
    osm = topTossed == 11 || topTossed == 21 || topTossed == 31 || topTossed == 41;
    devet = topTossed == 12 || topTossed == 22 || topTossed == 32 || topTossed == 42;
    deset = topTossed == 13 || topTossed == 23 || topTossed == 33 || topTossed == 43;
    jj = topTossed == 16 || topTossed == 26 || topTossed == 36 || topTossed == 46;
    qq = topTossed == 17 || topTossed == 27 || topTossed == 37 || topTossed == 47;
    kk = topTossed == 18 || topTossed == 28 || topTossed == 38 || topTossed == 48;
    aa = topTossed == 19 || topTossed == 29 || topTossed == 39 || topTossed == 49;

    changedColorTo = 0;

    switch (zaludy1)
    {
        case true:
            p111 = "Žalud.";
            break;
        default:
            break;
    }
    switch (cerveny1)
    {
        case true:
            p111 = "Červ.";
            break;
        default:
            break;
    }
    switch (zeleny1)
    {
        case true:
            p111 = "Zel.";
            break;
        default:
            break;
    }
    switch (koule1)
    {
        case true:
            p111 = "Kul.";
            break;
        default:
            break;
    }
    switch (sedm)
    {
        case true:
            p222 = "7";
            break;
        default:
            break;
    }
    switch (osm)
    {
        case true:
            p222 = "8";
            break;
        default:
            break;
    }
    switch (devet)
    {
        case true:
            p222 = "9";
            break;
        default:
            break;
    }
    switch (deset)
    {
        case true:
            p222 = "10";
            break;
        default:
            break;
    }
    switch (jj)
    {
        case true:
            p222 = "JANEK";
            break;
        default:
            break;
    }
    switch (qq)
    {
        case true:
            p222 = "MĚNIČ";
            break;
        default:
            break;
    }
    switch (kk)
    {
        case true:
            p222 = "KRÁL";
            break;
        default:
            break;
    }
    switch (aa)
    {
        case true:
            p222 = "ESO";
            break;
        default:
            break;
    }
    topStatus = p111 + p222;



    bool[] Tossable = new bool[32];
    //p1
    if (turn % 2 == 1) //diff
    {
        for (i = 0; i < count1; i++) //diff
        {
            zaludy1 = id1[i] / 10 < 2; //diff
            cerveny1 = id1[i] / 10 >= 2 && id1[i] / 10 < 3;
            zeleny1 = id1[i] / 10 >= 3 && id1[i] / 10 < 4;
            koule1 = id1[i] / 10 >= 4;


            sedm = id1[i] % 10 == 0;
            osm = id1[i] == 11 || id1[i] == 21 || id1[i] == 31 || id1[i] == 41;
            devet = id1[i] == 12 || id1[i] == 22 || id1[i] == 32 || id1[i] == 42;
            deset = id1[i] == 13 || id1[i] == 23 || id1[i] == 33 || id1[i] == 43;
            jj = id1[i] == 16 || id1[i] == 26 || id1[i] == 36 || id1[i] == 46;
            qq = id1[i] == 17 || id1[i] == 27 || id1[i] == 37 || id1[i] == 47;
            kk = id1[i] == 18 || id1[i] == 28 || id1[i] == 38 || id1[i] == 48;
            aa = id1[i] == 19 || id1[i] == 29 || id1[i] == 39 || id1[i] == 49;


            switch (zaludy1)
            {
                case true:
                    p11[i] = "Žalud.";
                    break;
                default:
                    break;
            }
            switch (cerveny1)
            {
                case true:
                    p11[i] = "Červ.";
                    break;
                default:
                    break;
            }
            switch (zeleny1)
            {
                case true:
                    p11[i] = "Zel.";
                    break;
                default:
                    break;
            }
            switch (koule1)
            {
                case true:
                    p11[i] = "Kul.";
                    break;
                default:
                    break;
            }
            switch (sedm)
            {
                case true:
                    p22[i] = "7";
                    break;
                default:
                    break;
            }
            switch (osm)
            {
                case true:
                    p22[i] = "8";
                    break;
                default:
                    break;
            }
            switch (devet)
            {
                case true:
                    p22[i] = "9";
                    break;
                default:
                    break;
            }
            switch (deset)
            {
                case true:
                    p22[i] = "10";
                    break;
                default:
                    break;
            }
            switch (jj)
            {
                case true:
                    p22[i] = "JANEK";
                    break;
                default:
                    break;
            }
            switch (qq)
            {
                case true:
                    p22[i] = "MĚNIČ";
                    break;
                default:
                    break;
            }
            switch (kk)
            {
                case true:
                    p22[i] = "KRÁL";
                    break;
                default:
                    break;
            }
            switch (aa)
            {
                case true:
                    p22[i] = "ESO";
                    break;
                default:
                    break;
            }
            p1[i] = p11[i] + p22[i];
        }


        Console.Write("Hráč 1: \nVrchní karta: ");
        ChooseColor(p111);
        Console.Write(topStatus);
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Karty v ruce:");
        for (i = 0; i < count1; i++) //diff
        {
            ChooseColor(p11[i]);
            Console.WriteLine((i + 1) + " - " + p1[i]);
            Console.ResetColor();
        }
        if (count2 < 5 && count2 > 1)
            Console.WriteLine("(Hráč 2 má v ruce " + count2 + " karty.)");
        else if(count2 == 1)
            Console.WriteLine("(Hráč 2 má v ruce " + count2 + " kartu.)");
        else
            Console.WriteLine("(Hráč 2 má v ruce " + count2 + " karet.)");
        Console.WriteLine("Vyberte kartu pro vyhození... (Napište její pozici, pro líznutí si napište 0) ");
        if (turn > 1)
        {
            hasAce = false;
            hasSeven = false;
            for (i = 0; i < count1; i++) //diff
            {
                if (p22[i] == "ESO")
                    hasAce = true;

                if (p22[i] == "7")
                    hasSeven = true;
            }
        }
        
            
        if (!hasAce && !p1hasAceImmunity && p222 == "ESO")
        {
            Console.Clear();
            Console.WriteLine("Hráč 1 je omráčen ESEM.");
            p1hasAceImmunity = true;
            Console.WriteLine();
            Console.WriteLine("Na tahu bude hráč 2...");
            Thread.Sleep(1500);
            Console.Clear();
            continue;
        }
        if (!hasSeven && !p1hasSevenImmunity && p222 == "7")
        {
            Console.Clear();
            if (drawSeven < 5)
            {
                Console.WriteLine("Hráč 1 si líznul " + drawSeven + " karty.");
                Console.WriteLine();
                Console.WriteLine("Na tahu bude hráč 2...");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hráč 1 si líznul " + drawSeven + " karet.");
                Console.WriteLine();
                Console.WriteLine("Na tahu bude hráč 2...");
                Thread.Sleep(1500);
                Console.Clear();
            }

            for (i = 0; i < drawSeven; i++)
            {
                if (available == 0)
                {
                    for (i = 0; i < tossnr; i++)
                    {
                        shuffledCard[i] = tossed[i];
                        available++;
                    }
                    l = 0;
                    tossnr = 0;
                }
                id1[count1] = shuffledCard[l]; //diff
                count1++; //diff
                l++;
                available--;
            }
            drawSeven = 0;
            p1hasSevenImmunity = true;
            continue;
        }
        for (i = 0; i < count1; i++) //diff
        {
            Tossable[i] = false;
            if (p222 != "ESO" && p222 != "7" && p222 != "MĚNIČ")
            {
                if (p22[i] == p222 || p11[i] == p111 || p22[i] == "MĚNIČ")
                {
                    Tossable[i] = true;
                }

            }
            else if (p222 == "ESO")
            {
                if (hasAce == true && p22[i] == "ESO")
                {
                    Tossable[i] = true;
                }
                else if ((p22[i] == p222 && (turn == 1 || p1hasAceImmunity == true))
                        || (p11[i] == p111 && (turn == 1 || p1hasAceImmunity == true))
                        || (p22[i] == "MĚNIČ" && (turn == 1 || p2hasAceImmunity == true)))
                {
                    Tossable[i] = true;
                }
            }
            else if (p222 == "7")
            {
                if (hasSeven == true && p22[i] == "7")
                {
                    Tossable[i] = true;
                }
                else if ((p22[i] == p222 && (turn == 1 || p1hasSevenImmunity == true))
                        || (p11[i] == p111 && (turn == 1 || p1hasSevenImmunity == true))
                        || (p22[i] == "MĚNIČ" && (turn == 1 || p2hasSevenImmunity == true)))
                {
                    Tossable[i] = true;
                }
            }
            else if (p222 == "MĚNIČ")
            {
                if (p11[i] == p111 || p22[i] == p222 || p22[i] == "MĚNIČ")
                {
                    Tossable[i] = true;
                }
            }


        }
        do
        {

            tryparse = int.TryParse(Console.ReadLine(), out choice);

            if (choice == 0)
            {
                if (available == 0)
                {
                    for (i = 0; i < tossnr; i++)
                    {
                        shuffledCard[i] = tossed[i];
                        available++;
                    }
                    l = 0;
                    tossnr = 0;
                }
                id1[count1] = shuffledCard[l]; //diff
                count1++; //diff
                l++;
                available--;
                Console.Clear();
                Console.WriteLine("Hráč 1 si líznul 1 kartu...");
                Console.WriteLine();
                Console.WriteLine("Na tahu bude hráč 2...");
                Thread.Sleep(1500);
                Console.Clear();
                continue;
            }

            else if (choice < 0 || choice > count1 || !Tossable[choice - 1] || !tryparse) //diff
            {
                Console.WriteLine("Zadejte identifikační číslo karty která lze vyhodit...");
                tryparse = false;
            }

        } while (!tryparse);
        if (choice > 0)
        {
            topTossed = id1[choice - 1]; //diff
            tossed[tossnr] = topTossed;
            tossnr++;
            if (id1[choice - 1] == 19 || id1[choice - 1] == 29 || id1[choice - 1] == 39 || id1[choice - 1] == 49) //diff
            {
                p1hasAceImmunity = true; //diff
                p2hasAceImmunity = false; //diff
            }
            if (id1[choice - 1] == 10 || id1[choice - 1] == 20 || id1[choice - 1] == 30 || id1[choice - 1] == 40) //diff
            {
                p1hasSevenImmunity = true; //diff
                p2hasSevenImmunity = false; //diff
                drawSeven += 2;
            }
            if (id1[choice - 1] == 17 || id1[choice - 1] == 27 || id1[choice - 1] == 37 || id1[choice - 1] == 47) //diff
            {
                Console.WriteLine("Na jakou barvu chcete změnit? (1 - ŽALUDY, 2 - ČERVENÝ, 3 - ZELENÝ, 4 - KULE)");
                while (!int.TryParse(Console.ReadLine(), out changedColorTo) || changedColorTo < 1 || changedColorTo > 4)
                    Console.WriteLine("Zadejte celé číslo v rozsahu 1-4.");
            }
            for (i = choice - 1; i < count1; i++) //diff
            {
                id1[i] = id1[i + 1]; //diff
            }
            count1--; //diff
            Console.Clear();
            Console.WriteLine("Hráč 1 odhodil kartu...");
            Console.WriteLine();
            Console.WriteLine("Na tahu bude hráč 2...");
            Thread.Sleep(1500);
            Console.Clear();

        }

    }
    
    //p2
    if (turn % 2 == 0)
    {
        for (i = 0; i < count2; i++)
        {
            zaludy1 = id2[i] / 10 < 2;
            cerveny1 = id2[i] / 10 >= 2 && id2[i] / 10 < 3;
            zeleny1 = id2[i] / 10 >= 3 && id2[i] / 10 < 4;
            koule1 = id2[i] / 10 >= 4;

            sedm = id2[i] % 10 == 0;
            osm = id2[i] == 11 || id2[i] == 21 || id2[i] == 31 || id2[i] == 41;
            devet = id2[i] == 12 || id2[i] == 22 || id2[i] == 32 || id2[i] == 42;
            deset = id2[i] == 13 || id2[i] == 23 || id2[i] == 33 || id2[i] == 43;
            jj = id2[i] == 16 || id2[i] == 26 || id2[i] == 36 || id2[i] == 46;
            qq = id2[i] == 17 || id2[i] == 27 || id2[i] == 37 || id2[i] == 47;
            kk = id2[i] == 18 || id2[i] == 28 || id2[i] == 38 || id2[i] == 48;
            aa = id2[i] == 19 || id2[i] == 29 || id2[i] == 39 || id2[i] == 49;


            switch (zaludy1)
            {
                case true:
                    p11[i] = "Žalud.";
                    break;
                default:
                    break;
            }
            switch (cerveny1)
            {
                case true:
                    p11[i] = "Červ.";
                    break;
                default:
                    break;
            }
            switch (zeleny1)
            {
                case true:
                    p11[i] = "Zel.";
                    break;
                default:
                    break;
            }
            switch (koule1)
            {
                case true:
                    p11[i] = "Kul.";
                    break;
                default:
                    break;
            }
            switch (sedm)
            {
                case true:
                    p22[i] = "7";
                    break;
                default:
                    break;
            }
            switch (osm)
            {
                case true:
                    p22[i] = "8";
                    break;
                default:
                    break;
            }
            switch (devet)
            {
                case true:
                    p22[i] = "9";
                    break;
                default:
                    break;
            }
            switch (deset)
            {
                case true:
                    p22[i] = "10";
                    break;
                default:
                    break;
            }
            switch (jj)
            {
                case true:
                    p22[i] = "JANEK";
                    break;
                default:
                    break;
            }
            switch (qq)
            {
                case true:
                    p22[i] = "MĚNIČ";
                    break;
                default:
                    break;
            }
            switch (kk)
            {
                case true:
                    p22[i] = "KRÁL";
                    break;
                default:
                    break;
            }
            switch (aa)
            {
                case true:
                    p22[i] = "ESO";
                    break;
                default:
                    break;
            }
            p1[i] = p11[i] + p22[i];
        }


        Console.Write("Hráč 2: \nVrchní karta: ");
        ChooseColor(p111);
            Console.Write(topStatus);
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Karty v ruce:");
        for (i = 0; i < count2; i++) 
        {
            ChooseColor(p11[i]);
            Console.WriteLine((i + 1) + " - " + p1[i]);
            Console.ResetColor();
        }
        if(count1 < 5 && count1 > 1)
            Console.WriteLine("(Hráč 1 má v ruce " + count1 + " karty.)");
        else if (count1 == 1)
            Console.WriteLine("(Hráč 1 má v ruce " + count1 + " kartu.)");
        else
            Console.WriteLine("(Hráč 1 má v ruce " + count1 + " karet.)");

        Console.WriteLine("Vyberte kartu pro vyhození... (Napište její pozici, pro líznutí si napište 0) ");
        if (turn > 1)
        {
            hasAce = false;
            hasSeven = false;
            for (i = 0; i < count2; i++) 
            {
                if (p22[i] == "ESO")
                    hasAce = true;

                if (p22[i] == "7")
                    hasSeven = true;
            }
        }
        
            
        if (!hasAce && !p2hasAceImmunity && p222 == "ESO")
        {
            Console.Clear();
            Console.WriteLine("Hráč 2 je omráčen ESEM.");
            p2hasAceImmunity = true;
            Console.WriteLine();
            Console.WriteLine("Na tahu bude hráč 1...");
            Thread.Sleep(1500);
            Console.Clear();
            continue;
        }
            
        if (!hasSeven && !p2hasSevenImmunity && p222 == "7")
        {
            Console.Clear();
            if (drawSeven < 5)
            {
                Console.Clear();
                Console.WriteLine("Hráč 2 si líznul " + drawSeven + " karty.");
                Console.WriteLine();
                Console.WriteLine("Na tahu bude hráč 1...");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hráč 2 si líznul " + drawSeven + " karet.");
                Console.WriteLine();
                Console.WriteLine("Na tahu bude hráč 1..");
                Thread.Sleep(1500);
            }

            for (i = 0; i < drawSeven; i++)
            {
                if (available == 0)
                {
                    for (i = 0; i < tossnr; i++)
                    {
                        shuffledCard[i] = tossed[i];
                        available++;
                    }
                    l = 0;
                    tossnr = 0;
                }
                id2[count2] = shuffledCard[l];
                count2++;
                l++;
                available--;
            }
            p2hasSevenImmunity = true;
            drawSeven = 0;
            continue;
        }
        for (i = 0; i < count2; i++) 
        {
            Tossable[i] = false;
            if (p222 != "ESO" && p222 != "7" && p222 != "MĚNIČ")
            {
                if (p22[i] == p222 || p11[i] == p111 || p22[i] == "MĚNIČ")
                {
                    Tossable[i] = true;
                }

            }
            else if (p222 == "ESO")
            {
                if (hasAce == true && p22[i] == "ESO")
                {
                    Tossable[i] = true;
                }
                else if ((p22[i] == p222 && (turn == 1 || p2hasAceImmunity == true))
                        || (p11[i] == p111 && (turn == 1 || p2hasAceImmunity == true))
                        || (p22[i] == "MĚNIČ" && (turn == 1 || p2hasAceImmunity == true)))
                {
                    Tossable[i] = true;
                }
            }
            else if (p222 == "7")
            {
                if (hasSeven == true && p22[i] == "7")
                {
                    Tossable[i] = true;
                }
                else if ((p22[i] == p222 && (turn == 1 || p2hasSevenImmunity == true))
                        || (p11[i] == p111 && (turn == 1 || p2hasSevenImmunity == true))
                        || (p22[i] == "MĚNIČ" && (turn == 1 || p2hasSevenImmunity == true)))
                {
                    Tossable[i] = true;
                }
            }
            else if (p222 == "MĚNIČ")
            {
                if (p11[i] == p111 || p22[i] == p222 || p22[i] == "MĚNIČ")
                {
                    Tossable[i] = true;
                }
            }


        }
        do
        {

            tryparse = int.TryParse(Console.ReadLine(), out choice);

            if (choice == 0)
            {
                if (available == 0)
                {
                    for (i = 0; i < tossnr; i++)
                    {
                        shuffledCard[i] = tossed[i];
                        available++;
                    }
                    l = 0;
                    tossnr = 0;
                }
                id2[count2] = shuffledCard[l]; //diff
                count2++; //diff
                l++;
                available--;
                Console.Clear();
                Console.WriteLine("Hráč 2 si líznul 1 kartu...");
                Console.WriteLine();
                Console.WriteLine("Na tahu bude hráč 1...");
                Thread.Sleep(1500);
                Console.Clear();
                continue;
            }

            else if (choice < 0 || choice > count2 || !Tossable[choice - 1] || !tryparse)
            {
                Console.WriteLine("Zadejte identifikační číslo karty která lze vyhodit...");
                tryparse = false;
            }

        } while (!tryparse);
        if (choice > 0)
        {
            topTossed = id2[choice - 1]; 
            tossed[tossnr] = topTossed;
            tossnr++;
            if (id2[choice - 1] == 19 || id2[choice - 1] == 29 || id2[choice - 1] == 39 || id2[choice - 1] == 49) 
            {
                p1hasAceImmunity = false; 
                p2hasAceImmunity = true; //diff
            }
            if (id2[choice - 1] == 10 || id2[choice - 1] == 20 || id2[choice - 1] == 30 || id2[choice - 1] == 40) 
            {
                p1hasSevenImmunity = false; 
                p2hasSevenImmunity = true; 
                drawSeven += 2;
            }
            if (id2[choice - 1] == 17 || id2[choice - 1] == 27 || id2[choice - 1] == 37 || id2[choice - 1] == 47) 
            {
                Console.WriteLine("Na jakou barvu chcete změnit? (1 - ŽALUDY, 2 - ČERVENÝ, 3 - ZELENÝ, 4 - KULE)");
                while (!int.TryParse(Console.ReadLine(), out changedColorTo) || changedColorTo < 1 || changedColorTo > 4)
                    Console.WriteLine("Zadejte celé číslo v rozsahu 1-4.");
            }
            for (i = choice - 1; i < count2; i++) //diff
            {
                id2[i] = id2[i + 1]; //diff
            }
            count2--; //diff
            Console.Clear();
            Console.WriteLine("Hráč 2 odhodil kartu...");
            Console.WriteLine();
            Console.WriteLine("Na tahu bude hráč 1..");
            Thread.Sleep(1500);
            Console.Clear();

        }

    }
    if (count1 == 0)
    {
        gameover = true;
        winner = "hráč 1";
    }
    if (count2 == 0)
    {
        gameover = true;
        winner = "hráč 2";
    }




} while (!gameover);

Console.WriteLine("Vyhrává " + winner + "!!");
Console.WriteLine("Chcete hrát znovu? A");
string odpoved = Console.ReadLine().ToUpper();

if (odpoved == "A")
{
    Console.Clear();
    goto Start;
}

static void ChooseColor(string Input)
{
    if (Input == "Žalud.")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if (Input == "Červ.")
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (Input == "Zel.")
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (Input == "Kul.")
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
}

public class Cards
{
    public int ID { get; set; }
}

