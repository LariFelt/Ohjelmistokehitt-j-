
// P01 
Console.WriteLine("Hei maailma!");

//P02
int luku1 = 2;
int luku2 = 3;
int summa = luku1 + luku2;
Console.WriteLine($"Luvun {luku1} ja Luvun {luku2} summa on {summa}");

//P03
int luku3 = 4;
int luku4 = 2;
int erotus = luku3 - luku4;
Console.WriteLine($"Luvun {luku3} ja luvun {luku4} erotus on {erotus}");

//P04
int luku5 = 5;
int luku6 = 6;
int tulo = luku5 * luku6;
Console.WriteLine($"Luvun {luku5} ja luvun {luku6} tulo on {tulo}");

//P05
int luku7 = 12;
int luku8 = 4;
int osam = luku7 / luku8;
Console.WriteLine($"Luvun {luku7} ja luvun {luku8} osamäärä on {osam}");

//P06
int cels = 10;
int fahr = cels * 9/5 +32;
Console.WriteLine($"Celsius asteet {cels} muutettuina Fahrenheiteiksi ovat {fahr}");

//P07
int fahr1 = 60;
float cels1 = ((float)(fahr1 -32) *5) / 9;
Console.WriteLine($"Fahrenheit asteet {fahr1} muutettuina Celsiukseksi ovat {cels1}");

//P08
int mile = 60;
float kilom = (float)(mile * 1.609);
Console.WriteLine($"{mile} mailia muutettuina kilometreiksi on {kilom} kilometriä");

//P09
int kilot = 80;
float maili = (float)(kilot / 1.609);
Console.WriteLine($"{kilot} kilometriä muutettuina maileiksi on {maili}");

//P10
int tuuma = 10;
float sentti = (float)(tuuma * 2.54);
Console.WriteLine($"{tuuma} tuumaa muutettuina senteiksi on {sentti}");

//P11
int sentit = 62;
float tuumat = (float)(sentti / 2.54);
Console.WriteLine($"{sentit} senttiä muutettuina tuumiksi on {tuumat}");

//P12
int yard = 15;
float metri = (float)(yard * 0.9144);
Console.WriteLine($"{yard} yardia muutettuin metreiksi on {metri}");

//P13
int metrit = 120;
float yardit = (float)(metri / 0.9144);
Console.WriteLine($"{metrit} metriä muutettuina yardeiksi on {yardit}");

//P14
Console.Write("Anna Fahrenheit arvo niin muutan sen Celsiuksiksi ");
int fahre = Int32.Parse(Console.ReadLine());
float celsi = ((float)(fahre -32)*5)/9;
Console.WriteLine($"Antamasi Fahrenheit arvo {fahre} muutettuna Celsius asteiksi on {celsi}");

//P15
Console.Write("Anna kaksi lukua niin lasken niiden summan ");
int nro1 = Int32.Parse(Console.ReadLine());
int nro2 = Int32.Parse(Console.ReadLine());
int summa2 = nro1 + nro2;
Console.WriteLine($"Annettujen lukujen summa on {summa2}");

Console.Write("Anna kaksi lukua niin lasken niiden erotuksen ");
int nro3 = Int32.Parse(Console.ReadLine());
int nro4 = Int32.Parse(Console.ReadLine());
int erotus2 = nro3 - nro4;
Console.WriteLine($"Annettujen lukujen erotus on {erotus2}");

Console.Write("Anna kaksi lukua niin lasken niiden tulon ");
int nro5 = Int32.Parse(Console.ReadLine());
int nro6 = Int32.Parse(Console.ReadLine());
int tulo2 = nro5 * nro6;
Console.WriteLine($"Annettujen lukujen tulo on {tulo2}");

Console.Write("Anna kaksi lukua niin lasken niiden osamäärän ");
int nro7 = Int32.Parse(Console.ReadLine());
int nro8 = Int32.Parse(Console.ReadLine());
float osam2 =(float) nro7 / nro8;
Console.WriteLine($"Annettujen lukujen osamäärä on {osam2}");

//P16
Console.WriteLine("Charin koko: " + sizeof(char));
Console.WriteLine("Shortin koko: " + sizeof(short));
Console.WriteLine("Intin koko: " + sizeof(int));
Console.WriteLine("Longink oko: " + sizeof(long));
Console.WriteLine("Floatin koko: " + sizeof(float));
Console.WriteLine("Double koko: " + sizeof(double));

//P17
Console.Write("Anna kirjain: ");
char kirjain = Console.ReadKey().KeyChar;

int asciiArvo = (int)kirjain;

Console.WriteLine($"\nASCII-arvo: {asciiArvo}");

//P18
Console.Write("Anna säteen pituus niin lasken ympyrän alan ");
double sade = Convert.ToDouble(Console.ReadLine());
double pinta = Math.PI * Math.Pow(sade, 2);
Console.WriteLine($"Ympyrän pinta-ala on: {pinta}");

//P19
Console.Write("Anna neliön sivun mitta niin lasken sen pinta-alan ");
double sivu = Convert.ToDouble(Console.ReadLine());
double ala = sivu * sivu;
Console.WriteLine($"Neliön pinta-ala on {ala}");

//P20
Console.Write("Anna suorakulmion pituus ja leveys niin lasken sen pinta-alan ");
double kanta = Convert.ToDouble(Console.ReadLine());
double korkeus = Convert.ToDouble(Console.ReadLine());
double kala = kanta * korkeus;
Console.WriteLine($"Suorakulmion pinta-ala on {kala}");

//P21
Console.Write("Anna päivien määrä niin muutan sen vuosiksi, kuukausiksi ja päiviksi ");
int paivat = Convert.ToInt32(Console.ReadLine());

int vuodet = paivat / 365;
int jako = paivat % 365;
int kuukaudet = jako / 30;
int jaljellaPaivat = jako % 30;

Console.WriteLine($"{paivat} päivää on {vuodet} vuotta, {kuukaudet} kuukautta ja {jaljellaPaivat} päivää.");