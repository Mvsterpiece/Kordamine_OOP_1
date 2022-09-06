/*Koduloom koer = new Koduloom("Murka", "Sinine", 'E', 10.7, 7, true);
koer.print_Info();
Koduloom koerKloon = new Koduloom(koer);*/
//Koduloom koer = new Koer("Daniil","Oleg", "Sinine", 'E', 10.7, 7, false);
//koer.print_Info();
using Kordamine_OOP_1;

List<Isik> people = new List<Isik>();




Tootaja tootaja = new Tootaja("TTHK", Tootaja.amet.Manager, "TTHK", "Evgeniy", 1990, Isik.sugu.isane, 500, 2300);
tootaja.printInfo();
tootaja.arvutaVanus();
Kutsekooliopilane Kopilane = new Kutsekooliopilane(60,"Tallinn", 450, 3, 4.5, "THK", "tarkvara arendaja", "MEHpv22", "Luda", 2004, Isik.sugu.emane, 0, 0, 0);
Kopilane.printInfo();
Kopilane.arvutaVanus();





people.Add(tootaja);
people.Add(Kopilane);


StreamWriter to_file = new StreamWriter(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt", false);
foreach (Isik p in people)
{
    p.printInfo();
    to_file.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.Inimsugu + ";");
}
to_file.Close();
StreamReader from_file = new StreamReader(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt");
string text = from_file.ReadToEnd();
Console.WriteLine(text);
from_file.Close();

List<Isik> LoetudFailist = new List<Isik>();
StreamReader sr = new StreamReader(@"C:\Users\opilane\source\repos\Saiko_TARpv21\Kordamine_OOP_1\People.txt");
List<string> lines = new List<string>();
int n = sr.ReadToEnd().Split(new char[] { '\n' }).Length;
Console.WriteLine("-----"+n+ "-----");