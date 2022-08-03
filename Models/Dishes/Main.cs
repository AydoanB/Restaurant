namespace ConsoleApp1
{
    public class Main : Dish 
    {
        public Main(string category, string name, double weight, decimal price) : base(category, name, weight, price)
        {
            this.Calories = Weight * 0.76;
        }

       
    }
}