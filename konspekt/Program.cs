

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
//Console.WriteLine(nimi+", mis on sinu vanus?");
//int kasutajavanus = int.Parse(Console.ReadLine());
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

//if (kasutajavanus > 0 && kasutajavanus < 18)
//{
//    Console.WriteLine("Kahjuks oled alaealine");
//}
//else
//{
//    Console.WriteLine("Oled piisavalt vana");
//}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal

//Console.WriteLine($"sisesta oma pikkus ka {nimi}! ");
//double kasutajapikkus = double.Parse(Console.ReadLine());

//if (kasutajapikkus < 1.00d)
//{
//    Console.WriteLine("Oled juntsu");
//}
//else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
//{
//    Console.WriteLine("Oled peaaegu allameetrimees");
//}
 
//else if (kasutajapikkus < 1.5d && kasutajapikkus >= 1.25d)
//{
//    Console.WriteLine("OIOI, päkapikk enam ei ole");
//}
//else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.5d)
//{
//    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte natuke lühike");
//}
//else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)
//{
//    Console.WriteLine("Oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
//}
//else
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
//}

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid.


//int arv1 = 0;
//int arv2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene arv: ");
//arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine arv: ");
//arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Missugust tehet soovid teha? + - / *");
//string tehtetüüp = Console.ReadLine();
//int tehe = 0;

//if (tehtetüüp == "+" /*tingimus siia*/)
//{
//    tehe = arv1 + arv2;
//}
//if (tehtetüüp == "-")
//{
//    tehe = arv1 - arv2;
//}
//if (tehtetüüp == "/")
//{
//    tehe = arv1 / arv2;
//}
//if (tehtetüüp == "*")
//{
//    tehe = arv1 * arv2;
//}
//if (tehtetüüp == "^")
//{
//    tehe = (int)Math.Pow(arv1, arv2);
//}

//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");


//4. parool if ja string andmetüüp
//Console.WriteLine($"Palun vabandust {nimi}, aga edasiseks tööks on parooli vaja");
//string password = Console.ReadLine();
//if (password == "simsalabim")
//{
//    Console.WriteLine("Parool on õige, võid oma tööga jätkata");
//}
//else if (password == "saatana")
//{
//    Console.WriteLine("Parool on sobimatu, see pole sinu parool");
//}
//else
//{
//    Console.WriteLine("parool on vale");
//}

////5. värvituvastus
//Console.WriteLine("Mis on sine lemmikvärv?: ");
//string favcolour = Console.ReadLine();
//if (favcolour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favcolour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favcolour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favcolour == "oranz")
//{
//    Console.WriteLine("Seda värvi pole saadaval, vabandust :(");
//}
//else if (favcolour == "helesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Cyan;
//}
//else if (favcolour == "tumesinine")
//{
//    Console.BackgroundColor = ConsoleColor.DarkBlue;
//}
//else if (favcolour == "lilla")
//{
//    Console.BackgroundColor = ConsoleColor.DarkMagenta;
//}
//else if (favcolour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favcolour == "valge")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//}
//else if (favcolour == "roosa")
//{
//    Console.WriteLine("Vabandame, aga see värv pole saadaval");
//}
//else if (favcolour == "pruun")
//{
//    Console.BackgroundColor = ConsoleColor.DarkYellow;
//}
//else
//{
//    Console.WriteLine("Ei tea seda värvi");
//}
//    Console.WriteLine("The colour has maybe changed.");

/* ISESEISEV ÜLESANNE */

//Console.WriteLine("Kas tahad mõõta kasti või tünni?: ");
//string valik = Console.ReadLine();
//if (valik == "tünn")
//{
//    Console.WriteLine("Kas sa tead  tünni raadiust (r) või põhja läbimõõtu (d): ");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("sisesta see mööt");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if (rvõid != "r")
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }

//    Console.WriteLine("Kui kõrge on su tünn");
//    int kõrgus = int.Parse(Console.ReadLine());
//    Console.WriteLine("kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());
//    double tünnipõhiS = Math.PI * (mõõt * mõõt);
//    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mahtV} \ntünni küljepindala on {küljepindala} \nkogupindala aga on {kogupindala}");
//}
//else if (valik == "kast")
//{
//    Console.WriteLine("Kas kast on kuup (k) või risttahukas (r)? ");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        Console.WriteLine("Sisesta kasti küljepikkus: ");
//        double külgA = double.Parse(Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu tünn mahutab {kuubik} \nkuubiku küljepindala on {küljepindala} \nkogupindala aga on {diagonaal}");
//    }
//    else if (kastitüüp == "r")
//    {
//        Console.WriteLine("Mis on sinu kasti  kõige pikim külg?: ");
//        double pikkkülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis on sinu kasti  kõige lühim külg?: ");
//        double lühikekülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis on sinu kasti kõrgus?: ");
//        double kõrgus = double.Parse(Console.ReadLine());
//        double V = pikkkülg * lühikekülg * kõrgus;
//        double kogupindala = 2 * ((pikkkülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkkülg * kõrgus));
//        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
//        Console.WriteLine($"Sinu kast mahutab {V} \nkasti küljepindala on {kogupindala} \ndiagonaal aga on {diagonaal}");
//    }
//}

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
double juurimine = Math.Sqrt(2); // ruutjuur, parameetriks arv mida juuritaks

//Ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida

//int arv1 = 0;
////arv1 nime ees olev andmetüübi kirjeldus
////Võrdusmärk omistab sellele muutujale mingisuguse väärtuse
////väärtus, mis sellele omistatakse
//int arv2 = 0;
////arv2 nime ees olev andmetüübi kirjeldus
////Võrdusmärk omistab sellele muutujale mingisuguse väärtuse
////väärtus, mis sellele omistatakse
//Console.WriteLine("Tere, palun sisesta esimene arv: ");
////adreseerime moodulit "console", punkti abil ütleme, et kasutame funktsiooni WriteLine, et kasutajale õelda sõnum
////asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
////iga koodilause lõppeb komakooloniga
//arv1 = int.Parse(Console.ReadLine());
////Instantseerime muutuja "arv1", ninngmütleme, et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
////Mille saame kasutajalt console.readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
////asuva funktsiooni "parse" abil kasutajasisendi täisarvuks. Lause lõppeb lõpumärgiga
//Console.WriteLine("Tere, palun sisesta teine arv: ");
////adreseerime moodulit "console", punkti abil ütleme, et kasutame funktsiooni WriteLine, et kasutajale õelda sõnum
////asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
////iga koodilause lõppeb komakooloniga
//arv2 = int.Parse(Console.ReadLine());
////Instantseerime muutuja "arv1", ninngmütleme, et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
////Mille saame kasutajalt console.readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
////asuva funktsiooni "parse" abil kasutajasisendi täisarvuks. Lause lõppeb lõpumärgiga
//Console.WriteLine("Missugust tehet soovid teha? + - / *");
////adreseerime moodulit "console", punkti abil ütleme, et kasutame funktsiooni WriteLine, et kasutajale õelda sõnum
////asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga
////iga koodilause lõppeb komakooloniga

//string tehtetüüp = Console.ReadLine();
////tekitame muutuja "tehetüüp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi obil omistame talle
////konsooli rea pealt loetu info, mis saame kasutades "Console"mooduli, Readline() funktsiooni. Lause lõppeb lauselõpumärgiga ; .
////inimoleval kuju või tekst
////sisestab ülevat moodule ja funktsioonile teatud nimetust
//int tehe = 0;
////instateerime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0.
////lauselõpp lõppeb lauselõpumärgiga ; .

//if (tehtetüüp == "+" /*tingimus siia*/)
////teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehetüüp" sisu on samal kujul, kui sõna "+"
//{
//    //peale tingimust on koodiplokk {} loogeliste sulgude vahel. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
//    //muutuja arv1 ja arv2. lause lõppeb lauselõpumärgiga sulgude sees.
//    tehe = arv1 + arv2;
//}
//if (tehtetüüp == "-")
////teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehetüüp" sisu on samal kujul, kui sõna "-"
//{
//    //peale tingimust on koodiplokk {} loogeliste sulgude vahel. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutades
//    //muutuja arv1 ja arv2. lause lõppeb lauselõpumärgiga sulgude sees.
//    tehe = arv1 - arv2;
//}
//if (tehtetüüp == "/")
////teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehetüüp" sisu on samal kujul, kui sõna "/"
//{
//    //peale tingimust on koodiplokk {} loogeliste sulgude vahel. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagatakse
//    //muutuja arv1 ja arv2. lause lõppeb lauselõpumärgiga sulgude sees.
//    tehe = arv1 / arv2;
//}
//if (tehtetüüp == "*")
////teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehetüüp" sisu on samal kujul, kui sõna "*"
//{
//    //peale tingimust on koodiplokk {} loogeliste sulgude vahel. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutades kokku
//    //muutuja arv1 ja arv2. lause lõppeb lauselõpumärgiga sulgude sees.
//    tehe = arv1 * arv2;
//}
//if (tehtetüüp == "^")
////teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehetüüp" sisu on samal kujul, kui sõna "^"
//{
//    //peale tingimust on koodiplokk {} loogeliste sulgude vahel. Koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
//    //moodulist "Math" punkti abil funktsiooni "Pow()", selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter
//    //Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (Int) abil. Lause lõppeb lauselõpumärgiga sulgude sees.
//    tehe = (int)Math.Pow(arv1, arv2);
//}

//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
////adreseerime moodulit "Console", ning kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus.
////Lause lõppeb lauselõpumärgiga.

int arv = 0; //sobib
string sõna = "abc"; // sobib
//string string = "abc"

//muutuja nimeks ei sobi järgnevad sõnad:
//abstract, as, base, bool, break, byte, case,
//catch, char, checked, class, const, continue, decimal,
//default, delegate, do, double, else, enum, event,
//explicit, extern, false, finally, fixe, float, for,
//foreach, goto, if, implicit, in, int,
//interface, internal, is, lock, long, namespace, new,
//null, object, operator, out, override, params,
//private, protected, public, readonly, ref, return, sbyte
//sealed, short, sizeof, stackalloc, static, string, struct,
//switch, this, throw, true, try, typeof, uint,
//ulong, unchecked, unsfae, ushort, using, virtual, void,
//volatile, while.

Console.WriteLine("Sisesta ostusumma: ");
double ostusumma = double.Parse(Console.ReadLine());
//kümnendsüsteemis olev komakohaga arv
//Instantseerime muutuja "ostusumma" , ning ütlem, et sinna saab panna kümnendsüsteemis olevate arvudega
// lause lõpu lauselõpp on komakoolon
if (ostusumma > 100)
//teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "ostusumma" on suurem kui "100"
{
    Console.WriteLine("Saad 20% allahindlust");
    //peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse omistatakse nüüd väärtus kasutades
}
else if (ostusumma < 101 && ostusumma > 50)
{
    Console.WriteLine("Saad 10% allahindlust");
}
else if (ostusumma < 51 && ostusumma > 20)
{
    Console.WriteLine("Saad 5% allahindlust");
}
else if (ostusumma < 21)
{
    Console.WriteLine("Allahindlust ei saa");
}
else if (ostusumma < 1)
{
    Console.WriteLine("Sisestatud vigane arv");
}

//string kasutajanimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
//    kasutajanimi = Console.ReadLine();
//}
//while (kasutajanimi != "user1");
//if (kasutajanimi == "user1")
//{
//    int ruudusuurus = 0;
//    do
//    {
//        Console.WriteLine("Kui suurt ruutu tahad?");
//        ruudusuurus = int.Parse(Console.ReadLine());
//    }
//    while (ruudusuurus < 0 && ruudusuurus > 20);
//    char reakujund = 'i';
//    string üksrida = "";
//    int tsüklimuutuja = ruudusuurus;
//    do
//    {
//        üksrida += reakujund;
//        tsüklimuutuja -= 1;
//    } while (tsüklimuutuja != 0);
//    tsüklimuutuja = ruudusuurus;
//    do
//    {
//        Console.WriteLine(üksrida);
//        tsüklimuutuja -= 1;
//    } while (tsüklimuutuja != 0);
//    Console.WriteLine($"Palum, siin on sinu ruut, suurusega {ruudusuurus}x{ruudusuurus}");
//}

/* tingimuslause osad */
if (true) { } //kaitstud sõna kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb
          //koodiplokk tingimuse täitumisel teostava koodiga
else if (true) {} //kaitstud sõnad else ja if (if else) kutsuvad esile sekundaarse tingimuslause, mille tingimus
               //ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood
else {}  //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodiploki
         //sisu täidetakse kõikide if ja else if olevate tingimuste läbikukkumisel

/* Loogilised tehted */
// && -> Loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
//      mõlemal pool && märki olevad tingimused on täidetud. Kui neist ei ole, siis annab negatiivse vastuse (false).
// II -> loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ninng mis annab positiivse vastuse, kui kõi tingimused on täitmata
//      vähemalt üks tingimus on täidetud. Negatiivne vasus (false) tagastatakse siis, kui kõik tingimused on täitmata
// !  -> loogiline tehe, mida kasutatakse tingimuste tulemuste inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
//      puhul tagastab false ja vastupidi - tulemus mis muidu tagastaks false, hüüumärgi puhul tagastab true.

/* Võrdlusoperaatorid */
// == -> on võrdne. Võrdusmärgi ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärgi teisel pool oleva objektiga.
//      ei ole sama nagu üks võrdusmärk. üks võrdusmärk omistab, kaks võrdleb.
// != -> ei ole võrdne. Võrdusmärgi ühel pool oleva objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt
//      Võrdlusoperaator on kombinatsioon "on võrdne" operaatorist, ja loogilisest tehtest "not"
// >  -> on suurem kui. Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt.
// <  -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem kui paremal pool olev objekt.
//>=  -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
//      kui paremal pool olev objet. Operaatgor on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
// <= -> on väiksem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
//      kui paremal olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

/* Omistusoperaatorid ja kiirtehted */
int Arv = 1; // =  -> üksik võrdusmärk omistab muutujale väärtuse.
Arv +=       // += -> võrdusmärk mille ees on plus, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
             //      asendab  tehtet "arv + 1". on kombintastioon matemaatilisest tehtest "+" ja omistamises ("=") 
Arv -= 1;    // -= -> võrdusmärk mille ees on miinus, automaatselt ahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse
             //      asendab tehet "arv = arv - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest ("=")
Arv *= 2;    // *= -> võrdusmärk mille ees on korrutusmärk *. Automaatselt korrutab sisu võrdusmärgi teisest pool oleva
             //   arvu kordi. asendab tehet "arv = arv * 2" on kombinatsioon matemaatilisest tehtest "*" ja omistamisest
Arv /= 2;    // *= -> mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisl pool oleva
             //   arvu osadeks. Asendab tehet "arv = arv / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest ("=")
Arv++;       // ++ -> on spetsiifiliselt ühe juurde liitmiseks lühivariant.
Arv--;       // -- -> on spetsiifiliselt ühe maha lahutamisekt lühivariant.

/* Tsüklid */
//1. do-while
do //"Do on kaitstud sõna, mis alustab "do-while" tsüklit pärast  mida on koodiplokk, ning ütleb et tee seda koodi
{

} while (true); //niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud