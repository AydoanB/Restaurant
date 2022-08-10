using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Drink : Dish
    {
        public override double Calories => this.Weight * 1.5;
    }
}