using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Soup : Dish
    {
        public override double Calories => this.Weight * 2.5;
    }
}