namespace PrimeFactorsLib
{
    public class PrimeFactors
    {

        string result = "";
        
        //checks if number is a prime number. Returns true if prime, else false.
        public static bool IsPrime (int primeCheck)
        {
            for (int i = 2; i <= primeCheck; i++)
            {
                if (primeCheck % i == 0 && i <= primeCheck)
                {
                    return false;
                }
            }
            return true;
        }

        public string numberFactors (int primes)
        {
            //if primeCheck fails, divide number by x and append primes to string
            if (IsPrime (primes) == false)
            {
                //walk through numbers to discover prime factors, if all but last prime is found, add number + " x " to string
                //if last prime, simply add to string.
                for (int x = 2; x <= primes; x++)
                {
                    if (primes % x == 0)
                    {
                        if (primes == x)
                        {
                            result += x.ToString();
                        } else
                        {
                            //recursive search for prime numbers
                            result += x.ToString() + (" x ");
                            return numberFactors(primes / x);
                        }
                        
                    }
                }
                
            }
            return result;
        }

    }
}