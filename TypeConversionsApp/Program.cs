

//variavle tpes a they are , hwo they work.
// not yet, how to convert 1 type to another.

// what types we want to, most common, from a tsring to else.
//converting from a string to something else.

// from a console , treated as string usally.
Console.Write("wHAT IS YOUR AGE");
string? ageText = Console.ReadLine();// unhandled exceptions
// not bad thing, wee want this to crash.


//Console.WriteLine(ageText + 15);//+ string , append 15.

//int age = int.Parse(ageText);

bool isValidInt = int.TryParse(ageText, out int age);//declaring age right inline, so not two step process.

//calling tryparse method, passing in text, we are saying this is an out variable , which menas it will return a value of a booelan but also return a value in the age variable too if this is valid.  
Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");
Console.WriteLine(age + 15);

// trytpase any variable types,
// haven't to string for evetytihng.
// parse to make srue the balue is valid.

// another way

double testDouble = age;
decimal testDecimal = (decimal)testDouble; // NOT ALLWOWED
// do cast instead

