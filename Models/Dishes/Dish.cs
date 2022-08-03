using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Dish : IDish
    {
        private string[] possibleDishCategories = { "salad", "soup", "main", "dessert", "drink" };

        public Dish(string category, string name, double weight, decimal price)
        {
            if (possibleDishCategories.Contains(category))
            {
                //TODO
                this.Category=category;
            }
            this.Name = name;
            this.Weight = weight;
            this.Price = price;
        }

        private string category;

        public string Category
        {
            get => category;
            set => category = value;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Името не трябва да съдържа числа! / Contains numbers");
                }
                name = value;
            }
        }


        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Трябва да е между 0 и 1000 / Must be between 0 and 1000");
                }
                weight = value;
            }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0 || value > 100)
                {

                    throw new ArgumentOutOfRangeException("Трябва да е между 0 и 100 / Must be between 0 and 100");
                }
                price = value;
            }
        }

        private double calories;

        public double Calories
        {
            get { return calories; }
            set
            {
                calories = value;
            }
        }


        public override string ToString()
        {
            return $"[{this.GetType().Name}]: {name} {price} lv.";
        }
    }
}