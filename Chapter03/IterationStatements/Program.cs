using static System.Console;

//int x = 0; 
//while (x < 10)
//{
//    WriteLine(x);
//    x++;
//}

//string? password;
//int x = 0;
//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
//    x++;
//} while (password != "Pa$$w0rd" && x < 10);

//if (x == 10)
//{
//    WriteLine("You're locked out, dumbass!");
//} else { 
//    WriteLine("Correct!"); 
//}

//for (int i = 1; i <= 10; i++)
//{
//    WriteLine(i);
//}

string[] names = { "Adam", "Barry", "Charlie" };

foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters");
    
}