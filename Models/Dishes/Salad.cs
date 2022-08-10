using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Salad : Dish
    {
        public override double Calories => this.Weight * 0.5;
    }
}