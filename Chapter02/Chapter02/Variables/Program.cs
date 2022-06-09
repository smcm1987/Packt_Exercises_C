using System.Xml;

/*object height = 1.8;
object name = "Amir";
Console.WriteLine($"{name} is {height} meters tall.");

//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

dynamic something = "Ahmed";
something = 12;
something = new[] { 3, 5, 7 };

Console.WriteLine($"Length is {something.Length}");


var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something.txt");
StreamWriter file2 = File.CreateText("something.txt");


Console.WriteLine($"default (int) = {default(int)}");
Console.WriteLine($"default (bool) = {default(bool)}");
Console.WriteLine($"default (DateTime) = {default(DateTime)}");
Console.WriteLine($"default (string) = {default(string)}");

int number = 13;
Console.WriteLine($"The assigned int is {number}");
number = default;
Console.WriteLine($"The default int is {number}");
*/

string[] names = new string[4];
names[0] = "Jack";
names[1] = "Jill";
names[2] = "Steve";
names[3] = "Donkey";

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

string[] otherNames = new string[] { "Kate", "Tom", "Pat", "Fred" };
