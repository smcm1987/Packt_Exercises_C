using static System.Console;

//try
//{
//    checked
//    {
//        int x = int.MaxValue - 1;
//        WriteLine($"Initial Value: {x}");
//        x++;
//        WriteLine($"After incrementing: {x}");
//        x++;
//        WriteLine($"After incrementing: {x}");
//        x++;
//        WriteLine($"After incrementing: {x}");
//    }
//}
//catch (OverflowException)
//{
//    WriteLine("Overflow but this time I caught that ho");
//}

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
}