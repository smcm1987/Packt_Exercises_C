using static System.Console;
//execute for loop as described on 129. Add error checker to prevent unknown issue.
int max = 500;

//wrap in checked, try catch blocks and add overflow exception to stop after 1 iteration.
checked
{
    try
    {
        //creates infinte loop from 1 - 255, never reaching max value
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
    catch (OverflowException)
    {
        WriteLine("Max bytes is 255");
    }
}
