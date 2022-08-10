using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Dessert : Dish
    {
        public override double Calories => this.Weight * 3;
    }
}