using static System.Console;

WriteLine("I can run from anywhere!");

WriteLine($"OS Version is {Environment.OSVersion}");

if (OperatingSystem.IsMacOS())
{
    WriteLine("I am mac OS");
} else if (OperatingSystem.IsWindowsVersionAtLeast(10))
{
    WriteLine("I am operating on Windows 10 or 11");
} else
{
    WriteLine("I am writing from something else entirely");
}
WriteLine("Press Enter to Stop Me!");
ReadLine();