// See https://aka.ms/new-console-template for more information

/* Kellenek az speckó karakterek */

Console.OutputEncoding = System.Text.Encoding.UTF8;

/* Választó menü */

while (true)
{
    Console.WriteLine("Válassz a következő lehetőségek [1-5] közül:");
    Console.WriteLine("\n[1] - Feladat - Karakter keresés");
    Console.WriteLine("[2] - Feladat - Sztring rendezés");
    Console.WriteLine("[3] - Feladat - Lineáris keresés (rendezetlen eset)");
    Console.WriteLine("[4] - Feladat - Lineáris keresés (rendezett eset)");
    Console.WriteLine("[5] - Kilépés - Pápá");

    Console.Write("\nLehetőség: ");
    string valasztas = Console.ReadLine();

    switch (valasztas)
    {
        case "1":
            elsoFeladat();
            break;
        case "2":
            masodikFeladat();
            break;
        case "3":
            harmadikFeladatRendezetlen();
            break;
        case "4":
            harmadikFeladatRendezett();
            break;
        case "5":
            Console.WriteLine("Kilépés...");
            return;
        default:
            Console.WriteLine("Érvénytelen választás, próbáld meg újra!\n");
            break;
    }
}

/* 1. feladat */

static void elsoFeladat()
{

    char karakter;
    string megadottKarakter;

    Console.WriteLine("\n########## 1. feladat ##########\n");

    while (true)
    {
        Console.Write("Kérlek adj meg egy karaktert: ");
        megadottKarakter = Console.ReadLine();

        if (!string.IsNullOrEmpty(megadottKarakter) && megadottKarakter.Length == 1)
        {
            karakter = megadottKarakter[0];
            break;
        }
        else
        {
            Console.WriteLine("Kérlek csak egy karaktert adj meg!");
        }

    }

    Console.Write("Kérlek adj meg egy sztringet: ");
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

    Console.WriteLine("\nNyomj egy gombot a folytatáshoz!");
    Console.ReadLine();

}

/* 2. feladat */

static void masodikFeladat()
{
    Console.WriteLine("\n########## 2. feladat ##########\n");
    Console.Write("Kérlek adj meg egy szöveget: ");
    string megadottKarakter = Console.ReadLine();

    string rendezettKarakter = new string(megadottKarakter.OrderBy(c => c).ToArray());

    Console.WriteLine("Rendezett karakterek: " + string.Join(", ", rendezettKarakter));

    Console.WriteLine("\nNyomj egy gombot a folytatáshoz!");
    Console.ReadLine();
}

/* 3. feladat - Rendezetlen eset */

static void harmadikFeladatRendezetlen()
{
    int[] rendezetlenTomb = { 0, 7, 3, 9, 2, 6, 5, 8, 1, 4 };
    Console.WriteLine("\n########## 3. feladat (rendezetlen eset) ##########\n");
    Console.Write("Add meg a keresendő számot a következő rendezetlen tömbből [0,7,3,9,2,6,5,8,1,4]: ");
    int bekertSzam = int.Parse(Console.ReadLine());

    int index = harmadikFeladatRendezetlenEset(rendezetlenTomb, bekertSzam);

    if (index != -1)
    {
        Console.WriteLine($"A(z) {bekertSzam} szám a(z) {index}. indexen található.");
    }
    else
    {
        Console.WriteLine("A keresett szám nem található meg a tömbben.");
    }

    Console.WriteLine("\nNyomj egy gombot a folytatáshoz!");
    Console.ReadLine();
}

static int harmadikFeladatRendezetlenEset(int[] rendezetlenTomb, int bekertSzam)
{
    for (int i = 0; i < rendezetlenTomb.Length; i++)
    {
        if (rendezetlenTomb[i] == bekertSzam)
        {
            return i;
        }
    }
    return -1;
}

/* 3. feladat - Rendezett eset */

static void harmadikFeladatRendezett()
{
    int[] rendezettTomb = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    Console.WriteLine("\n########## 3. feladat (rendezett eset) ##########\n");
    Console.Write("Add meg a keresendő számot a következő rendezett tömbből [0,1,2,3,4,5,6,7,8,9]: ");
    int bekertSzam = int.Parse(Console.ReadLine());
    
    int index = harmadikFeladatRendezettEset(rendezettTomb, bekertSzam);

    if (index != -1)
    {
        Console.WriteLine($"A(z) {bekertSzam} szám a(z) {index}. indexen található.");
    }
    else
    {
        Console.WriteLine("A keresett szám nem található meg a tömbben.");
    }

    Console.WriteLine("\nNyomj egy gombot a folytatáshoz!");
    Console.ReadLine();
}

static int harmadikFeladatRendezettEset(int[] rendezettTomb, int bekertSzam)
{
    for (int i = 0; i < rendezettTomb.Length; i++)
    {
        if (rendezettTomb[i] > bekertSzam)
        {
            break;
        }
        if (rendezettTomb[i] == bekertSzam)
        {
            return i;
        }
    }
    return -1;
}
