using PrimeFactorsLib;
// See https://aka.ms/new-console-template for more information

//Initialize primeFactors class and string to add prime factors to (primeList). Append numberFactors return to primeList and 
//Write to console.
PrimeFactors primeFactors = new PrimeFactors();
string? primeList = "Prime Factors: ";

primeList += primeFactors.numberFactors(393);

Console.WriteLine(primeList);  
