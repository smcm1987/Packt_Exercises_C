using Packt.Shared;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

Person baby1 = mary.SexyTimeWith(harry);
baby1.Name = "Gary";

Person baby2 = Person.SexyTime(harry, jill);
Person baby3 = harry * mary;
DisplacementVector displacer1 = new(3, 5);
DisplacementVector displacer2 = new(-2, 7);
DisplacementVector displacer3 = displacer1 + displacer2;
WriteLine($"({displacer1.X}, {displacer1.Y}) + ({displacer2.X}, {displacer2.Y}) = ({displacer3.X}, {displacer3.Y})");
WriteLine();
Person[] people =
{
    new() { Name = "Ringo" },
    new() { Name = "John" },
    new() { Name = "Paul" },
    new() { Name = "George" }
};

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(1990, 7, 28)
};
john.WriteToConsole();
WriteLine();

john.EmployeeCode = "JJ001";
john.HireDate = new(2014, 11, 23);
WriteLine($"{john.Name} was hired {john.HireDate} and assigned code: {john.EmployeeCode}");
WriteLine();

WriteLine("Ladies and gentlemen, the Beetles: ");
foreach(Person person in people)
{
    WriteLine(person.Name);
}

WriteLine();

WriteLine("Use Person's IComparison implementation to sort:");
Array.Sort(people);
foreach (Person person in people)
{
    WriteLine(person.Name);
}

WriteLine();

WriteLine("Use PersonComparer's IComparer implementation to sort:");
Array.Sort(people, new PersonComparer());
foreach (Person person in people)
{
    WriteLine(person.Name);
}
WriteLine();

System.Collections.Hashtable lookupObject = new();
int key = 4;
//non-generic types (See output on line 34)
lookupObject.Add(1, "Alpha");
lookupObject.Add(2, "Beta");
lookupObject.Add(3, "Gamma");
lookupObject.Add(harry, "Delta");
WriteLine($"{key} has a value of {lookupObject[key]}");

//generic type <TKey> (Person)harry set to 4 
key = 4;
Dictionary<int, string> lookupString = new();
lookupString.Add(1, "Alpha");
lookupString.Add(2, "Beta");
lookupString.Add(3, "Gamma");
lookupString.Add(4, "Delta");
WriteLine($"{key} has a value of {lookupString[key]}");

//delegate - can assign multiple to field Shout
static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender == null) return;
    Person p = sender as Person;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
}
harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
//Error caught by generic
//WriteLine($"Key {harry} has a value of {lookupObject[harry]}");


WriteLine($"{harry.Name} has {harry.Children.Count} children");
WriteLine($"{mary.Name} has {mary.Children.Count} children");
WriteLine($"{jill.Name} has {jill.Children.Count} children");
WriteLine($"{harry.Name}'s first child is named \"{harry.Children[0].Name}\"");

WriteLine($"5! is {Person.Factorial(5)}");

Employee aliceInEmployee = new()
{
    Name = "Alice",
    EmployeeCode = "AA123"
};



Person aliceInPerson = aliceInEmployee;

//compiler error, must use explicit type
//Employee explicitAlice = aliceInPerson;

//no error xplicitAlice is cast from AliceInPerson as type (Object) Employee.
//May still throw exception if aliceInPerson is an instance of a different class
//Employee explicitAlice = (Employee)aliceInPerson;

//Wrap in If conditional to test type cast
//check for null variables before using any members
if(aliceInPerson is Employee explicitAlice)
{
    WriteLine($"{nameof(aliceInPerson)} is an Employee");
    //variable is now set as a part of conditional
    //Employee explicitAlice = (Employee)aliceInPerson;
    WriteLine();
}

aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());

//using PersonException in program to test for time travel shenanigans
try
{
    john.Travel(when: new(1999, 12, 31));

}
catch (PersonExcpetion ex)
{
    WriteLine(ex.Message);
}

//email type string is confirmed using our extension class (static and standard)
string email1 = "pamela@test.com";
string email2 = "ian@test.com";

WriteLine($"{email1} is valid: {email1.IsValidEmail()}");
WriteLine($"{email2} is valid: {StringExtensions.IsValidEmail(email2)}");

