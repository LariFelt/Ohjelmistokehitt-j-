
Console.Write("Anna ikäsi: ");
int ika = Int32.Parse(Console.ReadLine());
if (ika < 15)
{
    Console.WriteLine("Saat ajaa polkupyörää");
}
else if (ika > 18)
{
    Console.Write("Saat ajaa autoa");
}
else
{
    Console.Write("saat ajaa mopoa");
}

