using static System.Console;// See https://aka.ms/new-console-template for more information
int a = 10;
int b = 6;

//WriteLine($"a << 3 = {a << 3}");
//WriteLine($"a * 8 = {a * 8}");
//WriteLine($"b >> 1 = {b >> 1}");
WriteLine();
WriteLine("Outputting integers as binary:");
WriteLine($"a = {ToBinaryString(a)}");
WriteLine($"b = {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase:2).PadLeft(8, '0');
}