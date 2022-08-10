using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Main : Dish
    {
        public Main(string name, double weight, decimal price) : base(name, weight, price)
        {
        }

        public override double Calories => this.Weight * 2.5;

    }
}