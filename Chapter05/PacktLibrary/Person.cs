using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person : Object
    {
        public Person()
        {
            Name = "Unknown";
            Instatiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name=initialName;
            Planet = homePlanet;
            Instatiated=DateTime.Now;
        }

        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = dateOfBirth;
        }

        public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = dateOfBirth;
            fav = FavoriteAncientWonder;
        }
        //person fields
        public const string Species = "Homo sapien";
        public readonly DateTime Instatiated;
        public readonly string Planet = "Earth";
        public string Name;
        public DateTime dateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public int tester = 99;

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {dateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {Planet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
        public (string Name, int Number) GetNamedFruit()
        {
            return ("Apples", 5);
        }

        public string SayHello()
        {
           return $"{Name} says hello!";
        }
        public string SayHello(string name)
        {
            return $"{Name} says hello {name}!";
        }

        public string OptionalParameters (string command = "Run!", double number = 0.0, bool IsOptional = true)
        {
            return $"Command us {command}, the number is {number}, and the method is set to {IsOptional}";
        }
        
        public void PassingParameters(int x, ref int y, out int z)
        {
            //out parameters cannot be default and must be assigned inside the method.
            z = tester;
            x++;
            y++;
            z++;
            
        }
    }
}
