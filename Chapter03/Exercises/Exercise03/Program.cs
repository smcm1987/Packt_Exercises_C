using static System.Console;

//use loop to play FizzBuzz. Every value divisible by three is set to Fizz.
//value divisible by is set to Buzz
//value divisible by both is set to FizzBuzz
for (int fB = 1; fB <= 100; fB++)
{
    if (fB % 3 == 0 && fB % 5 == 0)
    {
        Write("FizzBuzz, ");
    }
    else if(fB % 3 == 0)
    {
        Write("Fizz, ");
    } else if (fB % 5 == 0)
    {
        Write("Buzz, ");
    } else { Write("{0}, ", fB); 
    }
}