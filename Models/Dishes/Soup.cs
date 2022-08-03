namespace ConsoleApp1
{
    public class Soup : Dish
    {
        public Soup(string category, string name, double weight, decimal price) : base(category, name, weight, price)
        {
            Calories = Weight * 0.23 + 2;
        }


    }
}