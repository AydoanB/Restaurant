namespace ConsoleApp1
{
    public class Soup : Dish
    {
        public Soup(string name, double weight, decimal price) : base(name, weight, price)
        {
            Calories = Weight * 0.23 + 2;
        }

       
    }
}