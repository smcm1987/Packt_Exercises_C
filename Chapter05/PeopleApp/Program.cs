using Packt.Shared;
int a = 10;
int b = 20;

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Munger"
};
//Can't set after instantiation due to init property
//jeff.FirstName = "Geoff";

ImmutableVehicle car = new()
{
    Brand = "Honda Accord",
    Color = "Silver",
    Wheels = 4
};



ImmutableVehicle paintedCar = car with { Color = "Red" };

WriteLine($"Original color is {car.Color}. Repainted color is {paintedCar.Color} for the {paintedCar.Brand}");

ImmutableAnimal oscar = new("Oscar", "Dog", 4);
(string? who, string? what, int legs) = oscar;
WriteLine($"{who} is a {what} with {legs} legs");
Person Bob = new();
Person A = new();
//WriteLine($"{A.Name} of {A.Planet} was created at {A.Instatiated}");

Person B = new("Gunny", "Uranus");
//WriteLine($"{B.Name} of {B.Planet} was created at {B.Instatiated}");
Person Sam = new()
{
    Name = "Sam",
    dateOfBirth = new(1987, 07, 12)
};
Sam.FavoriteIceCream = "Blackberry Cobbler";
Sam.FavoritePrimaryColor = "green";
//WriteLine($"Sam's favorite Ice Cream is {Sam.FavoriteIceCream} and his favorite primary color is {Sam.FavoritePrimaryColor}");
//WriteLine(Sam.Origin);
//WriteLine(Sam.Greeting);

//WriteLine(Sam.Age);

Bob.Name = "Bob Smith";
Bob.dateOfBirth = new DateTime(1965, 12, 22);
Bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
Bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
    WondersOfTheAncientWorld.MasoluemOfHalicanarssus;
(string StringName, int FruitCount) = Bob.GetFruit();
//WriteLine($"{fruit.Item1}, {fruit.Item2} there are");

//When deconstructing, it is important to either use the assinged variable name of the tuple ("fruit.StringName") or declare it
//without the variable and use the names of parameters (StringName). 
//WriteLine($"{StringName}, {FruitCount}");

// To avoid using loosely-typed variable, you must declare a name in the type on instantiation. If name already exists for 
//type (see Person.cs), Compiler will override it with declared variable name in assignment.
//(string Numeration, int Counter) NamedFruit = Bob.GetNamedFruit();
//WriteLine($"Bob, there are {NamedFruit.Counter} {NamedFruit.Numeration}");

object[] passengers =
{
    new FirstClassPassenger{AirMiles = 1_419},
    new FirstClassPassenger{AirMiles = 16_562},
    new BusinessClassPassenger(),
    new CoachClassPassenger{CarryOnKG = 25.7},
    new CoachClassPassenger{CarryOnKG = 0}
};

foreach (object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        //C# 8.0 syntax
        //FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        //FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        //FirstClassPassenger _ => 2000M,
        //BusinessClassPassenger _ => 1000M,
        //CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        //CoachClassPassenger _ => 650M,
        //_ => 800M

        //C# 10 syntax
        //FirstClassPassenger p => p.AirMiles switch
        //{
        //    > 35000 => 1500M,
        //    > 15000 => 1750M,
        //    _ => 2000M
        //},
        //BusinessClassPassenger _ => 1000M,
        //CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        //CoachClassPassenger _ => 650M,
        //_ => 800M

        //C# 10 relation pattern
        FirstClassPassenger { AirMiles: > 35000} => 1500M,
        FirstClassPassenger { AirMiles: > 15000 } => 1750M,
        FirstClassPassenger => 2000M,
        BusinessClassPassenger => 1000M,
        CoachClassPassenger {CarryOnKG: < 10.0 } => 500M,
        CoachClassPassenger => 650M,
        _ => 800M

    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}


//WriteLine($"{Bob.Name}'s bucket list is {Bob.BucketList}");

Bob.Children.Add(new() { Name = "Zoe" });
Bob.Children.Add(new() { Name = "Alfred" });
//add dob to see change
//Bob.Children[1].dateOfBirth = DateTime.Now;
//WriteLine($"Bob's first kid is {Bob.Children[0].Name}");
//Alfred's DOB is not set, so defaults to 01/01/0001
//WriteLine($"{Bob[1].Name}'s birthday is {Bob[1].dateOfBirth:D}");

(string, int) thing1 = ("Neville", 4);
var thing2 = (Bob.Name, Bob.Children.Count());


//Weirdness happened here after formatting. Code won't work without refactoring!

//WriteLine($"{thing1.Item1} has {thing1.Item2} kids;
//WriteLine($"{thing2.Name} has {thing2.Count} kids




//Bob.WriteToConsole;
//WriteLine(Bob.GetOrigin(;
//WriteLine($"{Bob.Name} is a {Person.Species} and is from {Bob.Planet}



//WriteLine($"Bob has {Bob.Children.Count} children;
//foreach (Person child in Bob.Childr){
//    WriteLine(child.Nam;}
//WriteLine($"{Bob.Name} favorite wonder is {Bob.FavoriteAncientWonder}. Its integer is {(int)Bob.FavoriteAncientWonder}



//string BobsNa;
//DateTime BobsD;
//WondersOfTheAncientWorld bobsWonder = WondersOfTheAncientWorld.LighthouseOfAlexandr;
//Bob.Deconstruct(out BobsName, out BobsDO

//WriteLine($"{BobsName} was born on {BobsDOB:D};
//Bob.Deconstruct(out BobsName, out BobsDOB, out bobsWonde;
//WriteLine($"{BobsName} loves {bobsWonder} and was born {BobsDOB};
(string name1, DateTime dob1) = B;
//WriteLine($"Decontructed: {name1}, {dob1}



(string name2, DateTime dob2, WondersOfTheAncientWorld fav) = Bob;
//WriteLine($"Deconstructed: {name2} loves {fav} and was born {dob2:D}");

//WriteLine(Bob.SayHello());
//WriteLine(Bob.SayHello("Emiry"));

//WriteLine(Bob.OptionalParameters());
//WriteLine(Bob.OptionalParameters(IsOptional: false, command: "Jump"));
//WriteLine($"Before: a = {a}, b = {b}, c = {30}");
//Bob.PassingParameters(a, ref b, out int c);
//WriteLine($"After: a = {a}, b = {b}, c = {c}");

//Weirdness doesn't apply to code below

//Person alice = new()
//{
//    Name = "Alice Jones",
//    dateOfBirth = new(1998, 3, 7)
//};

//WriteLine($"{alice.Name} was born {alice.dateOfBirth:dd MMM yy}");

//BankAccount.InterestRate = 0.012M;

//BankAccount jonesAccount = new();
//jonesAccount.AccountName = "Mrs. Jones";
//jonesAccount.Balance = 2400;

//WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate,1:C} in interest");

//BankAccount gerrierAccount = new();
//gerrierAccount.AccountName = "Ms. Gerrier";
//gerrierAccount.Balance = 98;

//WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate,1:C} in interest");

