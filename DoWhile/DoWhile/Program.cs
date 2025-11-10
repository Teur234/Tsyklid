
Console.WriteLine("Mis on su lemmikvärvid? sisesta ükshaaval \nKui rohkem värve ei ole, kirjuta \"rohkem pole\"");
List<string> lemmikvärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("Sisesta 1 värv korraga: ");
    sisestus = Console.ReadLine();
    if (sisestus != "rohkem pole")
    {
        lemmikvärvid.Add(sisestus);
    }

} while (sisestus != "rohkem pole");

foreach (var värv in lemmikvärvid)
{
    switch (värv)
    {
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("p u n a n e");
            break;
        case "oranž":
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kahjuks ei ole oranz saadaval");
            break;
        case "kollane":

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" k o l l a n e");
            break;
        case "roheline":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("r o h e l i n e");
            break;
        case "lilla":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("l i l l a");
            break;
        case "valge":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("v a l g e");
            break;
        case "must ":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("m u s t ");
            break;
        case "pruun":
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("p r u u n ");
            break;
        case "hall":
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("h a l l ");
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("$ Sellist värvi ei tunne {värv}");
            break;
    }
}

