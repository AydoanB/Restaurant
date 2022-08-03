namespace ConsoleApp1
{
    public class Drink : Dish
    {
        public Drink(string category, string name, double weight, decimal price) : base(category,name, weight, price)
        {
            Calories = Weight * 0.1 + 50;
        }

      
    }
}