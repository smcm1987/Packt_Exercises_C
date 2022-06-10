using static System.Console;

//write code that takes two inputs from user. catch formatting exception
//and print string as instructed
WriteLine("Enter a number between 0 and 255: ");
string? first = ReadLine();

WriteLine("Enter another number between 0 and 255: ");
string? second = ReadLine();
try
{
    int numerator = int.Parse(first);

    int denominator = int.Parse(second);

    int result = numerator / denominator;
    WriteLine($"{numerator} divided by {denominator} is {result}");
}
catch (Exception e)
{
    WriteLine($"{e.GetType().Name}: {e.Message}");
}

//check results of bitwise and binary operators on page 130
//int x = 10 & 8;
//int y = 10 | 7;
//Write(x + "\t" + y);