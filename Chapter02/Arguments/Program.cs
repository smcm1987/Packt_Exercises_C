using static System.Console;

// See https://aka.ms/new-console-template for more information
//WriteLine($"There are {args.Length} arguments.");
if(args.Length < 3)
{
    WriteLine("You must specify two colors and a cursor size. Eg:");
    WriteLine("red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
CursorSize = int.Parse(args[2]);

//foreach (string arg in args)
//{
//    WriteLine(arg);
//}
