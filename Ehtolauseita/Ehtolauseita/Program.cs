// 1.
Console.WriteLine("Anna kaksi kokonaislukua: ");
int eka = Int32.Parse(Console.ReadLine());
int toka = Int32.Parse(Console.ReadLine());

if (toka < eka)
{
    Console.WriteLine(eka + " " + toka);
}
else 
{ Console.WriteLine(toka + " " + eka);
}

// 2.
Console.WriteLine("Anna kolme kokonaislukua niin etsin suurimman:");
int ekaa = Int32.Parse(Console.ReadLine());
int tokaa = Int32.Parse(Console.ReadLine());
int kolmass = Int32.Parse(Console.ReadLine());
if (ekaa > tokaa && ekaa > kolmass)
{
    Console.WriteLine(ekaa + " on suurin");
        }
else if (tokaa > ekaa && tokaa > kolmass)
{
    Console.WriteLine(tokaa + " on suurin");
}
else { Console.WriteLine(kolmass + " on suurin"); }

// 3.
Console.WriteLine("Anna kokonaisluku väliltä 0-9 niin muutan sen sanaksi:");
int luku = Int32.Parse(Console.ReadLine());
switch (luku)
{
    case 0: Console.WriteLine("Nolla");
        break;
    case 1: Console.WriteLine("Yksi");
        break;
    case 2: Console.WriteLine("Kaksi");
        break;
    case 3: Console.WriteLine("Kolme");
        break;
    case 4: Console.WriteLine("Neljä");
        break;
    case 5: Console.WriteLine("Viisi");
        break;
    case 6: Console.WriteLine("Kuusi");
        break;
    case 7: Console.WriteLine("Seitsemän");
        break;
    case 8: Console.WriteLine("Kahdeksan");
        break;
    case 9: Console.WriteLine("Yhdeksän");
        break;
    default: Console.WriteLine("Syöte virheellinen, anna kokonaisluku 0-9");
            break;
}

// 4.

Console.WriteLine("Anna viisi kokonaislukua niin etsin suurimman:");
int luku1 = Int32.Parse(Console.ReadLine());
int luku2 = Int32.Parse(Console.ReadLine());
int luku3 = Int32.Parse(Console.ReadLine());
int luku4 = Int32.Parse(Console.ReadLine());
int luku5 = Int32.Parse(Console.ReadLine());

if (luku1 > luku2 && luku1 > luku3 && luku1 > luku4 && luku1 > luku5)
{
    Console.WriteLine(luku1 + " on suurin");
}
else if (luku2 > luku1 && luku2 > luku3 && luku2 > luku4 && luku2 > luku5)
{
    Console.WriteLine(luku2 + " on suurin");
}
else if (luku3 > luku1 && luku3 > luku2 && luku3 > luku4 && luku3 > luku5)
{
    Console.WriteLine(luku3 + " on suurin");
}
else if (luku4 > luku1 && luku4 > luku2 && luku4 > luku3 && luku4 > luku5)
{
    Console.WriteLine(luku4 + " on suurin");
}

else { Console.WriteLine(luku5 + " on suurin"); }


// 5.
Console.WriteLine("Mitä haluat syöttää? Valitse vaihtoehdoista:");
Console.WriteLine("1. Kokonaisluku");
Console.WriteLine("2. Double-luku");
Console.WriteLine("3. Merkkijono");

int valinta = int.Parse(Console.ReadLine());

switch (valinta)
{
    case 1:
        Console.WriteLine("Syötä kokonaisluku:");
        int kokonaisluku = int.Parse(Console.ReadLine());
        kokonaisluku++;
        Console.WriteLine(kokonaisluku);
        break;

    case 2:
        Console.WriteLine("Syötä double-luku:");
        double doubleLuku = double.Parse(Console.ReadLine());
        doubleLuku++;
        Console.WriteLine(doubleLuku);
        break;

    case 3:
        Console.WriteLine("Syötä merkkijono:");
        string merkkijono = Console.ReadLine();
        merkkijono += "*";
        Console.WriteLine(merkkijono);
        break;

    default:
        Console.WriteLine("Virheellinen valinta.");
        break;
}

// 6.

Console.WriteLine("Anna pisteesi väliltä 1-9");
int pisteet = Int32.Parse(Console.ReadLine());
if (pisteet >= 1 && pisteet <= 3)
{
    Console.WriteLine(pisteet * 10);
}
else if (pisteet >= 4 && pisteet <= 6)
{
    Console.WriteLine(pisteet * 100);
}
else if (pisteet >= 7 && pisteet <= 9)
{
    Console.WriteLine(pisteet * 1000);
}
else
{
    Console.WriteLine("Syöte virheellinen!");
}


// 7.
Console.WriteLine("Syötä numero (0 - 999): ");
int numero = Int32.Parse(Console.ReadLine());

if (numero < 0 || numero > 999)
{
    Console.WriteLine("Virheellinen syöte. Anna luku välillä 0 - 999.");
}
else
{
    string sanaMuoto = LukuSanaksi(numero);
    Console.WriteLine(sanaMuoto);
}
    
    string LukuSanaksi(int numero)
{
    if (numero == 0)
    {
        return "Nolla";
    }

    string[] yksikot = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };
    string[] kymmenet = { "", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };
    string[] sadat = { "", "sata", "kaksisataa", "kolmesataa", "neljäsataa", "viisisataa", "kuusisataa", "seitsemänsataa", "kahdeksansataa", "yhdeksänsataa" };

    int sadasOsat = numero / 100;
    int kymmenesOsat = (numero % 100) / 10;
    int yksikkoOsat = numero % 10;

    string tulos = $"{sadat[sadasOsat]}{kymmenet[kymmenesOsat]}{yksikot[yksikkoOsat]}";

    return tulos;
}
