
//IE01
Console.Write("Anna kaksi kokonaislukua niin etsin niistä suurimman ");
int luku1 = Int32.Parse(Console.ReadLine());    
int luku2 = Int32.Parse(Console.ReadLine());
if (luku1 > luku2)
{
    Console.WriteLine($"{luku1} on suurempi kuin {luku2}");
}
else if (luku2 > luku1)
{
    Console.WriteLine($"{luku2} on suurempi kuin {luku1}");
}
else
{
    Console.WriteLine("Luvut ovat yhtä suuret");
}


//IE02
Console.Write("Anna kolme kokonaislukua niin etsin niistä suurimman ");
int luku3 = Int32.Parse(Console.ReadLine());
int luku4 = Int32.Parse(Console.ReadLine());
int luku5 = Int32.Parse(Console.ReadLine());
if ((luku3 > luku4) && (luku3 > luku5))
{
    Console.WriteLine($"{luku3} on suurin");
}
else if ((luku4 > luku3) && (luku4 > luku5))
{
    Console.WriteLine($"{luku4} on suurin");
}
else if ((luku5 > luku3) && (luku5 > luku4))
{
    Console.WriteLine($"{luku5} on suurin");
}
else
{
    Console.WriteLine("Luvut ovat yhtä suuria");
}

//IE03
Console.Write("Anna luku niin tarkistan onko se positiivinen, negatiivinen vai nolla ");
int numba = Int32.Parse(Console.ReadLine());
if (numba > 0)
{
    Console.WriteLine("Luku on negatiivinen");
}
else if (numba < 0)
{
    Console.WriteLine("Luku on positiivinen");
}
else
{
    Console.WriteLine("Luku on nolla");
}

//IE04
Console.Write("Anna luku niin tarkistan onko se jaollinen viidellä tai yhdellätoista ");
int nro = Int32.Parse(Console.ReadLine());
if ((nro % 5 == 0) && (nro % 11 == 0))
{
    Console.WriteLine("Luku on jaollinen sekä viidellä että yhdellätoista");
}
else if (nro % 5 == 0)
{
    Console.WriteLine("Luku on jaollinen viidellä");
}
else if (nro % 11 == 0)
{
    Console.WriteLine("Luku on jaollinen yhdellätoista");
}
else
{
    Console.WriteLine("Luku ei ole jaollinen viidellä eikä yhdellätoista");
}

//IE05