using Dolgozat_gyak;
List<Eszkoz> eszkozok = new List<Eszkoz>();
if (File.Exists("eszkozok.txt"))
{
    string[] sorok = File.ReadAllLines("eszkozok.txt");
    foreach (string sor in sorok)
    {
        if (!string.IsNullOrWhiteSpace(sor))
        {
            string[] adatok = sor.Split(';');
            if (adatok.Length >= 4)
            {
                if (adatok.Length == 4)
                {
                    int.TryParse(adatok[3], out int napiDij);
                    eszkozok.Add(new Eszkoz(adatok[0], adatok[1], adatok[2], napiDij));
                }
                else if (adatok.Length == 5)
                {
                    int.TryParse(adatok[3], out int napiDij);
                    int.TryParse(adatok[4], out int keszlet);
                    eszkozok.Add(new Eszkoz(adatok[0], adatok[1], adatok[2], napiDij, keszlet));
                }
            }
            else Console.WriteLine("Nem megfelelő az adatok száma");
            continue;
        }
        else Console.WriteLine("Van(nak) üres sor(ok)");
        continue;
    }
}
else Console.WriteLine("Fájl nem létezik");

foreach (Eszkoz eszkoz in eszkozok)
{
    Console.WriteLine(eszkoz.ToString());
}

Console.WriteLine($"Összes regisztrált eszköz: {Eszkoz.OsszesRegisztraltEszkoz}");

