using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Salad : Dish
    {
        public Salad(string name, double weight, decimal price) : base(name, weight, price)
        {
        }

        public override double Calories => this.Weight * 0.5;
    }
}