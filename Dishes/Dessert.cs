namespace ConsoleApp1
{
    public class Dessert : Dish
    {
        public Dessert(string name, double weight, decimal price) : base(name, weight, price)
        {
            Calories= Weight * 1 + 10;
        }

        
    }
}