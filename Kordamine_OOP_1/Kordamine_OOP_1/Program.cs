/*Koduloom koer = new Koduloom("Murka", "Sinine", 'E', 10.7, 7, true);
koer.print_Info();
Koduloom koerKloon = new Koduloom(koer);*/
//Koduloom koer = new Koer("Daniil","Oleg", "Sinine", 'E', 10.7, 7, false);
//koer.print_Info();
using Kordamine_OOP_1;

List<Isik> people = new List<Isik>();




Tootaja tootaja1 = new Tootaja("TTHK", Tootaja.amet.Manager, "TTHK", "Evgeniy", 1990, Isik.sugu.mees, 500, 2300);
tootaja1.printInfo();
tootaja1.arvutaVanus();
Kutsekooliopilane Kopilane = new Kutsekooliopilane(60,"Tallinn", 450, 3, 4.5, "THK", "tarkvara arendaja", "MEHpv22", "Luda", 2004, Isik.sugu.naine, 0, 0, 0,Kutsekooliopilane.eriala.Welder);
Kopilane.printInfo();
Kopilane.arvutaVanus();





people.Add(tootaja1);
people.Add(Kopilane);


StreamWriter to_file = new StreamWriter(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt", false);
foreach (Isik p in people)
{
    p.printInfo();
    to_file.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.Inimsugu + ";");
}
to_file.Close();
StreamReader from_file = new StreamReader(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt");
string text1 = from_file.ReadToEnd();
Console.WriteLine(text1);
from_file.Close();

List<Isik> LoetudFailist = new List<Isik>();
StreamReader sr = new StreamReader(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt");
List<string> lines = new List<string>();
int n = sr.ReadToEnd().Split(new char[] { '\n' }).Length;
Console.WriteLine("-----"+n+"-----");
sr.Close();

List<Tootaja> tootajad = new List<Tootaja>();
sr = new StreamReader(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    tootajad.Add(new Tootaja(rida[0], TextFailistAmet(rida[1]), rida[2], rida[3], int.Parse(rida[4]), TextFailistEnumSugu(rida[5]), double.Parse(rida[6]), double.Parse(rida[7])));
}
sr.Close();
foreach (var tootaja in tootajad)
{
    Console.WriteLine(tootaja.nimi + " " + tootaja.Inimsugu);
}
Console.ReadLine();
Isik.sugu TextFailistEnumSugu(string andmed)
{
    switch (andmed)
    {
        case "naine":
            return Isik.sugu.naine;
        default:
            return Isik.sugu.mees;
    }
}

Console.ReadLine();
Tootaja.amet TextFailistAmet(string andmed)
{
    switch (andmed)
    {
        case "Manager":
            return Tootaja.amet.Manager;
        default:
            return Tootaja.amet.Designer;
    }
}



