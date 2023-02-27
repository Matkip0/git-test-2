// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
int Nummer1 = 0;
int Nummer2 = 0;


Console.WriteLine("Indtast det første tal");
Nummer1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indtast det andet tal");
Nummer2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"tallene giver {Nummer1 + Nummer2}");

Console.WriteLine("Vælg hvad du vil have numrene til at gøre ved brug af");
Console.WriteLine("mulighederne er +, -, *, /,");
string svar = Console.ReadLine();

if (svar == ("+"))
{
    Console.WriteLine($"tallene giver {Nummer1 + Nummer2}");
}
if (svar == ("-"))
{
    Console.WriteLine($"tallene giver {Nummer1 - Nummer2}");
}
if (svar == ("*"))
{
    Console.WriteLine($"tallene giver {Nummer1 * Nummer2}");
}
if (svar == ("/"))
{
    Console.WriteLine($"tallene giver {Nummer1 / Nummer2}");
}
