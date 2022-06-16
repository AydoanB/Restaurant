namespace ConsoleApp1
{
    public class Drink : Dish
    {
        public Drink(string name, double weight, decimal price) : base(name, weight, price)
        {
            Calories = Weight * 0.1 + 50;
        }

      
    }
}