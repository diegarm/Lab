// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;


Console.WriteLine("Date Format");
DateTime dt = DateTime.UtcNow;

var culture = new CultureInfo("es");

Func<DateTime, TimeZoneInfo, TimeSpan> GetOffset = (date, tInfo) =>
{
    TimeSpan timeZoneOffSet = tInfo.IsDaylightSavingTime(date) ? tInfo.BaseUtcOffset.Add(TimeSpan.FromHours(1)) : tInfo.BaseUtcOffset;
    return timeZoneOffSet;
};

TimeZoneInfo timeInfo = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");

dt = dt.Add(GetOffset(dt, timeInfo));

Console.WriteLine(dt.ToString("d", culture));  // Data curta
Console.WriteLine(dt.ToString("D", culture));  // Data longa
Console.WriteLine(dt.ToString("t", culture));  // Hora curta
Console.WriteLine(dt.ToString("T", culture));  // Hora longa
Console.WriteLine(dt.ToString("f", culture));  // Data longa + hora curta
Console.WriteLine(dt.ToString("F", culture));  // Data longa + hora longa
Console.WriteLine(dt.ToString("g", culture));  // Data curta + hora curta
Console.WriteLine(dt.ToString("G"));  // Data curta + hora longa
Console.WriteLine(dt.ToString("M", culture));  // Mês e dia
Console.WriteLine(dt.ToString("Y", culture));  // Mês e ano
Console.WriteLine(dt.ToString("O", culture));  // ISO 8601 completo
Console.WriteLine(dt.ToString("R", culture));  // RFC1123
Console.WriteLine(dt.ToString("s", culture));  // ISO 8601 sem fuso horário
Console.WriteLine(dt.ToString("u", culture));  // Universal sortable (UTC)


var list = new List<string>() { "AbCd", "eFgH" };
var list2 = new List<string>() { "AbCd", "efgh" };

var commandCodeSet = new HashSet<string>(list, StringComparer.OrdinalIgnoreCase);


var appointmentActivityCodesToAdd = list2.Where(r => !commandCodeSet.Contains(r));

foreach (var item in appointmentActivityCodesToAdd)
{
    Console.WriteLine(item.ToString());
}

