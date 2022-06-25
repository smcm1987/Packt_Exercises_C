namespace Packt.Shared
{                                  //Add to use IComparable interface, using Type T <Person> 
    public class Person : Object, IComparable<Person>
    {
        public string? Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new();
        //delegate field
        public event EventHandler? Shout;
        public int AngerLevel;
        
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public static Person SexyTime(Person man, Person woman)
        {
            Person crotchGoblin = new()
            {
                Name = $"Child of {man.Name} and {woman.Name}"
            };

            man.Children.Add(crotchGoblin);
            woman.Children.Add(crotchGoblin);

            return crotchGoblin;
        }

        public static Person operator *(Person man, Person woman)
        {
            return Person.SexyTime(man, woman);
        }

        public Person SexyTimeWith(Person partner)
        {
            return SexyTime(this, partner);
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                if(Shout != null)
                {
                    Shout?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        //default method created by VS2020
        //public int CompareTo(Person? other)
        //{
        //    throw new NotImplementedException();
        //}

        //Tells compiler how to use interface to perform compare for people. In this case, it is String.CompareTo(Person.Name)
        public int CompareTo(Person? other)
        {
            if(Name is null) return 0;
            return Name.CompareTo(other?.Name);
        }

        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }

        //Travel uses PersonException class to compare datetime parameter 
        public void Travel(DateTime when)
        {
            if (when <= DateTime.Now)
            {
                throw new PersonExcpetion($"You cannot time travel, {Name}");
            }
        }
    }
}