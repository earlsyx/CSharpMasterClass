

TimeOnly opensAt = TimeOnly.Parse(s: "8:00 AM");//timeonly

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(opensAt);
Console.WriteLine(rightNow);
