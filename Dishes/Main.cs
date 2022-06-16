namespace ConsoleApp1
{
    public class Main : Dish 
    {
        public Main(string name, double weight, decimal price) : base( name, weight, price)
        {
            this.Calories = Weight * 0.76;
        }

       
    }
}