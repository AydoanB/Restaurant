using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Soup : Dish
    {
        public Soup(string name, double weight, decimal price) : base(name, weight, price)
        {
        }

        public override double Calories => this.Weight * 2.5;
    }
}