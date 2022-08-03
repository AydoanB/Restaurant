namespace ConsoleApp1
{
    public class Salad : Dish
    {
        public Salad(string category,string name, double weight, decimal price) : base(category,name, weight, price)
        {
            Calories = Weight * 0.5 + 50;
        }

        
    }
}