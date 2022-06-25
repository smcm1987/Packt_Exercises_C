using System; // String
using Packt.Shared;//string extensions
using static System.Console;
using System.Xml.Linq; //XDocument
using DialectSoftware.Collections;
using DialectSoftware.Collections.Generics;

//XDocument doc = new();

//Write("Enter the name of a color value in hex: ");
//string? hex = ReadLine(); //or 00ffc8
//WriteLine($"Is {hex} a valid color value? {hex.IsValidHex()}");

//Write("Enter an XML element: ");
//string? xml = ReadLine(); //or 00ffc8
//WriteLine($"Is {xml} a valid tag? {xml.IsValidXmlTag()}");

//Write("Enter your password: ");
//string? pass = ReadLine(); //or 00ffc8
//WriteLine($"Is {pass} a valid password? {pass.IsValidPassword()}");

Axis x = new("x", 0, 10, 1);
Axis y = new("y", 0, 4, 1);

Matrix<long> matrix = new(new[] { x, y });

for(int i = 0; i < matrix.Axes[0].Points.Length; i++)
{
    matrix.Axes[0].Points[i].Label = "x" + i.ToString();
}

for (int i = 0; i < matrix.Axes[1].Points.Length; i++)
{
    matrix.Axes[1].Points[i].Label = "y" + i.ToString();
}

foreach (long[] c in matrix)
{
    matrix[c] = c[0] + c[1];
}

foreach (long[] c in matrix)
{
    WriteLine($"{matrix.Axes[0].Points[c[0]].Label},{matrix.Axes[1].Points[c[1]].Label} ({c[0]}, {c[1]})  = {matrix[c]}");
}