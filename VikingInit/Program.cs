using VikingKozos;

using VikingContext context = new VikingContext();

if (!context.Huzasok.Any())
{
    Console.WriteLine("Nincs adat a Huzasok táblában.");
    var sorok = File.ReadAllLines(@"C:\adat\VikingLottoSzamok.csv");
    List<Huzas> szamok = new List<Huzas>();
    foreach (var sor in sorok)
    {
        try
        {            
            szamok.Add(new Huzas(sor));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba a sor feldolgozásakor: {ex.Message}");
        }
    }
    context.Huzasok.AddRange(szamok);
    context.SaveChanges();
}
else
{
   
    foreach (var huzas in context.Huzasok)
    {
        Console.WriteLine(huzas);
    }
}

