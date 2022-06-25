using static System.Console;

//uncomment to see compiler error
//int thisCannotBeNull = 4;
//thisCannotBeNull = null;

int? thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

Address address = new();
address.Buidling = null;
address.Street = null;
address.City = "Austin";
address.Region = null;
class Address
{
    public string? Buidling;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}
