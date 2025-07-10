
//common way to store info aobut date and time.
using System.Globalization;

DateTime today = DateTime.UtcNow;//lose what the offset UtcNow
//DateTime Object
//DateTime birthDay = DateTime.Parse(s: "6/16/1999");//migh crash dif timezone, locale , unknown

//DateTime birthDay = DateTime.ParseExact("6/11/1999", "d/M/yyyy", CultureInfo.InvariantCulture); //don't worry about locale formatting.

//Console.WriteLine(today.ToString(format: "t"));
//Console.WriteLine(birthDay.ToString());
//lot of complefixty, leap year , differetn time zone etc.

Console.WriteLine(today.ToString(format: "MMMM dd, yyyy hh:mm tt zzz"));