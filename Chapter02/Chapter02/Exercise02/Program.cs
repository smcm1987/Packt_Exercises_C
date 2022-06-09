using static System.Console;

string[] headerRow = {"Type", "Byte(s) of Memory", "Min", "Max" };
string[] dataTypes = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
int dashCount = 87;



for (int i = 0; i <= dashCount; i++)
{
    Write("-");
}
WriteLine();
WriteLine("{0, -10} {1, -15} {2, 28} {3, 30}", headerRow[0], headerRow[1], headerRow[2], headerRow[3]);

for (int i = 0; i <= dashCount; i++)
{
    Write("-");
}
WriteLine();

WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[0], sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[1], sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[2], sizeof(short), short.MinValue, short.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[3], sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[4], sizeof(int), int.MinValue, int.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[5], sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[6], sizeof(long), long.MinValue, long.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[7], sizeof(ulong), ulong.MinValue, ulong.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[8], sizeof(float), float.MinValue, float.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[9], sizeof(double), double.MinValue, double.MaxValue);
WriteLine("{0, -10} {1, -15} {2, 30} {3, 30}", dataTypes[10], sizeof(decimal), decimal.MinValue, ulong.MaxValue);

for (int i = 0; i <= dashCount; i++)
{
    Write("-");
}