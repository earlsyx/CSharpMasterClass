



// holds info, get initial value
string firstName = string.Empty; //standard , initial value , define, declaration
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Midoriya"; // asign    
lastName = "Izuku";
//firstName = "123";
//filePath = "C:\\Temp\\Demo \n"; // escapre character, to tell you are using special character \
filePath = @"C:\Temp\Demo";//string literal

//Console.WriteLine(firstName + " " + lastName); //print / /string literal.

string testString = $@"The file for {firstName} is at C:\SampleFiles";

//string interpolation
Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);

//hungarianNotation ,type + camel case