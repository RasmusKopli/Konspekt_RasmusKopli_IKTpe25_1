

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;
using System.Reflection.Metadata;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?: ");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestaud oma nime");
}
else if (nimi == "")
{
    Console.WriteLine("Tere " + nimi + "! :D");
}
else
{
    Console.WriteLine("tundmatu sisestus");
}


//2. - vahemikud
Console.WriteLine(nimi+", mis on sinu vanus?");
int kasutajavanus = int.Parse(Console.ReadLine());
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

/* ISESEISEV ÜLESANNE */

Console.WriteLine("Kas tahad mõõta kasti või tünni?: ");
string valik = Console.ReadLine();
if (valik == "tünn")
{
    Console.WriteLine("Kas sa tead  tünni raadiust (r) või põhja läbimõõtu (d): ");
    string rvõid = Console.ReadLine();
    Console.WriteLine("sisesta see mööt");
    double mõõt = double.Parse(Console.ReadLine());
    if (rvõid == "d")
    {
        mõõt = mõõt / 2;
    }
    else if (rvõid != "r")
    {
        Console.WriteLine("Sisend ei ole tuntav");
    }

    Console.WriteLine("Kui kõrge on su tünn");
    int kõrgus = int.Parse(Console.ReadLine());
    Console.WriteLine("kui paks on tünni kaas?");
    int kaanepaksus = int.Parse(Console.ReadLine());
    double tünnipõhiS = Math.PI * (mõõt * mõõt);
    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
    double küljepindala = tünnipõhiS * kõrgus;
    double kogupindala = (tünnipõhiS * 2) + küljepindala;
    Console.WriteLine($"Sinu tünn mahutab {mahtV} \ntünni küljepindala on {küljepindala} \nkogupindala aga on {kogupindala}");
}
else if (valik == "kast")
{
    Console.WriteLine("Kas kast on kuup (k) või risttahukas (r)? ");
    string kastitüüp = Console.ReadLine();
    if (kastitüüp == "k")
    {
        Console.WriteLine("Sisesta kasti küljepikkus: ");
        double külgA = double.Parse(Console.ReadLine());
        double kuubik = Math.Pow(külgA, 3);
        double küljepindala = (külgA * külgA) * 6;
        double diagonaal = külgA * Math.Sqrt(3);
        Console.WriteLine($"Sinu tünn mahutab {kuubik} \nkuubiku küljepindala on {küljepindala} \nkogupindala aga on {diagonaal}");
    }
    else if (kastitüüp == "r")
    {
        Console.WriteLine("Mis on sinu kasti  kõige pikim külg?: ");
        double pikkkülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis on sinu kasti  kõige lühim külg?: ");
        double lühikekülg = double.Parse(Console.ReadLine());
        Console.WriteLine("Mis on sinu kasti kõrgus?: ");
        double kõrgus = double.Parse(Console.ReadLine());
        double V = pikkkülg * lühikekülg * kõrgus;
        double kogupindala = 2 * ((pikkkülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkkülg * kõrgus));
        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
        Console.WriteLine($"Sinu kast mahutab {V} \nkasti küljepindala on {kogupindala} \ndiagonaal aga on {diagonaal}");
    }
}

Console.WriteLine("banana");
// Console -> adreseeritav moodul või objekt (roheline).
// . -> midagi selle objekti seest, sarnanane windowsi kausta pathis oleva slashiga.
//      - komakohtadega andmetüüpidel komakoha tähistamine
// WrtieLine -> adreseeritav funktsioon objektist Console.
// () -> sulupaar, mis omab endas funktsioonile vajalikku infot.
//      - kasutatakse ka metamaaatilistes tehetes
//      - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõnu "IFi parameeter".
// [] -> tähistab massiive.
// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
//      - saab ka kasutada teksti sees muutujate kuvamiseks.
// -> taane aitab arendajal aru saada millise koodiplokki sees, miski on. Vajalik on kompilatoore.
//"Banana" -> parameeter, mis antakse funktsioonile WriteLine töötlemiseks kaasa.
// ; -> iga koodilause lõppeb komakooloniga.

int muutuja = 3;
// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüübi andmed selle muutuja sees on.
// = -> Võrdusmärk omistab sellele muutujale mingisuguse väärtuse.
// 3 -> väärtus, mis sellele omistatakse

//võimalikud andmetüübid:
int a = 1; // täisarv
decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
float c = 3.0f; //kümnendsüsteemis olev ujukomaga arv
double d = 4.0d; // kümnendsüsttemis olev komakohaga arv, sarnane decimeliga
char c1 = 'a'; // uksainus täht või tähemärk
string s = "tekst"; // inimloetaval kujul olev tekst
var x = "abc"; // ebamäärase tüübiga kohalik muutuja.
var y = 123;
const int z = 3; // konstati-tüüpi muutujaid ei saa muuta, need on read-only

//põhilised matemaatilised tehted
int liitmine = 1 + 1; //liitmine, kaks arvu kokku
int lahutamine = 1 - 1; //lahutamine, esimene arv teisest
int korrutamine = 1 * 1; //korrutamine, esimene arv korratakse teisega
int jagamine = 1 / 1; // jagamine, esimene arv jagatakse teisega
double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendakse teisega
double juurimine = Math.Sqrt(2); // ruutjuur, parameetriks arv mida juuritakse
