using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {
        private string favoritePrimaryColor;
        public string Origin
        {
            get
            {
                return $"{Name} was born on {Planet}";
            }
        }

        public Person this[int index]
        {
            get { return Children[index]; }
            set { Children[index] = value; }
        }

        public string Greeting => $"{Name} says \"Hello\"!";

        //this doesn't accurately calulate the age (rounds by year).
        public int Age => DateTime.Today.Year - dateOfBirth.Year;

        public string FavoriteIceCream { get; set; }
        public string FavoritePrimaryColor { get { return favoritePrimaryColor; }
            set {
                SetFavoriteColor(value);
            }
        }
        //best practice is to break out any calculations into a private method that is invoked by the setter.
        //See below for example (compare to p.208)  
        private void SetFavoriteColor(string color)
        {
            switch (color.ToLower())
            {
                case "red":
                case "blue":
                case "yellow":
                case "green":
                    favoritePrimaryColor = color;
                    break;
                default:
                    throw new System.ArgumentException(
                        $"{color} is not a primary color. Must choose between red, blue, green, or yellow");
            }

        }


    }
}
