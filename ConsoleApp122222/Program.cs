

using ConsoleApp122222;


//IV. OSA
Inimene inimene = new Inimene("Erik");
inimene.Sünniaasta = 2000;
inimene.ÜtleVanus();

Tootaja tootaja = new Tootaja();
tootaja.Nimi = "Madis";
tootaja.Töötasu = 1000;
decimal palk = tootaja.Sissetulek(tootaja.Töötasu);
Console.WriteLine(tootaja.Nimi + " saab kätte " + palk);
Senior senior = new Senior();
senior.Nimi = "Meelis";
senior.Tööstaž = 10;
decimal pension = senior.Sissetulek(1000);
Console.WriteLine(senior.Nimi + " saab kätte " + pension);
