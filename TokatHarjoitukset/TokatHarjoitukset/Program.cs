
// 1. Tehtävä
Console.WriteLine("Anna kaksi lukua niin lasken ne yhteen");
int luku1 = Int32.Parse(Console.ReadLine());
int luku2 = Int32.Parse(Console.ReadLine()); 
int summa = luku1 + luku2;
Console.WriteLine("lukujen summa on {0}", summa);

// 2. Tehtävä
Console.WriteLine("Anna Celsius lukema niin muutan sen fahrenheiteiksi");
int cels = Int32.Parse(Console.ReadLine());
double fahr = cels * 1.8 + 32;
Console.WriteLine(fahr);

// 3. Tehtävä
Console.WriteLine("Anna kaksi lukua niin suoritan niille peruslaskutoimitukset");
int luku3 = Int32.Parse(Console.ReadLine());
int luku4 = Int32.Parse(Console.ReadLine());
int summarum = luku3 + luku4;
int erotus = luku3 - luku4;
int tulo = luku3 * luku4;
double jako = (double)luku3 / luku4;
Console.WriteLine("Summa: {0}, Erotus: {1}, Tulo: {2}, Jako: {3}", summarum, erotus, tulo, jako);

// 4. Tehtävä
Console.WriteLine("Anna kaksi lukua niin lasken niiden jakojäännöksen");
int luku5 = Int32.Parse(Console.ReadLine());
int luku6 = Int32.Parse(Console.ReadLine());
int jaannos = luku5 % luku6;
Console.WriteLine("Lukujen jakojäännös on {0}", jaannos);

// 5. Tehtävä
Console.WriteLine("Anna nimesi");
string nimi = Console.ReadLine();
Console.WriteLine("Hei " + nimi);

// 6. Tehtävä
Console.WriteLine("Anna kaksi lukua, joista toisen pitää olla 3 ja toisen 5:");

Console.WriteLine("Anna ensimmäinen luku (3):");
int nro1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Anna toinen luku (5):");
int nro2 = Int32.Parse(Console.ReadLine());

if (nro1 == 3 && nro2 == 5)
{
    int summa = nro1 + nro2;
    Console.WriteLine("Lukujen summa on: " + summa);
}
else
{
    Console.WriteLine("Antamasi luvut eivät ole 3 ja 5.");
}

// 7. Tehtävä
Console.WriteLine("Anna Celsius lukema niin muutan sen fahrenheiteiksi");
int celss = Int32.Parse(Console.ReadLine());
double fahrr = celss * 1.8 + 32;
Console.WriteLine(fahrr);

// 8. Tehtävä
Console.WriteLine("Anna luvut kahdeksan(8) ja viisi(5) niin suoritan niille peruslaskutoimitukset");

Console.WriteLine("Anna ensimmäinen luku (8):");
int luvut1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Anna toinen luku (5):");
int luvut2 = Int32.Parse(Console.ReadLine());

if ((luvut1 == 8 && (luvut2 == 5)))
{
    int summarum = luvut1 + luvut2;
    int erotus = luvut1 - luvut2;
    int tulo = luvut1 * luvut2;
    double jako = (double)luvut1 / luvut2;

    Console.WriteLine("Summa: {0}, Erotus: {1}, Tulo: {2}, Jako: {3}", summarum, erotus, tulo, jako);
}
else
{
    Console.WriteLine("Antamasi luvut eivät ole kahdeksan(8) ja viisi(5).");
}

// 9. Tehtävä 
Console.WriteLine("Anna luvut viisi(5) ja kaksi(2) niin kerron niiden jakojäännöksen");

Console.WriteLine("Anna ensimmäinen luku (5):");
int numba1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Anna toinen luku (2):");
int numba2 = Int32.Parse(Console.ReadLine());

if ((numba1 == 5 && (numba2 == 2)))
{
    int jaanteet = numba1 % numba2;

    Console.WriteLine("Lukujen jakojäännös on {0}", jaanteet);
}
else
{
    Console.WriteLine("Antamasi luvut eivät ole viisi(5) ja kaksi(2).");
}

// 10. Tehtävä
Console.WriteLine("Anna kokonaisluku välillä 1-10:");
int uuno = Int32.Parse(Console.ReadLine());

if (uuno >= 1 && uuno <= 10)
{
    Console.WriteLine($"Kertotaulu luvulle {uuno}:");

    for (int i = 1; i <= 10; i++)
    {
        int tulo = uuno * i;
        Console.WriteLine($"{uuno} x {i} = {tulo}");
    }
}
else
{
    Console.WriteLine("Antamasi luku ei ole välillä 1-10.");
}

// 11. Tehtävä
Console.WriteLine("Anna ikäsi");
int ika = Int32.Parse(Console.ReadLine());
Console.WriteLine($"{ika} - näytät ikäistäsi nuoremmalta");

// 12. Tehtävä

Console.WriteLine("Anna lukua 10 suurempi kokonaisluku:");
int isohko = Int32.Parse(Console.ReadLine());

for (int sarja = 0; sarja < 13; sarja++)
{
    for (int i = 0; i < 13; i++)
    {
        Console.Write($"{isohko} ");
    }

    Console.WriteLine();

    for (int i = 0; i < 13; i++)
    {
        Console.Write(isohko);
    }
    Console.WriteLine();
}

// 13. Tehtävä
Console.WriteLine("Anna sana:");
string sana = Console.ReadLine();

char ensimmainenKirjain = sana[0];
char viimeinenKirjain = sana[sana.Length - 1];


string uusiSana = viimeinenKirjain + sana.Substring(1, sana.Length - 2) + ensimmainenKirjain;

Console.WriteLine(uusiSana);

// 14. Tehtävä
Console.WriteLine("Anna ensimmäinen kokonaisluku:");
int pone1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Anna toinen kokonaisluku:");
int pone2 = Int32.Parse(Console.ReadLine());

if (pone1 > 0 && pone2 > 0)
{
    Console.WriteLine("Molemmat ovat positiivisia.");
}
else if (pone1 < 0 && pone2 < 0)
{
    Console.WriteLine("Molemmat ovat negatiivisia.");
}
else
{
    Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen.");
}

// 15. Tehtävä
Console.WriteLine("Anna lause:");
string lause = Console.ReadLine();

string[] sanat = lause.Split(' ');

string pisinSana = "";

foreach (string sanaa in sanat)
{
    if (sanaa.Length > pisinSana.Length)
    {
        pisinSana = sanaa;
    }
}

Console.WriteLine(pisinSana);

// 16. Tehtävä
Console.WriteLine("Parittomat luvut välillä 1-99:");

for (int i = 1; i <= 99; i += 2)
{
    Console.Write(i + " ");
}

Console.WriteLine();

// 17. Tehtävä
Console.WriteLine("Luvut välillä 1-99, jotka ovat jaollisia kolmella:");

for (int i = 3; i <= 99; i += 3)
{
    Console.Write(i + " ");
}

Console.WriteLine();