using System;

namespace znamka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet testů..."); // uživatel zadá počet testů
            int testpocet = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte maximální počet bodů z testu..."); // uživatel zadá maximální počet bodů z testu
            double maxbody = double.Parse(Console.ReadLine());

            double body; // definování proměnné "body" která je použita později
            double dltl = maxbody / 100; // dělitel pro počítání percentilu
            double per; // definování proměnné "per" která je určená později pro držení hodnoty procent správnosti testu

            int znamkaprubezne; // definování proměnné "znamkaprubezne" která uživatele po zadání každého testu informuje o výsledku testu

            double jdn = 0; // definování proměnné "jdn", která drží celkový počet výsledků s hodnotou 1
            double dva = 0; // definování proměnné "dva", která drží celkový počet výsledků s hodnotou 2
            double tri = 0; // definování proměnné "tri", která drží celkový počet výsledků s hodnotou 3
            double ctr = 0; // definování proměnné "ctr", která drží celkový počet výsledků s hodnotou 4
            double pet = 0; // definování proměnné "pet", která drží celkový počet výsledků s hodnotou 5
            do
            {
                Console.WriteLine("Zadejte počet bodů v testu. (" + testpocet + " zbývá)"); // uživatel zadá počet bodů z testu (tuto informaci drží dříve definovaná proměnná "body")
                body = double.Parse(Console.ReadLine());
                per = body / dltl; // výpočet procent ve vzorci % = počet / (0.01*maxpočet)

                if (body < 0 || body > maxbody) // kontrola platného zadání počtů bodů
                {
                    Console.WriteLine("Zadal jste neplatný počet bodů!");
                }
                else
                {
                    if (per <= 33) // ukládání počtu určitých známek ve dříve definovaných proměnných
                    {
                        pet++;
                        znamkaprubezne = 5;
                    }
                    else if (per <= 50)
                    {
                        ctr++;
                        znamkaprubezne = 4;
                    }
                    else if (per <= 67)
                    {
                        tri++;
                        znamkaprubezne = 3;
                    }
                    else if (per <= 83)
                    {
                        dva++;
                        znamkaprubezne = 2;
                    }
                    else
                    {
                        jdn++;
                        znamkaprubezne = 1;
                    }


                    Console.WriteLine($"{body}/{maxbody} = {per}% (Známka - " + znamkaprubezne + ")"); // informace o současně zadaném testu

                    testpocet--; // od proměnné "testpočet" se odečte 1

                }


            }
            while (testpocet > 0); // jakmile je počet testů roven 0, program je osvobozen z while cyklu

            double pocetznamek = jdn + dva + tri + ctr + pet; // proměnná pro výpočet průměru
            double znamkycelkem = jdn + dva * 2 + tri * 3 + ctr * 4 + pet * 5; // proměnná pro výpočet průměru

            double prumer = znamkycelkem / pocetznamek; // výpočet průměru pomocí vzorce: prumer = součethodnot/počethodnot

            double max = Math.Max(Math.Max(Math.Max(jdn, dva), Math.Max(tri, ctr)), -1); // zjišťování nejvíce vyskytované známky

            string prumerslovne; // definování proměnné "prumerslovne", která podle hodnoty proměnné "prumer" dostane slovní hodnocení výsledku

            int maxcsl; // definování proměnné "maxcsl", která podle hodnoty proměnné "max" dostane číselné hodnocení výsledku
            string maxslovne; // definování proměnné "maxslovne", která podle hodnoty proměnné "max" dostane slovní hodnocení výsledku


            if (prumer < 2) // přiřazování hodnoty k proměnné "prumerslovne"
                prumerslovne = "výborně";
            else if (prumer < 3)
                prumerslovne = "chvalitebně";
            else if (prumer < 4)
                prumerslovne = "dobře";
            else if (prumer < 5)
                prumerslovne = "dostatečně";
            else
                prumerslovne = "nedostatečně";

            if (max == jdn) // přiřazování hodnoty k proměnným "maxcsl" a "maxslovne"
            {
                maxcsl = 1;
                maxslovne = "výborně";
            }
            else if (max == dva)
            {
                maxcsl = 2;
                maxslovne = "chvalitebně";
            }
            else if (max == tri)
            {
                maxcsl = 3;
                maxslovne = "dobře";
            }
            else if (max == ctr)
            {
                maxcsl = 4;
                maxslovne = "dostatečně";
            }
            else
            {
                maxcsl = 5;
                maxslovne = "nedostatečně";
            }

            Console.WriteLine("Z tohoto testu byl průměr " + prumer + " - " + prumerslovne + ", a nejčastější známka byla " + maxcsl + " - " + maxslovne + ".");
            // nakonec program vypíše číselný a slovní výsledek průměru + nejvíce vyskytovaný výsledek číselně i slovně
        }
    }
}
