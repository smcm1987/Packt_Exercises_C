using static System.Console;
using static System.Convert;

//int a = 10;
//double b = a;
//WriteLine(b);

//double c = 9.8;
//int d = (int) c;
//WriteLine(d);

//long e = 10;
//int f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");
//e = 5_000_000_000;
//f = (int)e;
////f is -1 when e is 10. f is 705 million when e 5 billion
//WriteLine($"e is {e:N0} and f is {f:N0}");

//double g = 9.8;
//int h = ToInt32(g);
//WriteLine($"g is {g} and h is {h}");

//double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

//foreach(double d in doubles)
//{
//    WriteLine("Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}", d, Math.Round(d, 0, MidpointRounding.AwayFromZero));
//}

//int number = 12;
//WriteLine(number.ToString());

//bool boolean = true;
//WriteLine(boolean.ToString());

//DateTime now = DateTime.Now;
//WriteLine(now.ToString());

//Object me = new();
//WriteLine(me.ToString());

//allocate array with 128 bytes
//byte[] binaryObject = new byte[128];

////populate array with random values
//(new Random()).NextBytes(binaryObject);
//WriteLine("Binary objects as bytes:");

////iterate through array and print as hex
//for (int i = 0; i < binaryObject.Length; i++)
//{
//    Write($"{binaryObject[i]:X} ");
//}
//WriteLine();
////convert bytes to base64 encoded string
//string encoded = ToBase64String(binaryObject);

////write encoded string
//WriteLine($"Binary Objects as Base64: {encoded}");

//int age = int.Parse("27");
//DateTime birthday = DateTime.Parse("4 July 1980");

//WriteLine($"I was born {age} years ago");
//WriteLine($"My birthday is {birthday}");
//WriteLine($"My birthday is {birthday:D}");

Write("How many eggs are there? ");
string? input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
} else
{
    WriteLine("Unable to parse input");
}