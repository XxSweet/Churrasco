﻿int adultoConAlcohol, adultosSinAlcohol, ninõs, adultos, perssonas;
double carne, acompanãmientos, cerveza, refresco, agua;

Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consume alcohol).......: ");
adultoConAlcohol = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que no bebe alcohol)...: ");
adultosSinAlcohol = Convert.ToInt32(Console.ReadLine());

Console.Write("Ninõs........................................: ");
ninõs = Convert.ToInt32(Console.ReadLine());

adultos = adultoConAlcohol + adultosSinAlcohol;
perssonas = adultos + ninõs;

carne = 0.4 * adultos + 0.2 * ninõs;
acompanãmientos = 0.2 * perssonas;
cerveza = 2 * adultoConAlcohol;
refresco = 0.5 * (adultosSinAlcohol + ninõs);
agua = 0.4 * perssonas;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Carne.............: {carne:N1}kg");
Console.WriteLine($"acompanãmientos...: {acompanãmientos:N1}kg");
Console.WriteLine($"Cerveza...........: {cerveza:N1}l");
Console.WriteLine($"refresco......: {refresco:N1}l");
Console.WriteLine($"Água..............: {agua:N1}l");
