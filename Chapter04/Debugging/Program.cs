using static System.Console;

static double Add (double a, double b)
{
    return a + b; //Deliberate bug
}

double a = 4.25;
double b = 2.5;

double answer = Add(a, b);

WriteLine($"{a} + {b} = {answer}");

WriteLine("Press Enter to end the app");
ReadLine();
