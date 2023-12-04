using System;

int points = 0;
Console.WriteLine("Välkommen till Majkels Real Madrid-frågesport!");


Console.WriteLine("1: Hur många Champions League troféer har Real Madrid?");
Console.WriteLine("a) 10  b) 14  c) 13");
string answer1 = Console.ReadLine();
if (answer1 == "b")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}


Console.WriteLine("2: Vem är Real Madrids bästa målgörare?");
Console.WriteLine("a) Karim Benzema  b) Luis Figo  c) Cristiano Ronaldo");
string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}


Console.WriteLine("3: Hur många lig titlar har Real madrid vunnit?");
Console.WriteLine("a) 35  b) 27  c) 30");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}


Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du kan lika gärna kolla på basket.");
}
else if (points < 3)
{
  Console.WriteLine("Mhm, du har hyfsad koll - eller gissade rätt en eller ett par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du är en Merengue!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();