DateTime today = DateTime.Now;




//backward and forward ocmpatbility, so DateOnly isnteadof Date
DateOnly birthday = DateOnly.Parse(s: "6/11/1998");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));


Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Today just date: {birthday}");