namespace ConsoleApp1
{
    public class Salad : Dish
    {
        public Salad(string name, double weight, decimal price) : base(name, weight, price)
        {
            Calories = Weight * 0.5 + 50;
        }

        
    }
}