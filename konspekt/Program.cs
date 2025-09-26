

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?: ");
string nimi = Console.ReadLine();

if (nimi == "");
{
    Console.WriteLine("Sa ei sisestaud oma nime");
}
else (nimi == "");
{
    Console.WriteLine("Tere " + nimi + "! :D");
}
else
{
    Console.WriteLine("tundmatu sisestus");
}


//2. - vahemikud
Console.WriteLine(nimi+", mis on sinu vanus?");
int kasutajavanus = int.Parse(Console.ReadLine();
/*
//2.1 mitu tingimust peastatud ifide abil
if (kasutajavanus > 0)
{
    if (kasutajavanus < 18)
    {
        Console.WriteLine("Kahjuks oled alaealine");
    }
    else
    {
        Console.WriteLine("Oled piisavalt vana");
    }
}
*/
//2.2 mitu tingimust kasutades loogiliselt "and"

if (kasutajavanus > 0 && kasutajavanus < 18)
{
    Console.WriteLine("Kahjuks oled alaealine");
}
else
{
    Console.WriteLine("Oled piisavalt vana");
}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal

Console.WriteLine($"sisesta oma pikkus ka {nimi}! ");
double kasutajapikkus = double.Parse(Console.ReadLine());

if (kasutajapikkus < 1.00d)
{
    Console.WriteLine("Oled juntsu");
}
else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
 
else if (kasutajapikkus < 1.5d && kasutajapikkus >= 1.25d)
{
    Console.WriteLine("OIOI, päkapikk enam ei ole");
}
else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.5d)
{
    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte natuke lühike");
}
else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)
{
    Console.WriteLine("Oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
}
else
{
    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
}

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid.

int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? + - / *");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+" /*tingimus siia*/)
{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "-")
{
    tehe = arv1 - arv2;
}
if (tehtetüüp == "/")
{
    tehe = arv1 / arv2;
}
if (tehtetüüp == "*")
{
    tehe = arv1 * arv2;
}
if (tehtetüüp == "^")
{
    tehe = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


//4. parool if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("Parool on õige, võid oma tööga jätkata");
}
else if (password == "saatana")
{
    Console.WriteLine("Parool on sobimatu, see pole sinu parool");
}
else
{
    Console.WriteLine("parool on vale");
}

//5. värvituvastus
Console.WriteLine("Mis on sine lemmikvärv?: ");
string favcolour = Console.ReadLine();
if (favcolour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favcolour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favcolour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favcolour == "oranz")
{
    Console.WriteLine("Seda värvi pole saadaval, vabandust :(");
}
else if (favcolour == "helesinine")
{
    Console.BackgroundColor = ConsoleColor.Cyan;
}
else if (favcolour == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}
else if (favcolour == "lilla")
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
}
else if (favcolour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favcolour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favcolour == "roosa")
{
    Console.WriteLine("Vabandame, aga see värv pole saadaval");
}
else if (favcolour == "pruun")
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
}
else
{
    Console.WriteLine("Ei tea seda värvi");
}
    Console.WriteLine("The colour has maybe changed.");