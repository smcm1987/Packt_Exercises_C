using static System.Console;

//WriteLine("Before parsing");
//Write("What is your age?");
//string? input = ReadLine();

//try
//{
//    int age = int.Parse(input);
//    WriteLine($"You are {age} years old");
//}
//catch (FormatException)
//{
//    WriteLine("The age you entered is not a valid format.");
//}

//catch (OverflowException)
//{
//    WriteLine("Your age is a valid number but is too small or too large for age range.");
//}

//catch (Exception e)
//{
//    WriteLine($"{e.GetType} says {e.Message}");
//}
//WriteLine("After Parsing");

Write("Enter an amount: ");
string? amount = ReadLine();
try
{
    decimal amountValue = decimal.Parse(amount);
} catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use dollar sign!");
} catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}
