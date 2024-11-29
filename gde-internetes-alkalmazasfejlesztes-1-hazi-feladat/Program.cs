// See https://aka.ms/new-console-template for more information

/* 1. feladat */

char karakter;
string megadottKarakter;

Console.WriteLine("########## 1. feladat ##########\n");

while (true)
{
    Console.Write("Kérlek adj meg egy karaktert:\n");
    megadottKarakter = Console.ReadLine();

    if (!string.IsNullOrEmpty(megadottKarakter) && megadottKarakter.Length == 1)
    {
        karakter = megadottKarakter[0];
        break;
    }
    else
    {
        Console.WriteLine("Kérlek csak egy karaktert adj meg!\n");
    }

}

Console.WriteLine("Kérlek adj meg egy sztringet:");
string sztring = Console.ReadLine();

int pozicio = sztring.IndexOf(karakter);

if (pozicio != -1)
{
    Console.WriteLine($"A(z) '{karakter}' karakter a '{pozicio + 1}'. pozícióban található.");
}
else
{
    Console.WriteLine($"A(z) '{karakter}' karakter nem található a sztringben.");
}

Console.WriteLine("Nyomj egy gombot a folytatáshoz!");
Console.ReadLine();

Console.WriteLine("########## 2. feladat ##########");

/* 2. feladat */

Console.WriteLine("Kérlek adj meg egy szöveget:");
string megadottKarakter2 = Console.ReadLine();

string rendezettKarakter = new string(megadottKarakter2.OrderBy(c => c).ToArray());

Console.WriteLine("Rendezett karakterek:");
Console.WriteLine(rendezettKarakter);

Console.WriteLine("Nyomj egy gombot a folytatáshoz!");
Console.ReadLine();