// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;


Console.WriteLine("Date Format");
DateTime dt = DateTime.Now;

System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es");

Console.WriteLine(dt.ToString("d", culture));  // Data curta
Console.WriteLine(dt.ToString("D", culture));  // Data longa
Console.WriteLine(dt.ToString("t", culture));  // Hora curta
Console.WriteLine(dt.ToString("T", culture));  // Hora longa
Console.WriteLine(dt.ToString("f", culture));  // Data longa + hora curta
Console.WriteLine(dt.ToString("F", culture));  // Data longa + hora longa
Console.WriteLine(dt.ToString("g", culture));  // Data curta + hora curta
Console.WriteLine(dt.ToString("G", culture));  // Data curta + hora longa
Console.WriteLine(dt.ToString("M", culture));  // Mês e dia
Console.WriteLine(dt.ToString("Y", culture));  // Mês e ano
Console.WriteLine(dt.ToString("O", culture));  // ISO 8601 completo
Console.WriteLine(dt.ToString("R", culture));  // RFC1123
Console.WriteLine(dt.ToString("s", culture));  // ISO 8601 sem fuso horário
Console.WriteLine(dt.ToString("u", culture));  // Universal sortable (UTC)

