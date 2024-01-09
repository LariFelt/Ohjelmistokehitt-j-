
// 1.
Console.WriteLine("Tehtävä 1");
Console.Write("Anna eka numero: ");
String eka = Console.ReadLine();
Console.Write("Anna toka numero: ");
String toka = Console.ReadLine();
int tokaluku = Int32.Parse(toka);
int summa = tokaluku + 3;
Console.WriteLine("x = " + summa);

// 2.
Console.WriteLine("Tehtävä 2");
int erotus = tokaluku - 2;
Console.WriteLine("x = " + erotus);

// 3.
Console.WriteLine("Tehtävä 3");
int tulo = tokaluku * 5;
Console.WriteLine("x = " + tulo);

//4
Console.WriteLine("Tehtävä 4");
int ekaluku = Int32.Parse(eka);
int jako = ekaluku / tokaluku;
Console.WriteLine("x = " + jako);

// 5.
Console.WriteLine("Tehtävä 5");
Console.Write("Anna eka numero: ");
String ekaa = Console.ReadLine();
Console.Write("Anna toka numero: ");
String tokaa = Console.ReadLine();
int ekaaluku = Int32.Parse(ekaa);
int tokaaluku = Int32.Parse(tokaa);
int jaannos = ekaaluku % tokaaluku;
Console.WriteLine("x = " + jaannos);

//6
Console.WriteLine("Tehtävä 6");
int summarum = ekaluku + tokaluku;
Console.WriteLine("x = " + summarum);

//7
Console.WriteLine("Tehtävä 7");
int erotetut = ekaluku - tokaluku;
Console.WriteLine("x = " + erotetut);

//8
Console.WriteLine("Tehtävä 8");
int tulostaiulos = ekaluku * tokaluku * 5;
Console.WriteLine("x = " + tulostaiulos);