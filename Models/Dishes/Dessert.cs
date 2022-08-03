namespace ConsoleApp1
{
    public class Dessert : Dish
    {
        public Dessert(string category,string name, double weight, decimal price) : base(category,name, weight, price)
        {
            Calories= Weight * 1 + 10;
        }

        
    }
}